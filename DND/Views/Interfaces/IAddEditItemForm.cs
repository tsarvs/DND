using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DND.Controllers;

namespace DND.Views.Interfaces
{
    public interface IAddEditItemForm
    {
        #region Properties

        int ItemId { get; set; }

        string ItemName { get; set; }

        int ItemQuantity { get; set; }

        decimal? ItemWeight { get; set; }

        string ItemDescription { get; set; }
        
        #endregion
        void SetController(AddEditItemController controller);

    }
}
