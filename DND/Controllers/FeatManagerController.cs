using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Forms;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class FeatManagerController
    {
        #region Properties
        
        private bool _madeChanges;

        private IFeatManagerForm _view;

        private int _characterId;

        private List<FEATS> _loadedDbFeats;

        private List<FEATS> _loadedCharacterFeats;

        #endregion

        #region Constructor

        public FeatManagerController(IFeatManagerForm view)
        {
            _view = view;
            _madeChanges = false;
            _characterId = 0;

            using (var db = new DragonDBModel())
            {
                _loadedDbFeats = db.FEATS.ToList();

                _loadedCharacterFeats =
                    (from c in db.CHARACTER.ToList()
                     where (c.c_id == _characterId)
                     select c.FEATS.FirstOrDefault()).ToList();
            }
        }

        #endregion

        #region Methods

        public void PopulateControls(int characterId)
        {
            _characterId = characterId;
            
            _view.FeatsListBox.DisplayMember = "f_name";
            _view.FeatsListBox.ValueMember = "f_id";
            _view.FeatsListBox.SelectedItem = null;

            _view.CharacterFeatsListBox.DisplayMember = "f_name";
            _view.CharacterFeatsListBox.ValueMember = "f_id";
            _view.CharacterFeatsListBox.SelectedItem = null;

            //lbFeats.DataSource is set/updated thru here
            UpdateListsContents(_loadedCharacterFeats);
        }

        public void ReloadFeatList()
        {
            var currentCharacterFeats = 
               (from f in _view.CharacterFeatsListBox.Items.Cast<FEATS>()
                where (f.CHARACTER.Any(x => x.c_id == _characterId))
                select f).ToList();

            UpdateListsContents(currentCharacterFeats);
        }

        public void UpdateFeatDisplay(bool selectedFeat)
        {
            FEATS feat;

            if (selectedFeat)
                feat = (FEATS) _view.FeatsListBox.SelectedItem;
            else
                feat = (FEATS) _view.CharacterFeatsListBox.SelectedItem;

            if (feat == null)
                return;

            _view.FeatSource.Text = feat.f_source;
            _view.FeatDescription.Text = feat.f_description;
        }
        
        public void AddFeatToCharacter()
        {
            var addFeat = _view.FeatsListBox.SelectedItems.Cast<FEATS>();

            var currentCharacterFeats = _view.CharacterFeatsListBox.Items.Cast<FEATS>();

            var updatedCharacterFeats = currentCharacterFeats.Concat(addFeat).ToList();

            CheckChanges(updatedCharacterFeats);

            UpdateListsContents(updatedCharacterFeats);
        }

        internal void UnselectFeats()
        {
            _view.FeatsListBox.SelectedItem = null;
        }

        public void UnselectCharacterFeats()
        {
            _view.CharacterFeatsListBox.SelectedItem = null;
        }

        public void Save()
        {
            if (!_madeChanges)
                return;
            
            
        }

        public void NewFeat()
        {
            NewFeatForm form = new NewFeatForm();

            form.SetController(new NewFeatController(form, _view));

            form.Show();
        }

        public void RemoveFeatFromCharacter()
        {
            var removeFeat = _view.CharacterFeatsListBox.SelectedItems.Cast<FEATS>();

            var currentCharacterFeats = _view.CharacterFeatsListBox.Items.Cast<FEATS>();
            
            var updatedCharacterFeats = currentCharacterFeats.Except(removeFeat).ToList();

            CheckChanges(updatedCharacterFeats);

            UpdateListsContents(updatedCharacterFeats);

        }

        private void UpdateListsContents(List<FEATS> characterFeats)
        {
            //refresh feats list
            var featsQuery = _loadedDbFeats;

            //update feats list by removing the feats the character already has
            foreach (var feat in characterFeats) featsQuery.Remove(featsQuery.Find(x => x.f_id == feat.f_id));

            _view.CharacterFeatsListBox.DataSource = characterFeats;
            _view.FeatsListBox.DataSource = featsQuery;

            DisableButtonsOnEmptyList();
        }

        private void DisableButtonsOnEmptyList()
        {
            if (_view.FeatsListBox.Items.Count <= 0)
            {
                _view.AddFeatToCharacterButton.Enabled = false;
            }
            else
            {
                _view.AddFeatToCharacterButton.Enabled = true;
            }

            if (_view.CharacterFeatsListBox.Items.Count <= 0)
            {
                _view.RemoveFeatFromCharacterButton.Enabled = false;
            }
            else
            {
                _view.RemoveFeatFromCharacterButton.Enabled = true;
            }
        }

        private void CheckChanges(List<FEATS> updatedCharacterFeats)
        {
            if (updatedCharacterFeats.Count != _view.CharacterFeatsListBox.Items.Count || _madeChanges == true)
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
