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
    public partial class NewFeatForm : Form, INewFeatForm
    {
        #region Properties

        public TextBox FeatName
        {
            get { return this.txtFeatName; }
            set { this.txtFeatName = value; }
        }

        public TextBox FeatSource
        {
            get { return this.txtSource; }
            set { this.txtSource = value; }
        }

        public TextBox FeatDescription
        {
            get { return this.txtDescription; }
            set { this.txtDescription = value; }
        }
        
        private NewFeatController _controller;

        #endregion

        public NewFeatForm()
        {
            InitializeComponent();
        }

        public void SetController(NewFeatController controller)
        {
            _controller = controller;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.Add();

            this.Close();
        }
    }
}
