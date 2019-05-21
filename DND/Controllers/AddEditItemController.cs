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
    public class AddEditItemController
    {
        #region Properties

        private IAddEditItemForm _view;

        private ICharacterSheetForm _parentView;

        #endregion

        #region Constructors

        public AddEditItemController(IAddEditItemForm view, ICharacterSheetForm parentView)
        {
            _view = view;
            _parentView = parentView;
        }

        #endregion

        #region Methods

        public void UpdateInventory(FormMode mode)
        {
            var rowCount = _parentView.InventoryGridView.Rows.Count;

            //if new form then get new attack id
            if (mode == FormMode.NewForm)
            {
                if (rowCount > 0)
                {
                    //get the ID of the last row + 1
                    _view.ItemId = (int) _parentView.InventoryGridView.Rows[rowCount - 1].Cells[0].Value + 1;
                }
                else
                {
                    _view.ItemId = 0;
                }
            }

            ITEM item = new ITEM
            {
                i_id = _view.ItemId,
                i_name = _view.ItemName,
                i_quantity = _view.ItemQuantity,
                i_weight = (decimal) _view.ItemWeight,
                i_description = _view.ItemDescription
            };

            if (mode == FormMode.NewForm)
            {
                _parentView.AddItem(item);
            }
            else
            {
                _parentView.UpdateInventory(item);
            }
        }

        #endregion
    }
}
