using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DND.Controllers;

namespace DND.Views.Interfaces
{
    public interface IAddCampaignForm
    {
        #region Properties
        string CampaignTitle { get; set; }

        string DungeonMaster { get; set; }

        string CampaignDescription { get; set; }
        #endregion

        #region Methods
        void SetController(AddCampaignController controller);

        #endregion


    }
}
