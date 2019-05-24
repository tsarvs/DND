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
    public partial class SpellbookManagerForm : Form, ISpellbookManagerForm
    {
        #region Properties

        public ListBox SpellsListBox
        {
            get { return this.lbSpells; }
            set { this.lbSpells = value; }
        }

        public ListBox CharacterSpellsListBox
        {
            get { return this.lbCharacterSpells; }
            set { this.lbCharacterSpells = value; }
        }

        public string SpellDescription
        {
            get { return this.txtSpellDescription.Text; }
            set { this.txtSpellDescription.Text = value; }
        }

        private SpellbookManagerController _controller;

        #endregion

        public SpellbookManagerForm()
        {
            InitializeComponent();
        }

        public void SetController(SpellbookManagerController controller)
        {
            _controller = controller;
        }

        private void btnAddSpellsToCharacter_Click(object sender, EventArgs e)
        {
            _controller.UnselectCharacterSpells();
            _controller.AddSpellsToCharacter();
            _controller.UnselectSpells();
        }

        private void btnRemoveSpellsFromCharacter_Click(object sender, EventArgs e)
        {
            _controller.UnselectSpells();
            _controller.RemoveSpellsFromCharacter();
            _controller.UnselectCharacterSpells();
        }

        private void btnUpdateCharacter_Click(object sender, EventArgs e)
        {
            _controller.UpdateCharacterSheet();

            this.Close();
        }

        private void lbSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller?.UpdateSpellDescription(true);
        }

        private void lbCharacterSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller?.UpdateSpellDescription(false);
        }

        private void lbSpells_Click(object sender, EventArgs e)
        {
            _controller.UnselectCharacterSpells();
        }

        private void lbCharacterSpells_Click(object sender, EventArgs e)
        {
            _controller.UnselectSpells();
        }
    }
}
