using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DND.Models;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class LoadCampaignController
    {
        #region Properties
        
        private ILoadCampaignForm _view;

        #endregion

        #region Constructors

        public LoadCampaignController(ILoadCampaignForm view)
        {
            _view = view;
        }

        #endregion

        #region Methods

        public void BindData()
        {
            using (var db = new DragonDBModel())
            {
                db.CAMPAIGN.Load();

                //EF to LINQ
                var gridContent = from c in db.CAMPAIGN.ToList()
                    select new
                    {
                        ID = c.cmp_id,
                        Campaign = c.cmp_name,
                        DungeonMaster = c.cmp_dm,
                        Started = c.cmp_startdate
                    };
                
               _view.CampaignGrid.DataSource = gridContent.ToList();
            }

            SetColumnStyling();
        }

        public int GetSelectedCampaignId()
        {
            var id = (int)_view.CampaignGrid.SelectedRows[0].Cells[0].Value;

            return id;
        }

        private void SetColumnStyling()
        {
            foreach (DataGridViewColumn column in _view.CampaignGrid.Columns)
            {
                switch (column.Name)
                {
                    case ("ID"):
                        column.Width = 20;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case ("Campaign"):
                        column.Width = 208;
                        break;
                    case ("DungeonMaster"):
                        column.Width = 100;
                        break;
                    case ("Started"):
                        column.Width = 70;
                        break;
                }
            }
        }

        #endregion
    }
}
