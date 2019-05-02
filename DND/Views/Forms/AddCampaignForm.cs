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
    public partial class AddCampaignForm : Form, IAddCampaignForm
    {
        #region Properties

        private AddCampaignController _controller;

        public string CampaignTitle
        {
            get { return this.txtTitle.Text; }
            set { this.txtTitle.Text = value; }
        }

        public string DungeonMaster
        {
            get { return this.txtDM.Text; }
            set { this.txtDM.Text = value; }
        }

        public string CampaignDescription
        {
            get { return this.txtCampaignBackground.Text; }
            set { this.txtCampaignBackground.Text = value; }
        }

        #endregion

        #region Constructors
        public AddCampaignForm()
        {
            InitializeComponent();
        }

        public AddCampaignForm(AddCampaignController controller)
        {
            SetController(controller);
            InitializeComponent();
        }
        #endregion

        #region Methods
        public void SetController(AddCampaignController controller)
        {
            _controller = controller;
        }

        private void CampaignForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateCampaign_Click(object sender, EventArgs e)
        {
            _controller.AddCampaign();
            this.Close();
        }
        #endregion

    }
}
