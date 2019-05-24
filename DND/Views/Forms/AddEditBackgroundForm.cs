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
    public partial class AddEditBackgroundForm : Form, IAddEditBackgroundForm
    {
        #region Properties

        public string LoreTitle
        {
            get { return this.txtTitle.Text; }
            set { this.txtTitle.Text = value; }
        }

        public string LoreDescription
        {
            get { return this.txtDescription.Text; }
            set { this.txtDescription.Text = value; }
        }

        private AddEditBackgroundController _controller;

        #endregion

        public AddEditBackgroundForm()
        {
            InitializeComponent();
        }

        public void SetController(AddEditBackgroundController controller)
        {
            _controller = controller;
        }

        private void btnUpdateCharacter_Click(object sender, EventArgs e)
        {
            _controller.UpdateCharacter();

            this.Close();
        }
    }
}
