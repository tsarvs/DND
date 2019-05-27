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

        private CHARACTER _loadedCharacter;

        #endregion

        #region Constructors

        public CharacterSheetController(ICharacterSheetForm view)
        {
            _view = view;
            _loadedCharacter = new CHARACTER();
        }

        #endregion

        #region Methods

        #region Attack

        public void AddAttack()
        {
            var form = new AddEditAttackForm();

            form.SetController(new AddAttackController(form, _view));

            form.Show();
        }

        public void AddAttackToGrid(CHARACTER_ATTACK attack)
        {
            _loadedCharacter.CHARACTER_ATTACK.Add(attack);

            RefreshAttackDataSource();

            _view.AttackGridView.Columns[0].Visible = false;
        }

        public void UpdateAttackControls()
        {
            var selectedRow = _view.AttackGridView.SelectedRows;

            if (selectedRow.Count == 0)
            {
                _view.AttackDescription = "";
                return;
            }

            var selectedAttack =
                _loadedCharacter.CHARACTER_ATTACK.ToList().Find(x => x.a_id == (int) selectedRow[0].Cells[0].Value);

                if (!selectedAttack.a_damage1.Equals("") || !selectedAttack.a_damage2.Equals(""))
                {
                    _view.AttackDescription = "Damage:";

                    if (selectedAttack.a_damage1 != null)
                        if (!selectedAttack.a_damage1.Equals("") || selectedAttack.a_damage1 != null)
                            _view.AttackDescription += "\r\n\t" + selectedAttack.a_damage1;

                    if (selectedAttack.a_damage2 != null)
                        if (!selectedAttack.a_damage2.Equals("") || selectedAttack.a_damage2 != null)
                            _view.AttackDescription += "\r\n\t" + selectedAttack.a_damage2;
                
            }

            _view.AttackDescription += "\r\n\r\n" + selectedAttack.a_description;
        }

        public void EditAttack()
        {
            var selectedRows = _view.AttackGridView.SelectedRows;


            if (selectedRows.Count == 0)
                return;

            var selectedId = (int) selectedRows[0].Cells[0].Value;

            var selectedAttack = _loadedCharacter.CHARACTER_ATTACK.ToList().Find(x => x.a_id == selectedId);

            var form = new AddEditAttackForm(selectedAttack);

            form.SetController(new AddAttackController(form, _view));

            form.Show();
        }

        public void UpdateAttackGrid(CHARACTER_ATTACK attack)
        {
            var attackToUpdate = _loadedCharacter.CHARACTER_ATTACK.ToList().Find(x => x.a_id == attack.a_id);

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
            if (_view.AttackGridView.SelectedRows.Count == 0)
                return;


            var selectedAttackId = (int) _view.AttackGridView.SelectedRows[0].Cells[0].Value;

            _loadedCharacter.CHARACTER_ATTACK
                .Remove(_loadedCharacter.CHARACTER_ATTACK.ToList().Find(x => x.a_id == selectedAttackId));

            RefreshAttackDataSource();
        }

        private void RefreshAttackDataSource()
        {
            _view.AttackGridView.DataSource =
                (from ca in _loadedCharacter.CHARACTER_ATTACK.ToList()
                    select new
                    {
                        ID = ca.a_id,
                        Name = ca.a_name,
                        Attack = ca.a_attackability + " + " + ca.a_attackbonus,
                        Range = ca.a_range
                    }).ToList();

            _view.AttackGridView.Columns[0].Visible = false;
        }

        #endregion

        #region Inventory

        public void AddItemToGrid(ITEM item)
        {
            _loadedCharacter.ITEM.Add(item);

            RefreshInventoryDataSource();
        }

        private void RefreshInventoryDataSource()
        {
            _view.InventoryGridView.DataSource =
                (from ci in _loadedCharacter.ITEM.ToList()
                    select new
                    {
                        ID = ci.i_id,
                        Name = ci.i_name,
                        Quantity = ci.i_quantity
                    }).ToList();

            _view.InventoryGridView.Columns[0].Visible = false;

            UpdateWeight();
        }

        public void LoadAddEditItemForm(FormMode itemFormMode)
        {
            AddEditItemForm form;

            if (itemFormMode == FormMode.NewForm)
            {
                form = new AddEditItemForm();
            }
            else
            {
                if (_view.InventoryGridView.SelectedRows.Count <= 0)
                    return;

                var selectedItem = _view.InventoryGridView.SelectedRows[0];

                var loadedItem = _loadedCharacter.ITEM.ToList().Find(x => x.i_id == (int) selectedItem.Cells[0].Value);

                form = new AddEditItemForm(loadedItem);
            }


            form.SetController(new AddEditItemController(form, _view));

            form.Show();
        }

        public void DeleteItem()
        {
            var selectedItem = _loadedCharacter.ITEM.ToList().Find(x =>
                x.i_id == (int) _view.InventoryGridView.SelectedRows[0].Cells[0].Value);

            _loadedCharacter.ITEM.Remove(selectedItem);

            RefreshInventoryDataSource();
        }

        private void UpdateWeight()
        {
            decimal totalWeight = 0;

            foreach (var item in _loadedCharacter.ITEM.ToList())
                totalWeight += item.i_quantity.GetValueOrDefault(0) * item.i_weight.GetValueOrDefault(0);

            _view.InventoryWeight = (double) totalWeight;
        }

        public void UpdateItemDescription()
        {
            if (_view.InventoryGridView.SelectedRows.Count == 0)
            {
                _view.ItemDescription = "";
                return;
            }

            var selectedItem =
                _loadedCharacter.ITEM.ToList()
                    .Find(x => x.i_id == (int) _view.InventoryGridView.SelectedRows[0].Cells[0].Value);

            _view.ItemDescription = selectedItem.i_description;
        }

        public void UpdateInventoryGrid(ITEM item)
        {
            var itemToUpdate = _loadedCharacter.ITEM.ToList().Find(x => x.i_id == item.i_id);

            itemToUpdate.i_name = item.i_name;
            itemToUpdate.i_quantity = item.i_quantity;
            itemToUpdate.i_weight = item.i_weight;
            itemToUpdate.i_description = item.i_description;

            RefreshInventoryDataSource();
        }

        #endregion

        #region Feats

        public void UpdateFeatGrid()
        {
            var featsGridContent =
                from f in _loadedCharacter.FEATS.ToList()
                select new
                {
                    ID = f.f_id,
                    Feat = f.f_name,
                    Source = f.f_source
                };

            _view.FeatGridView.DataSource = featsGridContent.ToList();

            //hide ID column from display
            _view.FeatGridView.Columns[0].Visible = false;

        }

        public void UpdateFeatControls()
        {
            int selectedFeatId;

            if (_view.FeatGridView.SelectedRows.Count == 0)
            {
                selectedFeatId = -1;
            }
            else
            {
                selectedFeatId = (int)(_view.FeatGridView.SelectedRows[0]?.Cells[0]?.Value ?? -1);
            }
            
            if (selectedFeatId == -1)
            {
                _view.FeatDescription = "";
            }
            else
            {
                var selectedFeatDescription =
                    (from f in _loadedCharacter.FEATS.ToList()
                        where (f.f_id == selectedFeatId)
                        select f.f_description).First();

                _view.FeatDescription = selectedFeatDescription ?? "";
            }
        }

        public void ManageFeats()
        {
            var form = new FeatManagerForm(_characterId, _view);

            form.SetController(new FeatManagerController(form, _view, _loadedCharacter.FEATS.ToList()));

            form.Show();
        }

        #endregion

        public void InitializeData(int characterId)
        {
            _characterId = characterId;

            using (var db = new DragonDBModel())
            {
                var loadedCharacter =
                    (from c in db.CHARACTER.ToList()
                        where (c.c_id == _characterId)
                        select c).FirstOrDefault();

                UpdateLoadedCharacterData(loadedCharacter);

                _view.RaceComboBox.DataSource = db.RACE.ToList();
            }

            _view.RaceComboBox.ValueMember = "r_id";
            _view.RaceComboBox.DisplayMember = "r_name";
            _view.RaceComboBox.SelectedItem = null;

            _view.ClassComboBox.ValueMember = "cl_id";
            _view.ClassComboBox.DisplayMember = "cl_name";
            _view.ClassComboBox.SelectedItem = null;

            RefreshControls();
            
        }

        private void UpdateLoadedCharacterData(CHARACTER loadedCharacter)
        {
            if (loadedCharacter == null)
            return;

            _loadedCharacter.c_id = loadedCharacter.c_id;
            _loadedCharacter.c_name = loadedCharacter.c_name;
            _loadedCharacter.c_rid = loadedCharacter.c_rid;
            _loadedCharacter.c_alignment = loadedCharacter.c_alignment;
            _loadedCharacter.c_hpcurrent = loadedCharacter.c_hpcurrent;
            _loadedCharacter.c_hpmax = loadedCharacter.c_hpmax;
            _loadedCharacter.c_inspiration = loadedCharacter.c_inspiration;
            _loadedCharacter.c_aid = loadedCharacter.c_aid;
            _loadedCharacter.c_spellslots_remaining = loadedCharacter.c_spellslots_remaining;
            _loadedCharacter.c_spellslots_total = loadedCharacter.c_spellslots_total;
            _loadedCharacter.c_isNPC = loadedCharacter.c_isNPC;
            _loadedCharacter.c_armorclass = loadedCharacter.c_armorclass;
            _loadedCharacter.c_initiative = loadedCharacter.c_initiative;
            _loadedCharacter.c_speed = loadedCharacter.c_speed;
            _loadedCharacter.c_experience = loadedCharacter.c_experience;
            _loadedCharacter.c_gold = loadedCharacter.c_gold;
            _loadedCharacter.c_proficiencybonus = loadedCharacter.c_proficiencybonus;

            _loadedCharacter.ABILITY = loadedCharacter.ABILITY;
            _loadedCharacter.CHARACTER_ATTACK = loadedCharacter.CHARACTER_ATTACK;
            _loadedCharacter.CHARACTER_BACKGROUND = loadedCharacter.CHARACTER_BACKGROUND;
            _loadedCharacter.CHARACTER_JOURNAL = loadedCharacter.CHARACTER_JOURNAL;
            _loadedCharacter.CHARACTER_CLASS = loadedCharacter.CHARACTER_CLASS;
            _loadedCharacter.FEATS = loadedCharacter.FEATS;
            _loadedCharacter.ITEM = loadedCharacter.ITEM;
            _loadedCharacter.PROFICIENCY = loadedCharacter.PROFICIENCY;
            _loadedCharacter.RACE = loadedCharacter.RACE;
            _loadedCharacter.SKILL = loadedCharacter.SKILL;
            _loadedCharacter.SPELLS = loadedCharacter.SPELLS;
            _loadedCharacter.SPELLS_SLOTS = loadedCharacter.SPELLS_SLOTS;
            _loadedCharacter.SPELLS_SLOTS1 = loadedCharacter.SPELLS_SLOTS1;
        }

        private void RefreshControls()
        {
            _view.CharacterName = _loadedCharacter.c_name;
            _view.Alignment = _loadedCharacter.c_alignment;
            _view.RaceComboBox.Text = _loadedCharacter.RACE?.r_name ?? "";
            _view.Experience = _loadedCharacter.c_experience.GetValueOrDefault(0);
            _view.IsNpc = _loadedCharacter.c_isNPC.GetValueOrDefault(false);

            _view.ArmorClass = _loadedCharacter.c_armorclass.GetValueOrDefault(0);
            _view.Speed = _loadedCharacter.c_speed.GetValueOrDefault(0);
            _view.Initiative = _loadedCharacter.c_initiative.GetValueOrDefault(0);
            _view.HpCurrent = _loadedCharacter.c_hpcurrent.GetValueOrDefault(0);
            _view.HpMax = _loadedCharacter.c_hpmax.GetValueOrDefault(0);
            _view.HpTemp = _loadedCharacter.c_hptemp.GetValueOrDefault(0);

            _view.CHA = _loadedCharacter.ABILITY?.a_CHA.GetValueOrDefault(0) ?? 0;
            _view.CON = _loadedCharacter.ABILITY?.a_CON.GetValueOrDefault(0) ?? 0;
            _view.DEX = _loadedCharacter.ABILITY?.a_DEX.GetValueOrDefault(0) ?? 0;
            _view.INT = _loadedCharacter.ABILITY?.a_INT.GetValueOrDefault(0) ?? 0;
            _view.STR = _loadedCharacter.ABILITY?.a_STR.GetValueOrDefault(0) ?? 0;
            _view.WIS = _loadedCharacter.ABILITY?.a_WIS.GetValueOrDefault(0) ?? 0;

            //todo implement racial bonus & saving throw

            _view.Acrobatics = _loadedCharacter.SKILL?.s_acrobatics.GetValueOrDefault(0) ?? 0;
            _view.AnimalHandling = _loadedCharacter.SKILL?.s_animalhandling.GetValueOrDefault(0) ?? 0;
            _view.Arcana = _loadedCharacter.SKILL?.s_arcana.GetValueOrDefault(0) ?? 0;
            _view.Athletics = _loadedCharacter.SKILL?.s_athletics.GetValueOrDefault(0) ?? 0;
            _view.Deception = _loadedCharacter.SKILL?.s_deception.GetValueOrDefault(0) ?? 0;
            _view.History = _loadedCharacter.SKILL?.s_history.GetValueOrDefault(0) ?? 0;
            _view.Insight = _loadedCharacter.SKILL?.s_insight.GetValueOrDefault(0) ?? 0;
            _view.Intimidation = _loadedCharacter.SKILL?.s_intimidation.GetValueOrDefault(0) ?? 0;
            _view.Investigation = _loadedCharacter.SKILL?.s_investigation.GetValueOrDefault(0) ?? 0;
            _view.Medicine = _loadedCharacter.SKILL?.s_medicine.GetValueOrDefault(0) ?? 0;
            _view.Nature = _loadedCharacter.SKILL?.s_nature.GetValueOrDefault(0) ?? 0;
            _view.Perception = _loadedCharacter.SKILL?.s_perception.GetValueOrDefault(0) ?? 0;
            _view.Performance = _loadedCharacter.SKILL?.s_performance.GetValueOrDefault(0) ?? 0;
            _view.Persuasion = _loadedCharacter.SKILL?.s_persuasion.GetValueOrDefault(0) ?? 0;
            _view.Religion = _loadedCharacter.SKILL?.s_religion.GetValueOrDefault(0) ?? 0;
            _view.SleightOfHand = _loadedCharacter.SKILL?.s_sleightofhand.GetValueOrDefault(0) ?? 0;
            _view.Stealth = _loadedCharacter.SKILL?.s_stealth.GetValueOrDefault(0) ?? 0;
            _view.Survival = _loadedCharacter.SKILL?.s_survival.GetValueOrDefault(0) ?? 0;
            
            _view.SpellSlots_Level1_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl1.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level2_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl2.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level3_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl3.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level4_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl4.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level5_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl5.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level6_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl6.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level7_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl7.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level8_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl8.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level9_Current = _loadedCharacter.SPELLS_SLOTS?.ss_lvl9.GetValueOrDefault(0) ?? 0;

            _view.SpellSlots_Level1_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl1.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level2_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl2.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level3_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl3.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level4_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl4.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level5_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl5.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level6_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl6.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level7_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl7.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level8_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl8.GetValueOrDefault(0) ?? 0;
            _view.SpellSlots_Level9_Max = _loadedCharacter.SPELLS_SLOTS1?.ss_lvl9.GetValueOrDefault(0) ?? 0;

            _view.Gold = _loadedCharacter.c_gold.GetValueOrDefault(0);
            _view.ProficiencyBonus = _loadedCharacter.c_proficiencybonus.GetValueOrDefault(0);

            //refresh data sources
            //class
            UpdateCharacterClasses();

            //attack
            RefreshAttackDataSource();

            //spellbook
            RefreshSpellsDataSource();

            //inventory
            RefreshInventoryDataSource();

            //feats
            UpdateFeatGrid();

            //prof.
            RefreshProficiencyDataSource();

            //background
            RefreshBackgroundDataSource();
            
        }

        public void SaveCharacter()
        {
            var mode = _view.CharacterSheetMode;

            if (mode == FormMode.NewForm)
                AddCharacter();
            else if (mode == FormMode.EditForm) UpdateCharacter();
        }

        public void AddSpellsToGrid(List<SPELLS> characterSpells)
        {
            _loadedCharacter.SPELLS.Clear();

            foreach (var spell in characterSpells)
            {
                _loadedCharacter.SPELLS.Add(spell);
            }

            RefreshSpellsDataSource();
        }

        private void RefreshSpellsDataSource()
        {
            _view.SpellsGridView.DataSource =
                (from s in _loadedCharacter.SPELLS.ToList()
                    select new
                    {
                        ID = s.s_id,
                        Name = s.s_name,
                        Level = s.s_level
                    }).ToList();

            _view.SpellsGridView.Columns[0].Visible = false;

            UpdateSpellDescription();
        }

        public void UpdateSpellDescription()
        {
            if(_view.SpellsGridView.SelectedRows.Count == 0)
            {
                _view.SpellDescription = null;
                return;
            }

            var selectedSpellId = (int)(_view.SpellsGridView.SelectedRows[0]?.Cells[0]?.Value ?? -1);

            var selectedSpell = _loadedCharacter.SPELLS.FirstOrDefault(x => x.s_id == selectedSpellId);
            
            _view.SpellDescription = GenerateSpellDescription(selectedSpell);
        }

        private string GenerateSpellDescription(SPELLS selectedSpell)
        {
            var spellDescription = "";

            if (selectedSpell != null)
            {
                if (!selectedSpell.s_name.Equals(""))
                {
                    spellDescription += selectedSpell.s_name + "\r\n";
                }

                if (!selectedSpell.s_school.Equals(""))
                {
                    spellDescription += selectedSpell.s_school + " ";
                }

                if (selectedSpell.s_level != null)
                {
                    spellDescription += "lvl " + selectedSpell.s_level.ToString() + "\r\n";
                }
                else if (!selectedSpell.s_school.Equals(""))
                {
                    spellDescription += "\r\n";
                }

                if (!selectedSpell.s_range.Equals(""))
                {
                    spellDescription += "Range: " + selectedSpell.s_range + "\r\n";
                }

                if (!selectedSpell.s_target.Equals(""))
                {
                    spellDescription += "Target: " + selectedSpell.s_target + "\r\n";
                }

                if (selectedSpell.s_castingtime != null)
                {
                    spellDescription += "Casting Time: " + selectedSpell.s_castingtime.ToString() + "\r\n";
                }

                if (selectedSpell.s_durationminutes != null)
                {
                    spellDescription += "Duration: " + selectedSpell.s_durationminutes.ToString() + "\r\n";
                }

                if (selectedSpell.s_isconcentration != null)
                {
                    spellDescription += "Concentration: " + (selectedSpell.s_isconcentration.GetValueOrDefault(false) ? "Y" : "N") + "\r\n";
                }

                if ((selectedSpell.s_component_m != null) || (selectedSpell.s_component_s != null) || (selectedSpell.s_component_v != null))
                {
                    spellDescription += "Components: ";

                    if (selectedSpell.s_component_m != null && !selectedSpell.s_component_m.Equals(""))
                    {
                        spellDescription += "M (" + selectedSpell.s_component_m + ") ";
                    }

                    if (selectedSpell.s_component_s != null && selectedSpell.s_component_s == true)
                    {
                        spellDescription += "S ";
                    }

                    if (selectedSpell.s_component_v != null && selectedSpell.s_component_v == true)
                    {
                        spellDescription += "V ";
                    }

                    spellDescription += "\r\n";
                }

                if (selectedSpell.s_description != null && !selectedSpell.s_description.Equals(""))
                {
                    spellDescription += "\r\n" + selectedSpell.s_description;
                }

            }

            return spellDescription;
        }

        public void AddClass()
        {
            var form = new ClassManagerForm(_characterId, _loadedCharacter.CHARACTER_CLASS.ToList());

            form.SetController(new ClassManagerController(form, _view));

            form.Show();
        }

        public void LoadCharacterClasses(List<CHARACTER_CLASS> characterClassList)
        {
            _loadedCharacter.CHARACTER_CLASS.ToList().Clear();
            _loadedCharacter.CHARACTER_CLASS = characterClassList;

            _view.ClassComboBox.DataSource =
                (from cc in _loadedCharacter.CHARACTER_CLASS.ToList()
                    select cc.CLASS).ToList();
        }

        public void UpdateLevel()
        {
            var selectedClass = (CLASS) _view.ClassComboBox.SelectedItem;

            if (selectedClass == null)
                return;

            var selectedClassId = selectedClass.cl_id;

            _view.Level =
                (from cc in _loadedCharacter.CHARACTER_CLASS.ToList()
                    where cc.cc_clid == selectedClassId
                    select cc.cc_level).FirstOrDefault().GetValueOrDefault(1);
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

            _loadedCharacter.CHARACTER_CLASS.ToList().Find(x => x.cc_clid == selectedClass.cl_id).cc_level = newLevel;
        }

        private void AddCharacter()
        {
            throw new NotImplementedException();
        }

        private void UpdateCharacter()
        {
            throw new NotImplementedException();
        }

        public void LoadCharacter()
        {
            if (_characterId == 0)
                return;

            using (var db = new DragonDBModel())
            {
                _loadedCharacter =
                    (from c in db.CHARACTER.ToList()
                        where c.c_id == _characterId
                        select c).First();
            }
        }

        public void AddFeatsToGrid(List<FEATS> characterFeats)
        {
            _loadedCharacter.FEATS.Clear();

            foreach (var feat in characterFeats)
            {
                _loadedCharacter.FEATS.Add(feat);    
            }
        }

        public void AddProficiencyToGrid(PROFICIENCY proficiency)
        {
            _loadedCharacter.PROFICIENCY.Add(proficiency);

            RefreshProficiencyDataSource();
        }

        private void RefreshProficiencyDataSource()
        {
            _view.ProficienciesGridView.DataSource =
                (from cp in _loadedCharacter.PROFICIENCY.ToList()
                    select new
                    {
                        ID = cp.p_id,
                        Proficiency = cp.p_name,
                        Type = cp.p_type
                    }).ToList();

            _view.ProficienciesGridView.Columns[0].Visible = false;
        }

        private void RefreshBackgroundDataSource()
        {
            _view.LoreComboBox.ValueMember = "cb_id";
            _view.LoreComboBox.DisplayMember = "cb_title";

            RefreshBackgroundIds();

            _view.LoreComboBox.DataSource =
                (from cb in _loadedCharacter.CHARACTER_BACKGROUND.ToList()
                    select cb).ToList();

            UpdateLoreDescription();
        }

        private void RefreshBackgroundIds()
        {
            for (int i = 0; i < _loadedCharacter.CHARACTER_BACKGROUND.Count; i++)
            {
                _loadedCharacter.CHARACTER_BACKGROUND.ElementAt(i).cb_id = i;
            }
        }

        public void NewProficiency()
        {
            AddEditProficiencyForm form = new AddEditProficiencyForm();

            form.SetController(new AddEditProficiencyController(form, _view));

            form.Show();
        }

        public void EditProficiency()
        {
            var selectedProficiency = _loadedCharacter.PROFICIENCY.FirstOrDefault(x =>
                x.p_id == (int) (_view.ProficienciesGridView.SelectedRows[0]?.Cells[0]?.Value ?? -1));

            if (selectedProficiency == null) return;

            AddEditProficiencyForm form = new AddEditProficiencyForm();

            form.SetController(new AddEditProficiencyController(form, _view, selectedProficiency));

            form.Show();
        }

        public void DeleteProficiency()
        {
            var selectedProficiency = _loadedCharacter.PROFICIENCY.FirstOrDefault(x =>
                x.p_id == (int)(_view.ProficienciesGridView.SelectedRows[0]?.Cells[0]?.Value ?? -1));

            if (selectedProficiency == null) return;

            _loadedCharacter.PROFICIENCY.Remove(selectedProficiency);

            RefreshProficiencyDataSource();
        }

        public void NewBackground()
        {
            AddEditBackgroundForm form = new AddEditBackgroundForm();

            form.SetController(new AddEditBackgroundController(form, _view));

            form.Show();
        }

        public void AddLoreToCharacter(CHARACTER_BACKGROUND loadedBackground)
        {
            _loadedCharacter.CHARACTER_BACKGROUND.Add(loadedBackground);

            RefreshBackgroundDataSource();
        }

        public void UpdateLoreDescription()
        {
            var selectedLore = (CHARACTER_BACKGROUND)_view.LoreComboBox.SelectedItem;

            if (selectedLore == null)
            {
                _view.LoreDescription = null;
                return;
            }

            var selectedDescription = _loadedCharacter.CHARACTER_BACKGROUND
                .First(x => x.cb_id == selectedLore.cb_id ).cb_description;


            _view.LoreDescription = selectedDescription;
        }

        public void EditLore()
        {
            var selectedLore = (CHARACTER_BACKGROUND)_view.LoreComboBox.SelectedItem;

            if (selectedLore == null)
            {
                return;
            }

            AddEditBackgroundForm form = new AddEditBackgroundForm();

            form.SetController(new AddEditBackgroundController(form, _view, selectedLore));

            form.Show();
        }

        public void DeleteLore()
        {
            var selectedLore = (CHARACTER_BACKGROUND)_view.LoreComboBox.SelectedItem;

            if (selectedLore == null)
            {
                return;
            };

            _loadedCharacter.CHARACTER_BACKGROUND.Remove(
                _loadedCharacter.CHARACTER_BACKGROUND.First(x => x.cb_id == selectedLore.cb_id));

            RefreshBackgroundDataSource();

            if (_loadedCharacter.CHARACTER_BACKGROUND.Count == 0)
            {
                _view.LoreComboBox.Text = "";
            }
        }

        public void ManageSpells()
        {
            SpellbookManagerForm form = new SpellbookManagerForm();

            form.SetController(new SpellbookManagerController(form, _view, _loadedCharacter.SPELLS.ToList()));

            form.Show();
        }

        #endregion
    }
}