using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class FeatManagerController
    {
        #region Properties

        private IFeatManagerForm _view;

        #endregion

        #region Constructor

        public FeatManagerController(IFeatManagerForm view)
        {
            _view = view;
        }

        internal void PopulateControls(int characterId = 0)
        {
            using (var db = new DragonDBModel())
            {
                //lbFeats
                var featsQuery =
                    (from f in db.FEATS.ToList()
                        select f).ToList();

                _view.FeatsListBox.DataSource = featsQuery;
                _view.FeatsListBox.DisplayMember = "f_name";
                _view.FeatsListBox.ValueMember = "f_id";
                _view.FeatsListBox.SelectedItem = null;

                //lbCharacterFeats
                var characterFeatsQuery =
                    (from f in db.FEATS.ToList()
                        where (f.CHARACTER.Any(x => x.c_id == characterId))
                        select f).ToList();

                _view.CharacterFeatsListBox.DataSource = characterFeatsQuery;
                _view.CharacterFeatsListBox.DisplayMember = "f_name";
                _view.CharacterFeatsListBox.ValueMember = "f_id";
                _view.CharacterFeatsListBox.SelectedItem = null;

            }
        }

        public void UpdateFeatDisplay()
        {
            using (var db = new DragonDBModel())
            {
                //Todo: fix this
                var featId = Convert.ToInt32(_view.FeatsListBox.SelectedValue.ToString());

                var featQuery =
                    (from f in db.FEATS.ToList()
                    where (f.f_id == featId)
                    select new
                    {
                        Source = f.f_source,
                        Description = f.f_description
                    }).First();

                _view.FeatSource.Text = featQuery.Source;
                _view.FeatDescription.Text = featQuery.Description;

            }

            
        }

        #endregion

    }
}
