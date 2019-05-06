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

        public Button AddFeatToCharacterButton
        {
            get { return this.btnAddFeatToCharacter; }
            set { this.btnAddFeatToCharacter = value; }
        }

        public Button RemoveFeatFromCharacterButton
        {
            get { return this.btnRemoveFeatFromCharacter; }
            set { this.btnRemoveFeatFromCharacter = value; }
        }

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

        private readonly int _characterId;
        
        private FeatManagerController _controller;

        private ICharacterSheetForm _parentView;

        #endregion

        #region Constructors

        public FeatManagerForm()
        {
            InitializeComponent();

            _characterId = 0;
            _parentView = null;
        }

        public FeatManagerForm(int characterId, ICharacterSheetForm parentView)
        {
            InitializeComponent();

            _characterId = characterId;
            _parentView = parentView;
        }

        #endregion

        #region Methods

        public void SetController(FeatManagerController controller)
        {
            _controller = controller;
        }

        private void FeatManagerForm_Shown(object sender, EventArgs e)
        {
            _controller.PopulateControls(_characterId);
        }

        private void lbFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.UpdateFeatDisplay(true);
        }

        private void btnRemoveFeatFromCharacter_Click(object sender, EventArgs e)
        {
            _controller.RemoveFeatFromCharacter();
            _controller.UnselectCharacterFeats();
        }

        private void btnAddFeatToCharacter_Click(object sender, EventArgs e)
        {
            _controller.AddFeatToCharacter();
            _controller.UnselectFeats();
        }

        private void lbCharacterFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.UpdateFeatDisplay(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _controller.Save();

            this.Close();
        }

        private void lbFeats_Click(object sender, EventArgs e)
        {
            _controller.UnselectCharacterFeats();
        }

        private void lbCharacterFeats_Click(object sender, EventArgs e)
        {
            _controller.UnselectFeats();
        }

        private void FeatManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentView.UpdateFeatGrid();
        }

        #endregion

    }
}
