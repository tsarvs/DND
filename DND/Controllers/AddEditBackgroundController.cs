using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Enums;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class AddEditBackgroundController
    {
        private IAddEditBackgroundForm _view;

        private ICharacterSheetForm _parentView;

        private CHARACTER_BACKGROUND _loadedBackground;

        private FormMode _mode;

        public AddEditBackgroundController(IAddEditBackgroundForm view, ICharacterSheetForm parentView)
        {
            _mode = FormMode.NewForm;

            _view = view;
            _parentView = parentView;
            _loadedBackground = new CHARACTER_BACKGROUND();

            RefreshControls();
        }

        public AddEditBackgroundController(IAddEditBackgroundForm view, ICharacterSheetForm parentView, CHARACTER_BACKGROUND background)
        {
            _mode = FormMode.EditForm;

            _view = view;
            _parentView = parentView;
            _loadedBackground = background;

            RefreshControls();
        }

        private void RefreshControls()
        {
            _view.LoreTitle = _loadedBackground.cb_title;
            _view.LoreDescription = _loadedBackground.cb_description;
        }

        public void UpdateCharacter()
        {
            _loadedBackground.cb_title = _view.LoreTitle;
            _loadedBackground.cb_description = _view.LoreDescription;

            _parentView.AddLore(_loadedBackground);
        }
    }
}
