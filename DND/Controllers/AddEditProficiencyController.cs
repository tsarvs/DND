using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class AddEditProficiencyController
    {
        #region Properties

        private PROFICIENCY _loadedProficiency;

        private IAddEditProficiencyForm _view;

        private ICharacterSheetForm _parentView;

        #endregion

        public AddEditProficiencyController(IAddEditProficiencyForm view, ICharacterSheetForm parentView)
        {
            _loadedProficiency = new PROFICIENCY();
            _view = view;
            _parentView = parentView;

            RefreshControls();
        }

        public AddEditProficiencyController(IAddEditProficiencyForm view, ICharacterSheetForm parentView, PROFICIENCY proficiency)
        {
            _loadedProficiency = proficiency;
            _view = view;
            _parentView = parentView;

            RefreshControls();
        }

        public void AddProficiency()
        {
            _loadedProficiency.p_type = _view.ProficiencyType;
            _loadedProficiency.p_name = _view.ProficiencyName;

            _parentView.AddProficiency(_loadedProficiency);
        }

        private void RefreshControls()
        {
            _view.ProficiencyType = _loadedProficiency.p_type;
            _view.ProficiencyName = _loadedProficiency.p_name;
        }
    }
}
