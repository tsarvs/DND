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

                if (!selectedAttack.a_damage1.Equals(""))
                    _view.AttackDescription += "\r\n\t" + selectedAttack.a_damage1;

                if (!selectedAttack.a_damage2.Equals(""))
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

            RefreshInventory();
        }

        private void RefreshInventory()
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

            RefreshInventory();
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

            RefreshInventory();
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

        #endregion
    }
}