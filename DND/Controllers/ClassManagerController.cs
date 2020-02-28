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

        private ICharacterSheetForm _parentView;

        private IClassManagerForm _view;

        private int _characterId;

        private List<CHARACTER_CLASS> _characterClassesToSave;

        #endregion

        #region Constructors

        public ClassManagerController(IClassManagerForm view, ICharacterSheetForm parentView)
        {
            _view = view;
            _parentView = parentView;
            _madeChanges = false;
            _characterId = 0;
            _characterClassesToSave = new List<CHARACTER_CLASS>();

            using (var db = new DragonDBModel())
            {
                _view.ClassListBox.DataSource =
                    (from c in db.CLASS.ToList()
                        select c).ToList();
            }
        }

        #endregion

        #region Methods

        public void PopulateControls(int characterId, List<CHARACTER_CLASS> loadedCharacterClasses)
        {
            _characterId = characterId;

            _characterClassesToSave = loadedCharacterClasses;
            
            _view.ClassListBox.DisplayMember = "cl_name";
            _view.ClassListBox.ValueMember = "cl_id";
            _view.ClassListBox.SelectedItem = null;

            _view.CharacterClassListBox.DisplayMember = "cl_name";
            _view.CharacterClassListBox.ValueMember = "cl_id";
            _view.CharacterClassListBox.SelectedItem = null;

            List<CLASS> characterClasses;
            
                characterClasses = new List<CLASS>();
        
                foreach (var characterClass in _characterClassesToSave)
                {
                    var classToAdd =
                        (from c in _view.ClassListBox.Items.Cast<CLASS>().ToList()
                            where (c.cl_id == characterClass.cc_clid)
                            select c).First();

                    characterClasses.Add(classToAdd);
                }
            
            
            UpdateListsContents(characterClasses);
        }

        public void AddClassToCharacter()
        {
            var addClass = _view.ClassListBox.SelectedItems.Cast<CLASS>();

            var currentCharacterClasses = _view.CharacterClassListBox.Items.Cast<CLASS>();

            var updatedCharacterClasses = currentCharacterClasses.Concat(addClass).ToList();
            
            CheckChanges(updatedCharacterClasses);

            UpdateCharacterClassesToSave(updatedCharacterClasses);

            UpdateListsContents(updatedCharacterClasses);
        }

        public void RemoveClassFromCharacter()
        {
            var removeClasses = _view.CharacterClassListBox.SelectedItems.Cast<CLASS>();

            var currentCharacterClasses = _view.CharacterClassListBox.Items.Cast<CLASS>();

            var updatedCharacterClasses = currentCharacterClasses.Except(removeClasses).ToList();

            CheckChanges(updatedCharacterClasses);

            UpdateCharacterClassesToSave(updatedCharacterClasses);

            UpdateListsContents(updatedCharacterClasses);

        }

        public void UpdateParentView()
        {
            _parentView.LoadCharacterClasses(_characterClassesToSave);
        }

        public void RefreshLevel()
        {
            var selectedClass = (CLASS)_view.CharacterClassListBox.SelectedItem;
            
            var selectedClassLevel =
               (from cc in _characterClassesToSave
                where (cc.cc_clid == selectedClass.cl_id)
                select cc.cc_level).FirstOrDefault();
            
            _view.ClassLevel.Value = selectedClassLevel.GetValueOrDefault(1);
        }

        public void UpdateLevel()
        {
            var selectedClass = (CLASS)_view.CharacterClassListBox.SelectedItem;

            var characterClassQuery = _characterClassesToSave.Find(x => x.cc_clid == selectedClass.cl_id);

            if (characterClassQuery == null)
                return;

            var newLevel = (int) _view.ClassLevel.Value;
 
            characterClassQuery.cc_level = newLevel;
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
            var characterClassQuery =
                (from cc in _characterClassesToSave.ToList()
                    select cc).ToList();

            _characterClassesToSave.Clear();

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
                    cc_level = classLevel,
                    CLASS = characterClass
                });
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
