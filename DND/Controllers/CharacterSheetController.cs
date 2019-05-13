using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

        private ICharacterSheetForm _view;

        private List<CHARACTER_CLASS> _loadedCharacterClasses;

        #endregion

        #region Constructors

        public CharacterSheetController(ICharacterSheetForm view)
        {
            _view = view;
            _loadedCharacterClasses = new List<CHARACTER_CLASS>();
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
            {
                AddCharacter();
            }
            else if (mode == FormMode.EditForm)
            {
                UpdateCharacter();
            }
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
                {
                    featDescription = "";
                }
                else
                {
                    featDescription =
                        (from f in db.FEATS.ToList()
                            where (f.f_name == _view.FeatGridView.SelectedRows[0].Cells[0].Value.ToString())
                            where (f.f_source == _view.FeatGridView.SelectedRows[0].Cells[1].Value.ToString())
                            select f.f_description).FirstOrDefault();
                }
                
                _view.FeatDescription = featDescription;
            }
        }

        public void ManageFeats()
        {
            FeatManagerForm form = new FeatManagerForm(_characterId, this._view);

            form.SetController(new FeatManagerController(form));

            form.Show();


        }

        public void AddClass()
        {
            ClassManagerForm form = new ClassManagerForm(_characterId, _loadedCharacterClasses);

            form.SetController(new ClassManagerController(form, this._view));

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
                    where (f.CHARACTER.Any(x => x.c_id == _characterId))
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
                        where (c.cc_cid == _characterId)
                        select c.CLASS).ToList();
            }
        }

        private void AddCharacter()
        {
            using (var db = new DragonDBModel())
            {
                var characterRace =
                    (from r in db.RACE.ToList()
                     where (r.r_name == _view.RaceComboBox.SelectedText)
                     select r).First();

                var primaryClass =
                    (from cl in db.CLASS.ToList()
                     where (cl.cl_name == _view.ClassComboBox.SelectedText)
                     select cl).First();

                var characterClass = new List<CHARACTER_CLASS>
                {
                    new CHARACTER_CLASS
                    {
                        CLASS = primaryClass,
                        cc_level = _view.Level
                    }
                };

                CHARACTER_ABILITY characterAbilities = new CHARACTER_ABILITY
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


                CHARACTER character = new CHARACTER
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

        public void UpdateClassLevel()
        {
            var selectedClass = (CLASS) _view.ClassComboBox.SelectedItem;
            var newLevel = _view.Level;

            _loadedCharacterClasses.Find(x => x.cc_clid == selectedClass.cl_id).cc_level = newLevel;

        }

        #endregion
    }
}
