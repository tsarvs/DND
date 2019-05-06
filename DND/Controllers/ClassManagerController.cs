using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class ClassManagerController
    {
        #region Properties

        private bool _madeChanges;

        private IClassManagerForm _view;

        private int _characterId;

        private List<CHARACTER_CLASS> _characterClassesToSave;

        #endregion

        #region Constructors

        public ClassManagerController(IClassManagerForm view)
        {
            _view = view;
            _madeChanges = false;
            _characterId = 0;
            _characterClassesToSave = new List<CHARACTER_CLASS>();
        }

        #endregion

        #region Methods

        public void PopulateControls(int characterId)
        {
            _characterId = characterId;

            using (var db = new DragonDBModel())
            {
                var characterClassQuery =
                    (from cc in db.CHARACTER_CLASS.ToList()
                        where (cc.CHARACTER.c_id == _characterId)
                        select cc).ToList();

                _characterClassesToSave = characterClassQuery;
                
                var classQuery =
                    (from cc in db.CHARACTER_CLASS.ToList()
                        where (cc.CHARACTER.c_id == _characterId)
                        select cc.CLASS).ToList();

                _view.ClassListBox.DisplayMember = "cl_name";
                _view.ClassListBox.ValueMember = "cl_id";
                _view.ClassListBox.SelectedItem = null;

                _view.CharacterClassListBox.DisplayMember = "cl_name";
                _view.CharacterClassListBox.ValueMember = "cl_id";
                _view.CharacterClassListBox.SelectedItem = null;
                
                UpdateListsContents(classQuery);
            }
        }

        public void AddClassToCharacter()
        {
            var addClass = _view.ClassListBox.SelectedItems.Cast<CLASS>();

            var currentCharacterClasses = _view.CharacterClassListBox.Items.Cast<CLASS>();

            var updatedCharacterClasses = currentCharacterClasses.Concat(addClass).ToList();

            CheckChanges(updatedCharacterClasses);

            UpdateListsContents(updatedCharacterClasses);
        }

        public void RemoveClassFromCharacter()
        {
            var removeClasses = _view.CharacterClassListBox.SelectedItems.Cast<CLASS>();

            var currentCharacterClasses = _view.CharacterClassListBox.Items.Cast<CLASS>();

            var updatedCharacterClasses = currentCharacterClasses.Except(removeClasses).ToList();

            CheckChanges(updatedCharacterClasses);

            UpdateListsContents(updatedCharacterClasses);

        }

        public void RefreshLevel()
        {
            var selectedClass = (CLASS)_view.CharacterClassListBox.SelectedItem;
            
            var selectedClassLevel =
               (from cc in _characterClassesToSave
                where (cc.cc_clid == selectedClass.cl_id)
                select cc.cc_level).FirstOrDefault();
            
            _view.ClassLevel.Text = selectedClassLevel.GetValueOrDefault(1).ToString();
        }

        public void UpdateLevel()
        {
            var selectedClass = (CLASS)_view.CharacterClassListBox.SelectedItem;

            var newLevel = Convert.ToInt32(_view.ClassLevel.Value);

            _characterClassesToSave.Find(x => x.cc_clid == selectedClass.cl_id).cc_level = newLevel;
        }

        public void Save()
        {
            if (!_madeChanges)
                return;

            using (var db = new DragonDBModel())
            {
                var inDbCharacter = db.CHARACTER.Single(x => x.c_id == _characterId);

                inDbCharacter.CHARACTER_CLASS.Clear();

                foreach (var characterClass in _characterClassesToSave)
                {
                    inDbCharacter.CHARACTER_CLASS.Add(characterClass);
                }

                db.SaveChanges();
            }
        }

        private void UpdateListsContents(List<CLASS> characterClasses)
        {
            List<CLASS> classQuery;

            //refresh class list
            using (var db = new DragonDBModel())
            {
                classQuery =
                    (from c in db.CLASS.ToList()
                        select c).ToList();
            }

            //update class list by removing the classes the character already has
            foreach (var characterClass in characterClasses)
            {
                classQuery.Remove(classQuery.Find(x => x.cl_id == characterClass.cl_id));
            }
            
            _view.CharacterClassListBox.DataSource = characterClasses;
            _view.ClassListBox.DataSource = classQuery;

            UpdateCharacterClassesToSave(characterClasses);

            DisableButtonsOnEmptyList();
        }

        private void UpdateCharacterClassesToSave(List<CLASS> characterClasses)
        {
            _characterClassesToSave.Clear();
            
            //todo: see if possible to update character classes to save without db connection
            using (var db = new DragonDBModel())
            {
                var characterClassQuery =
                    (from cc in db.CHARACTER_CLASS.ToList()
                        where (cc.cc_cid == _characterId)
                        select cc).ToList();

                foreach (var characterClass in characterClasses)
                {
                    var classQuery = characterClassQuery.Find(x => x.cc_clid == characterClass.cl_id);

                    var classLevel = 1;

                    if (classQuery != null)
                    {
                        classLevel = classQuery.cc_level.GetValueOrDefault(1);
                    }
                    
                    _characterClassesToSave.Add(new CHARACTER_CLASS
                    {
                        cc_cid = _characterId,
                        cc_clid = characterClass.cl_id,
                        cc_level = classLevel

                    });
                }

            }
        }

        private void DisableButtonsOnEmptyList()
        {
            if (_view.ClassListBox.Items.Count <= 0)
            {
                _view.AddClassToCharacterButton.Enabled = false;
            }
            else
            {
                _view.AddClassToCharacterButton.Enabled = true;
            }

            if (_view.CharacterClassListBox.Items.Count <= 0)
            {
                _view.RemoveClassFromCharacterButton.Enabled = false;
            }
            else
            {
                _view.RemoveClassFromCharacterButton.Enabled = true;
            }
        }

        private void CheckChanges(List<CLASS> updatedCharacterClasses)
        {
            if (updatedCharacterClasses.Count != _view.CharacterClassListBox.Items.Count || _madeChanges == true)
            {
                _madeChanges = true;
            }
            else
            {
                _madeChanges = false;
            }
        }

        #endregion


    }
}
