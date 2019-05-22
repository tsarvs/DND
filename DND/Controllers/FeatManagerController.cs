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

        private readonly List<FEATS> _dbFeats;

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
                _dbFeats = (from f in db.FEATS.ToList()
                           select f).ToList();
            }

            _loadedFeats = new BindingList<FEATS>(_dbFeats);
            _loadedCharacterFeats = new BindingList<FEATS>(loadedCharacterFeats);

            _view.FeatsListBox.DataSource = _loadedFeats;
            _view.CharacterFeatsListBox.DataSource = _loadedCharacterFeats;

            UpdateListDisplays();

        }

        #endregion

        #region Methods

        private void UpdateListDisplays()
        {
            _loadedFeats.Clear();

            foreach (var feat in _dbFeats)
            {
                _loadedFeats.Add(feat);
            }

            foreach (var feat in _loadedCharacterFeats)
            {
                _loadedFeats.Remove(_loadedFeats.First(x => x.f_id == feat.f_id));
            }
        }

        #endregion

    }
}
