using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        private IFeatManagerForm _view;

        private ICharacterSheetForm _parentView;

        private List<FEATS> _dbFeats;

        private BindingList<FEATS> _loadedFeats;

        private BindingList<FEATS> _loadedCharacterFeats;

        #endregion

        #region Constructor

        public FeatManagerController(IFeatManagerForm view, ICharacterSheetForm parentView, List<FEATS> loadedCharacterFeats)
        {
            _view = view;
            _parentView = parentView;

            using (var db = new DragonDBModel())
            {
                _dbFeats = db.FEATS.ToList();
            }

            _loadedFeats = new BindingList<FEATS>();
            _loadedCharacterFeats = new BindingList<FEATS>(loadedCharacterFeats);

            _view.FeatsListBox.DataSource = _loadedFeats;
            _view.FeatsListBox.DisplayMember = "f_name";
            _view.FeatsListBox.ValueMember = "f_id";

            _view.CharacterFeatsListBox.DataSource = _loadedCharacterFeats;
            _view.CharacterFeatsListBox.DisplayMember = "f_name";
            _view.CharacterFeatsListBox.ValueMember = "f_id";
            
            UpdateListDisplays();

            UnselectCharacterFeats();
            UnselectFeats();
        }

        #endregion

        #region Methods

        private void UpdateListDisplays()
        {
            _loadedFeats.Clear();

            //todo: try and get rid of this loop
            foreach (var dbFeat in _dbFeats)
            {
                _loadedFeats.Add(new FEATS
                {
                    f_id = dbFeat.f_id,
                    f_name = dbFeat.f_name,
                    f_description = dbFeat.f_description,
                    f_source = dbFeat.f_source
                });
            }

            foreach (var feat in _loadedCharacterFeats)
            {
                _loadedFeats.Remove(_loadedFeats.First(x => x.f_id == feat.f_id));
            }
        }
        
        public void AddFeatToCharacter()
        {
            var selectedFeats = _view.FeatsListBox.SelectedItems.Cast<FEATS>().ToList();

            foreach (var feat in selectedFeats)
            {
                var featToAddToCharacter = new FEATS
                {
                    f_id = feat.f_id,
                    f_name = feat.f_name,
                    f_source = feat.f_source,
                    f_description = feat.f_description
                };

                _loadedCharacterFeats.Add(featToAddToCharacter);
                
                _loadedFeats.Remove(_loadedFeats.First(x => x.f_id == featToAddToCharacter.f_id));
            }

            UpdateCharacterFeatSelection(selectedFeats);

            UpdateFeatDescription(false);
        }

        public void RemoveFeatFromCharacter()
        {
            var selectedFeats = _view.CharacterFeatsListBox.SelectedItems.Cast<FEATS>().ToList();

            foreach (var feat in selectedFeats)
            {
                var featToRemoveFromCharacter = new FEATS
                {
                    f_id = feat.f_id,
                    f_name = feat.f_name,
                    f_source = feat.f_source,
                    f_description = feat.f_description
                };

                _loadedFeats.Add(featToRemoveFromCharacter);

                _loadedCharacterFeats.Remove(_loadedCharacterFeats.First(x => x.f_id == featToRemoveFromCharacter.f_id));
            }

            UpdateFeatSelection(selectedFeats);

            UpdateFeatDescription(true);
        }

        public void UpdateCharacterSheet()
        {
            var characterFeats = _view.CharacterFeatsListBox.Items.Cast<FEATS>().ToList();

            _parentView.AddFeats(characterFeats);
            _parentView.UpdateFeatGrid();
        }

        public void UnselectFeats()
        {
            _view.FeatsListBox.ClearSelected();
        }

        public void UnselectCharacterFeats()
        {
            _view.CharacterFeatsListBox.ClearSelected();
        }

        public void UpdateFeatDescription(bool updateDescriptionFromFeatList)
        {
            FEATS selectedFeat;

            if (updateDescriptionFromFeatList)
                selectedFeat = (FEATS) _view.FeatsListBox.SelectedItem;
            else
                selectedFeat = (FEATS) _view.CharacterFeatsListBox.SelectedItem;

            if (selectedFeat == null)
            {
                _view.FeatSource.Text = "";
                _view.FeatDescription.Text = "";
            }
            else
            {
                _view.FeatSource.Text = selectedFeat.f_source;
                _view.FeatDescription.Text = selectedFeat.f_description;
            }
        }

        private void UpdateCharacterFeatSelection(List<FEATS> selectedFeats)
        {
            _view.CharacterFeatsListBox.ClearSelected();

            foreach (var feat in selectedFeats)
            {
                var featToSelect =
                   (from f in _view.CharacterFeatsListBox.Items.Cast<FEATS>()
                    where (f.f_id == feat.f_id)
                    select f).First();
                
                var index = _view.CharacterFeatsListBox.Items.IndexOf(featToSelect);

                _view.CharacterFeatsListBox.SetSelected(index, true);
            }
        }

        private void UpdateFeatSelection(List<FEATS> selectedFeats)
        {
            _view.FeatsListBox.ClearSelected();

            foreach (var feat in selectedFeats)
            {
                var featToSelect =
                    (from f in _view.FeatsListBox.Items.Cast<FEATS>()
                        where (f.f_id == feat.f_id)
                        select f).First();

                var index = _view.FeatsListBox.Items.IndexOf(featToSelect);

                _view.FeatsListBox.SetSelected(index, true);
            }
        }

        #endregion

    }
}
