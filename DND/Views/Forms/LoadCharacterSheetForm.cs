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
    public partial class LoadCharacterSheetForm : Form, ILoadCharacterSheetForm
    {
        #region Properties

        public DataGridView CharacterGridView
        {
            get { return this.dgvCharacters; }
            set { this.dgvCharacters = value; }
        }

        private LoadCharacterSheetController _controller;

        #endregion

        public LoadCharacterSheetForm()
        {
            InitializeComponent();
        }

        public void SetController(LoadCharacterSheetController controller)
        {
            _controller = controller;
        }

        private void btnLoadCharacterSheet_Click(object sender, EventArgs e)
        {
            this.Close();

            _controller.LoadCharacter();
        }
    }
}
