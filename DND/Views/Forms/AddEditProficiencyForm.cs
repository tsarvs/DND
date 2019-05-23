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
    public partial class AddEditProficiencyForm : Form, IAddEditProficiencyForm
    {
        #region Properties

        public string ProficiencyType
        {
            get { return this.cmbProficiencyType.Text; }
            set { this.cmbProficiencyType.Text = value; }
        }

        public string ProficiencyName
        {
            get { return this.txtProficiencyName.Text; }
            set { this.txtProficiencyName.Text = value; }
        }

        private AddEditProficiencyController _controller;

        #endregion

        public AddEditProficiencyForm()
        {
            InitializeComponent();
        }

        public void SetController(AddEditProficiencyController controller)
        {
            _controller = controller;
        }

        private void btnUpdateCharacter_Click(object sender, EventArgs e)
        {
            _controller.AddProficiency();

            this.Close();
        }
    }
}
