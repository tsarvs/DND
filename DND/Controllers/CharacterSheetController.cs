using System;
using System.Collections.Generic;
using System.Linq;
using DND.Models;
using DND.Views.Enums;
using DND.Views.Forms;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class CharacterSheetController
    {
        #region Properties

        private int _characterId;

        private readonly ICharacterSheetForm _view;

        private List<CHARACTER_CLASS> _loadedCharacterClasses;

        private readonly List<CHARACTER_ATTACK> _loadedCharacterAttacks;

        #endregion

        #region Constructors

        public CharacterSheetController(ICharacterSheetForm view)
        {
            _view = view;
            _loadedCharacterClasses = new List<CHARACTER_CLASS>();
            _loadedCharacterAttacks = new List<CHARACTER_ATTACK>();
        }

        #endregion

        #region Methods

        public void InitializeData(int characterId)
        {
            _characterId = characterId;

            using (var db = new DragonDBModel())
            {
                _view.RaceComboBox.DataSource = db.RACE.ToList();
                _view.RaceComboBox.ValueMember = "r_id";
                _view.RaceComboBox.DisplayMember = "r_name";
                _view.RaceComboBox.SelectedItem = null;

                _view.ClassComboBox.ValueMember = "cl_id";
                _view.ClassComboBox.DisplayMember = "cl_name";
                _view.ClassComboBox.SelectedItem = null;
            }

            UpdateFeatGrid();
            UpdateCharacterClasses();
        }

        public void SaveCharacter()
        {
            var mode = _view.CharacterSheetMode;

            if (mode == FormMode.NewForm)
                AddCharacter();
            else if (mode == FormMode.EditForm) UpdateCharacter();
        }

        public void LoadCharacterSheet()
        {
        }

        public void UpdateFeatControls()
        {
            using (var db = new DragonDBModel())
            {
                string featDescription;

                if (_view.FeatGridView.SelectedRows.Count == 0)
                    featDescription = "";
                else
                    featDescription =
                        (from f in db.FEATS.ToList()
                            where f.f_name == _view.FeatGridView.SelectedRows[0].Cells[0].Value.ToString()
                            where f.f_source == _view.FeatGridView.SelectedRows[0].Cells[1].Value.ToString()
                            select f.f_description).FirstOrDefault();

                _view.FeatDescription = featDescription;
            }
        }

        public void ManageFeats()
        {
            var form = new FeatManagerForm(_characterId, _view);

            form.SetController(new FeatManagerController(form));

            form.Show();
        }

        public void AddClass()
        {
            var form = new ClassManagerForm(_characterId, _loadedCharacterClasses);

            form.SetController(new ClassManagerController(form, _view));

            form.Show();
        }

        public void LoadCharacterClasses(List<CHARACTER_CLASS> characterClassList)
        {
            _loadedCharacterClasses = characterClassList;

            _view.ClassComboBox.DataSource =
                (from cc in _loadedCharacterClasses
                    select cc.CLASS).ToList();
        }
        
        public void UpdateLevel()
        {
            var selectedClass = (CLASS) _view.ClassComboBox.SelectedItem;

            if (selectedClass == null)
                return;

            var selectedClassId = selectedClass.cl_id;

            _view.Level =
                (from cc in _loadedCharacterClasses
                    where cc.cc_clid == selectedClassId
                    select cc.cc_level).FirstOrDefault().GetValueOrDefault(1);
        }

        public void UpdateFeatGrid()
        {
            using (var db = new DragonDBModel())
            {
                var featsGridContent =
                    from f in db.FEATS.ToList()
                    where f.CHARACTER.Any(x => x.c_id == _characterId)
                    select new
                    {
                        Feat = f.f_name,
                        Source = f.f_source
                    };

                _view.FeatGridView.DataSource = featsGridContent.ToList();
            }
        }

        public void UpdateCharacterClasses()
        {
            using (var db = new DragonDBModel())
            {
                _view.ClassComboBox.DataSource =
                    (from c in db.CHARACTER_CLASS.ToList()
                        where c.cc_cid == _characterId
                        select c.CLASS).ToList();
            }
        }
        
        public void UpdateClassLevel()
        {
            var selectedClass = (CLASS) _view.ClassComboBox.SelectedItem;
            var newLevel = _view.Level;

            _loadedCharacterClasses.Find(x => x.cc_clid == selectedClass.cl_id).cc_level = newLevel;
        }

        public void AddAttack()
        {
            var form = new AddEditAttackForm();

            form.SetController(new AddAttackController(form, _view));

            form.Show();
        }

        public void AddAttackToGrid(CHARACTER_ATTACK attack)
        {
            _loadedCharacterAttacks.Add(attack);

            RefreshAttackDataSource();

            _view.AttackGridView.Columns[0].Visible = false;
        }

        public void UpdateAttackControls()
        {
            var selectedRow = _view.AttackGridView.SelectedRows;

            if (selectedRow.Count == 0)
                return;

            var selectedAttack =
                _loadedCharacterAttacks.FirstOrDefault(x => x.a_id == (int) selectedRow[0].Cells[0].Value);

            if (selectedAttack == null)
            {
                _view.AttackDescription = "";
            }
            else
            {
                if (!selectedAttack.a_damage1.Equals("") || !selectedAttack.a_damage2.Equals(""))
                {
                    _view.AttackDescription = "Damage:";

                    if (!selectedAttack.a_damage1.Equals(""))
                        _view.AttackDescription += "\r\n\t" + selectedAttack.a_damage1;

                    if (!selectedAttack.a_damage2.Equals(""))
                        _view.AttackDescription += "\r\n\t" + selectedAttack.a_damage2;
                }

                _view.AttackDescription += "\r\n\r\n" + selectedAttack.a_description;
            }
        }

        public void EditAttack()
        {
            var selectedRows = _view.AttackGridView.SelectedRows;

            if (selectedRows.Count == 0)
                return;

            var selectedId = (int) selectedRows[0].Cells[0].Value;

            var selectedAttack = _loadedCharacterAttacks.Find(x => x.a_id == selectedId);

            var form = new AddEditAttackForm(selectedAttack);

            form.SetController(new AddAttackController(form, _view));

            form.Show();
        }

        public void UpdateAttackGrid(CHARACTER_ATTACK attack)
        {
            var attackToUpdate = _loadedCharacterAttacks.Find(x => x.a_id == attack.a_id);

            attackToUpdate.a_name = attack.a_name;
            attackToUpdate.a_attackability = attack.a_attackability;
            attackToUpdate.a_attackbonus = attack.a_attackbonus;
            attackToUpdate.a_isproficient = attack.a_isproficient;
            attackToUpdate.a_range = attack.a_range;
            attackToUpdate.a_damage1 = attack.a_damage1;
            attackToUpdate.a_damage2 = attack.a_damage2;
            attackToUpdate.a_description = attack.a_description;

            RefreshAttackDataSource();
        }
        
        public void DeleteSelectedAttack()
        {
            var selectedAttack = _view.AttackGridView.SelectedRows[0];

            if (selectedAttack == null)
                return;

            var selectedAttackId = (int) selectedAttack.Cells[0].Value;

            _loadedCharacterAttacks.Remove(_loadedCharacterAttacks.Find(x => x.a_id == selectedAttackId));

            RefreshAttackDataSource();

            _view.AttackDescription = "";
        }

        private void AddCharacter()
        {
            using (var db = new DragonDBModel())
            {
                var characterRace =
                    (from r in db.RACE.ToList()
                     where r.r_name == _view.RaceComboBox.SelectedText
                     select r).First();

                var primaryClass =
                    (from cl in db.CLASS.ToList()
                     where cl.cl_name == _view.ClassComboBox.SelectedText
                     select cl).First();

                var characterClass = new List<CHARACTER_CLASS>
                {
                    new CHARACTER_CLASS
                    {
                        CLASS = primaryClass,
                        cc_level = _view.Level
                    }
                };

                var characterAbilities = new CHARACTER_ABILITY
                {
                    ca_CHA = _view.CHA,
                    ca_CON = _view.CON,
                    ca_DEX = _view.DEX,
                    ca_INT = _view.INT,
                    ca_STR = _view.STR,
                    ca_WIS = _view.WIS
                };

                var characterSkill = new List<SKILL>
                {
                    new SKILL
                    {
                        s_animalhandling = _view.AnimalHandling,
                        s_athletics = _view.Athletics,
                        s_arcana = _view.Arcana,
                        s_deception = _view.Deception,
                        s_history = _view.History,
                        s_insight = _view.Insight,
                        s_intimidation = _view.Intimidation,
                        s_medicine = _view.Medicine,
                        s_nature = _view.Nature,
                        s_perception = _view.Perception,
                        s_performance = _view.Performance,
                        s_persuasion = _view.Persuasion,
                        s_religion = _view.Religion,
                        s_sleightofhand = _view.SleightOfHand,
                        s_stealth = _view.Stealth,
                        s_survival = _view.Survival
                    }
                };


                var character = new CHARACTER
                {
                    c_name = _view.CharacterName,
                    c_alignment = _view.Alignment,
                    c_hpcurrent = _view.HpCurrent,
                    c_hpmax = _view.HpMax,
                    c_hptemp = _view.HpTemp,
                    c_inspiration = _view.HasInspiration,
                    c_isNPC = _view.IsNpc,
                    CHARACTER_ABILITY = characterAbilities,
                    RACE = characterRace,
                    CHARACTER_CLASS = characterClass,
                    SKILL = characterSkill
                };

                db.CHARACTER.Add(character);
                db.SaveChanges();
            }
        }

        private void UpdateCharacter()
        {
            throw new NotImplementedException();
        }

        private void RefreshAttackDataSource()
        {
            _view.AttackGridView.DataSource =
                (from ca in _loadedCharacterAttacks
                    select new
                    {
                        ID = ca.a_id,
                        Name = ca.a_name,
                        Attack = ca.a_attackability + " + " + ca.a_attackbonus,
                        Range = ca.a_range
                    }).ToList();
        }

        #endregion
    }
}