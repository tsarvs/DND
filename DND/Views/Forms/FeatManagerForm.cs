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

        public TextBox FeatDescription
        {
            get { return this.txtFeatDescription; }
            set { this.txtFeatDescription = value; }
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

        private void btnAddFeatToCharacter_Click(object sender, EventArgs e)
        {
            _controller.UnselectCharacterFeats();
            _controller.AddFeatToCharacter();
            _controller.UnselectFeats();

        }

        private void btnRemoveFeatFromCharacter_Click(object sender, EventArgs e)
        {
            _controller.UnselectFeats();
            _controller.RemoveFeatFromCharacter();
            _controller.UnselectCharacterFeats();
        }
        
        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    _controller.UpdateCharacterSheet();

        //    this.Close();
        //}

        private void FeatManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void lbFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller?.UpdateFeatDescription(true);
        }

        private void lbCharacterFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller?.UpdateFeatDescription(false);
        }

        private void lbFeats_Click(object sender, EventArgs e)
        {
            _controller.UnselectCharacterFeats();
        }

        private void lbCharacterFeats_Click(object sender, EventArgs e)
        {
            _controller.UnselectFeats();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _controller.UpdateCharacterSheet();

            this.Close();
        }

        #endregion

    }
}
