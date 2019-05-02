using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DND.Views.Interfaces;
using DND.Models;

namespace DND.Controllers
{
    public class AddCampaignController
    {
        private readonly IAddCampaignForm _view;

        public AddCampaignController(IAddCampaignForm view)
        {
            _view = view;

            view.SetController(this);
        }

        public void AddCampaign()
        {
            using (var db = new DragonDBModel())
            {
                BACKGROUND campaignBackground = new BACKGROUND
                {
                    b_desc = _view.CampaignDescription
                };

                db.BACKGROUND.Add(campaignBackground);

                CAMPAIGN newCampaign = new CAMPAIGN
                {
                    cmp_name = _view.CampaignTitle,
                    cmp_dm = _view.DungeonMaster,
                    cmp_startdate = DateTime.Now,
                    BACKGROUND = db.BACKGROUND.Local
                };

                db.CAMPAIGN.Add(newCampaign);
                db.SaveChanges();
            }
            
        }
    }
}
