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

        #endregion

        #region Constructors

        public CharacterSheetController(ICharacterSheetForm view)
        {
            _view = view;
        }

        #endregion

        #region Methods

        public void BindData(int characterId = 0)
        {
            using (var db = new DragonDBModel())
            {
                //cmbRace
                _view.RaceComboBox.DataSource = db.RACE.ToList();
                _view.RaceComboBox.ValueMember = "r_id";
                _view.RaceComboBox.DisplayMember = "r_name";
                _view.RaceComboBox.SelectedItem = null;

                //cmbClass
                _view.ClassComboBox.DataSource = db.CLASS.ToList();
                _view.ClassComboBox.ValueMember = "cl_id";
                _view.ClassComboBox.DisplayMember = "cl_name";
                _view.ClassComboBox.SelectedItem = null;

                //dgvFeats
                var featsGridContent =
                    from f in db.FEATS.ToList()
                    where (f.CHARACTER.Any(x => x.c_id == characterId))
                    select new
                    {
                        Feat = f.f_name,
                        Source = f.f_source
                    };

                _view.FeatGridView.DataSource = featsGridContent.ToList();
                
            }
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

        public void LoadCharacterSheet(int characterId)
        {
            _characterId = characterId;

            using (var db = new DragonDBModel())
            {
                var characterLoad = 
                    (from c in db.CHARACTER.ToList()
                     where (c.c_id == characterId)
                     select new
                     {
                        ID = c.c_id,
                        Name = c.c_name,
                        Race = c.RACE.r_name,
                        Alignment = c.c_alignment,
                        HPcurrent = c.c_hpcurrent,
                        HPmax = c.c_hpmax,
                        HPtemp = c.c_hptemp,
                        isNPC = c.c_isNPC,
                        Inspiration = c.c_inspiration,
                        CHA = c.CHARACTER_ABILITY.ca_CHA,
                        CON = c.CHARACTER_ABILITY.ca_CON,
                        DEX = c.CHARACTER_ABILITY.ca_DEX,
                        INT = c.CHARACTER_ABILITY.ca_INT,
                        STR = c.CHARACTER_ABILITY.ca_STR,
                        WIS = c.CHARACTER_ABILITY.ca_WIS,
                        Skills = c.SKILL.First()
                     }).First();

                var classLoad =
                    (from cl in db.CHARACTER_CLASS
                    where (cl.CHARACTER.c_id == characterLoad.ID)
                    select new
                    {
                        CharacterClass = cl.CLASS.cl_name,
                        Level = cl.cc_level
                    }).First();

                _view.CharacterName = characterLoad.Name;
                _view.Race = characterLoad.Race;
                _view.Alignment = characterLoad.Alignment;
                _view.HPcurrent = characterLoad.HPcurrent;
                _view.HPmax = characterLoad.HPmax;
                _view.HPtemp = characterLoad.HPtemp;
                _view.IsNPC = characterLoad.isNPC;
                _view.HasInspiration = characterLoad.Inspiration;
                _view.CHA = characterLoad.CHA;
                _view.CON = characterLoad.CON;
                _view.DEX = characterLoad.DEX;
                _view.INT = characterLoad.INT;
                _view.STR = characterLoad.STR;
                _view.WIS = characterLoad.WIS;
                _view.AnimalHandling = characterLoad.Skills.s_animalhandling;
                _view.Arcana = characterLoad.Skills.s_arcana;
                _view.Athletics = characterLoad.Skills.s_athletics;
                _view.Deception = characterLoad.Skills.s_deception;
                _view.History = characterLoad.Skills.s_history;
                _view.Insight = characterLoad.Skills.s_insight;
                _view.Intimidation = characterLoad.Skills.s_intimidation;
                _view.Medicine = characterLoad.Skills.s_medicine;
                _view.Nature = characterLoad.Skills.s_nature;
                _view.Perception = characterLoad.Skills.s_perception;
                _view.Performance = characterLoad.Skills.s_performance;
                _view.Persuasion = characterLoad.Skills.s_persuasion;
                _view.Religion = characterLoad.Skills.s_religion;
                _view.SleightOfHand = characterLoad.Skills.s_sleightofhand;
                _view.Stealth = characterLoad.Skills.s_stealth;
                _view.Survival = characterLoad.Skills.s_survival;

                _view.Class = classLoad.CharacterClass;
                _view.Level = classLoad.Level;
            }
        }

        public void UpdateFeatDescription()
        {
            using (var db = new DragonDBModel())
            {
                var featDescription =
                    (from f in db.FEATS.ToList()
                        where (f.f_name == _view.FeatGridView.SelectedRows[0].Cells[0].Value.ToString())
                        where (f.f_source == _view.FeatGridView.SelectedRows[0].Cells[1].Value.ToString())
                        select f.f_description).First();

                _view.FeatDescription.Text = featDescription;
            }
        }

        public void ManageFeats()
        {
            FeatManagerForm form = new FeatManagerForm(_characterId);

            form.SetController(new FeatManagerController(form));

            form.Show();
        }

        private void AddCharacter()
        {
            using (var db = new DragonDBModel())
            {
                var characterRace =
                    (from r in db.RACE.ToList()
                        where (r.r_name == _view.Race)
                        select r).First();

                var primaryClass =
                    (from cl in db.CLASS.ToList()
                        where (cl.cl_name == _view.Class)
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
                    c_hpcurrent = _view.HPcurrent,
                    c_hpmax = _view.HPmax,
                    c_hptemp = _view.HPtemp,
                    c_inspiration = _view.HasInspiration,
                    c_isNPC = _view.IsNPC,
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

        }

        #endregion
    }
}
