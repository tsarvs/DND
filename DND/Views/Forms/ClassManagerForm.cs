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
using DND.Models;
using DND.Views.Interfaces;

namespace DND.Views.Forms
{
    public partial class ClassManagerForm : Form, IClassManagerForm
    {

        #region Properties

        public Button AddClassToCharacterButton
        {
            get { return this.btnAddClassToCharacter; }
            set { this.btnAddClassToCharacter = value; }
        }

        public Button RemoveClassFromCharacterButton
        {
            get { return this.btnRemoveClassFromCharacter; }
            set { this.btnRemoveClassFromCharacter = value; }
        }

        public ListBox ClassListBox
        {
            get { return this.lbClasses; }
            set { this.lbClasses = value; }
        }

        public ListBox CharacterClassListBox
        {
            get { return this.lbCharacterClasses; }
            set { this.lbCharacterClasses = value; }
        }

        public NumericUpDown ClassLevel
        {
            get { return this.txtLevel;}
            set { this.txtLevel = value; }
        }

        private ClassManagerController _controller;

        private readonly int _characterId;

        private List<CHARACTER_CLASS> _loadedCharacterClasses;

        #endregion

        #region Constructor

        public ClassManagerForm(int characterId, List<CHARACTER_CLASS> loadedCharacterClasses)
        {
            InitializeComponent();

            _characterId = characterId;

            _loadedCharacterClasses = loadedCharacterClasses;
        }

        #endregion

        #region Methods

        internal void SetController(ClassManagerController controller)
        {
            _controller = controller;
        }

        private void ClassManagerForm_Load(object sender, EventArgs e)
        {
            _controller.PopulateControls(_characterId, _loadedCharacterClasses);
        }

        private void btnAddClassToCharacter_Click(object sender, EventArgs e)
        {
            _controller.AddClassToCharacter();
            //_controller.UnselectClasses();
        }

        private void btnRemoveClassFromCharacter_Click(object sender, EventArgs e)
        {
            _controller.RemoveClassFromCharacter();
            //_controller.UnselectCharacterClasses();
        }

        private void lbCharacterClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.RefreshLevel();
        }

        private void txtLevel_ValueChanged(object sender, EventArgs e)
        {
            _controller.UpdateLevel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _controller.UpdateParentView();

            this.Close();
        }

        #endregion


    }
}
