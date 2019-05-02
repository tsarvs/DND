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
    public partial class FeatManagerForm : Form, IFeatManagerForm
    {
        #region Properties

        public Label FeatSource
        {
            get { return this.lblFeatSource; }
            set { this.lblFeatSource = value; }
        }

        public Label FeatDescription
        {
            get { return this.lblFeatDescription; }
            set { this.lblFeatDescription = value; }
        }

        public ListBox FeatsListBox
        {
            get { return this.lbFeats; }
            set { this.lbFeats = value;  }
        }

        public ListBox CharacterFeatsListBox
        {
            get { return this.lbCharacterFeats; }
            set { this.lbCharacterFeats = value; }
        }

        private int _characterId;

        private FeatManagerController _controller;

        #endregion

        #region Constructors

        public FeatManagerForm()
        {
            InitializeComponent();

            _characterId = 0;
        }

        public FeatManagerForm(int characterId)
        {
            InitializeComponent();

            _characterId = characterId;
        }

        #endregion

        #region Methods

        public void SetController(FeatManagerController controller)
        {
            _controller = controller;
        }
        #endregion

        private void FeatManagerForm_Shown(object sender, EventArgs e)
        {
            _controller.PopulateControls(_characterId);
        }

        private void lbFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.UpdateFeatDisplay();
        }
    }
}
