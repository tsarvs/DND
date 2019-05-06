using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class NewFeatController
    {
        #region Properties

        private IFeatManagerForm _parentView;

        private INewFeatForm _view;

        #endregion

        #region Constructor

        public NewFeatController(INewFeatForm view, IFeatManagerForm parentView)
        {
            _view = view;
            _parentView = parentView;
        }

        #endregion

        #region Methods

        public void Add()
        {
            var featToAdd = new FEATS
            {
                f_name = _view.FeatName.Text,
                f_source = _view.FeatSource.Text,
                f_description = _view.FeatDescription.Text
            };

            using (var db = new DragonDBModel())
            {
                db.FEATS.Add(featToAdd);

                db.SaveChanges();
            }

            _parentView.Reload();
        }


        #endregion
    }
}
