using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND.Controllers;
using DND.Views.Interfaces;

namespace DND.Views.Forms
{
    public partial class LoadCampaignForm : Form, ILoadCampaignForm
    {
        #region Properties

        private LoadCampaignController _controller;

        public DataGridView CampaignGrid
        {
            get { return this.dgvCampaigns; }
            set { this.dgvCampaigns = value; }
        }

        public int SelectedCampaignID
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public LoadCampaignForm()
        {
            InitializeComponent();

            SelectedCampaignID = 0;
        }

        public void SetController(LoadCampaignController controller)
        {
            _controller = controller;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SelectedCampaignID = _controller.GetSelectedCampaignId();

            this.Close();
        }

        private void LoadCampaignForm_Load(object sender, EventArgs e)
        {
            _controller.BindData();
        }

        #endregion
    }
}
