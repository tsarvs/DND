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
using DND.Interfaces;
using DND.Views.Enums;
using DND.Views.Interfaces;

namespace DND.Views.Forms
{
    public partial class MainForm : Form, IMainForm
    {
        private int _campaignID;
        public MainForm()
        {
            _campaignID = 0;
            InitializeComponent();
        }

        private void newCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCampaignForm form = new AddCampaignForm();

            form.SetController(new AddCampaignController(form));

            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCampaignForm form = new LoadCampaignForm();

            form.SetController(new LoadCampaignController(form));

            form.ShowDialog();

            _campaignID = form.SelectedCampaignID;
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterSheetForm form = new CharacterSheetForm();

            form.SetController(new CharacterSheetController(form));

            form.LoadCharacter(_campaignID);

            form.ShowDialog();
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCharacterSheetForm form = new LoadCharacterSheetForm();

            form.SetController(new LoadCharacterSheetController(form));

            form.ShowDialog();
        }
    }
}
