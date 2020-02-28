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
    public partial class AddEditRaceForm : Form, IAddEditRaceForm 
    {
        #region properties
        public int STR
        {
            get { return (int)this.txtSTR.Value; }
            set { this.txtSTR.Value = value; }
        }
        public int INT
        {
            get { return (int)this.txtINT.Value; }
            set { this.txtINT.Value = value; }
        }
        public int DEX
        {
            get { return (int)this.txtDEX.Value; }
            set { this.txtDEX.Value = value; }
        }
        public int CHA
        {
            get { return (int)this.txtCHA.Value; }
            set { this.txtCHA.Value = value; }
        }
        public int CON
        {
            get { return (int)this.txtCON.Value; }
            set { this.txtCON.Value = value; }
        }
        public int WIS
        {
            get { return (int)this.txtWIS.Value; }
            set { this.txtWIS.Value = value; }
        }
        public string RaceName
        {
            get { return this.txtRaceName.Text; }
            set { this.txtRaceName.Text = value; }
        }
        public string RaceDescription
        {
            get { return this.txtDescription.Text; }
            set { this.txtDescription.Text = value; }
        }
        public ComboBox RaceSelector
        {
            get { return this.cmbRaceSelector; }
            set { this.cmbRaceSelector = value; }
        }

        #endregion

        #region constructiors
        public AddEditRaceForm()
        {
            InitializeComponent();
        }
        #endregion

        #region methods
        private AddEditRaceController _controller;

        public void SetController(AddEditRaceController controller)
        {
            _controller = controller;
        }


        private void AddEditRaceForm_Load(object sender, EventArgs e)
        {
            _controller?.InitializeData();
        }

        #endregion

        private void cmbRaceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.UpdateRaceControls();
        }

        private void btnAddRace_Click(object sender, EventArgs e)
        {

        }
    }
}
