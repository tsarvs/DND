using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND.Controllers;

namespace DND.Views.Interfaces
{
    public interface ILoadCampaignForm
    {
        #region Properties

        DataGridView CampaignGrid { get; set; }

        #endregion

        #region Methods

        void SetController(LoadCampaignController controller);

        #endregion
    }
}
