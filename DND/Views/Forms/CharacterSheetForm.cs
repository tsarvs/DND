using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DND.Models;
using DND.Controllers;
using DND.Views.Enums;
using DND.Views.Interfaces;

namespace DND.Views.Forms
{
    public partial class CharacterSheetForm : Form, ICharacterSheetForm
    {
        #region Properties

        public FormMode CharacterSheetMode { get; set; }

        public string CharacterName
        {
            get { return this.txtName.Text; }
            set { this.txtName.Text = value; }
        }

        public string Race
        {
            get { return this.cmbRace.Text; }
            set { this.cmbRace.Text = value; }
        }
        
        public int? Level
        {
            get { return Convert.ToInt32(this.txtLevel.Text); }
            set { this.txtLevel.Text = value.ToString(); }
        }

        public string Alignment
        {
            get { return this.cmbAlignment.Text; }
            set { this.cmbAlignment.Text = value; }
        }

        public int? HPcurrent
        {
            get { return Convert.ToInt32(this.txtHPcurrent.Text); }
            set { this.txtHPcurrent.Text = value.ToString(); }
        }

        public int? HPmax
        {
            get { return Convert.ToInt32(this.txtHPmax.Text); }
            set { this.txtHPmax.Text = value.ToString(); }
        }

        public int? HPtemp
        {
            get { return Convert.ToInt32(this.txtHPtemp.Text); }
            set { this.txtHPtemp.Text = value.ToString(); }
        }

        public bool? IsNPC
        {
            get { return this.chkNPC.Checked; }
            set { this.chkNPC.Checked = value.GetValueOrDefault(); }
        }

        public bool? HasInspiration
        {
            get { return this.chkInspiration.Checked; }
            set { this.chkInspiration.Checked = value.GetValueOrDefault(); }
        }

        public int? CHA
        {
            get { return Convert.ToInt32(this.txtCharisma.Text); }
            set { this.txtCharisma.Text = value.ToString(); }
        }

        public int? CON
        {
            get { return Convert.ToInt32(this.txtConstitution.Text); }
            set { this.txtConstitution.Text = value.ToString(); }
        }

        public int? DEX
        {
            get { return Convert.ToInt32(this.txtDexterity.Text); }
            set { this.txtDexterity.Text = value.ToString(); }
        }

        public int? INT
        {
            get { return Convert.ToInt32(this.txtIntelligence.Text); }
            set { this.txtIntelligence.Text = value.ToString(); }
        }

        public int? STR
        {
            get { return Convert.ToInt32(this.txtStrength.Text); }
            set { this.txtStrength.Text = value.ToString(); }
        }

        public int? WIS
        {
            get { return Convert.ToInt32(this.txtWisdom.Text); }
            set { this.txtWisdom.Text = value.ToString(); }
        }

        public int? AnimalHandling
        {
            get { return Convert.ToInt32(this.txtAnimalHandling.Text); }
            set { this.txtAnimalHandling.Text = value.ToString(); }
        }

        public int? Arcana
        {
            get { return Convert.ToInt32(this.txtArcana.Text); }
            set { this.txtArcana.Text = value.ToString(); }
        }

        public int? Athletics
        {
            get { return Convert.ToInt32(this.txtAthletics.Text); }
            set { this.txtAthletics.Text = value.ToString(); }
        }

        public int? Deception
        {
            get { return Convert.ToInt32(this.txtDeception.Text); }
            set { this.txtDeception.Text = value.ToString(); }
        }

        public int? History
        {
            get { return Convert.ToInt32(this.txtHistory.Text); }
            set { this.txtHistory.Text = value.ToString(); }
        }

        public int? Insight
        {
            get { return Convert.ToInt32(this.txtInsight.Text); }
            set { this.txtInsight.Text = value.ToString(); }
        }

        public int? Intimidation
        {
            get { return Convert.ToInt32(this.txtIntimidation.Text); }
            set { this.txtIntimidation.Text = value.ToString(); }
        }

        public int? Medicine
        {
            get { return Convert.ToInt32(this.txtMedicine.Text); }
            set { this.txtMedicine.Text = value.ToString(); }
        }

        public int? Nature
        {
            get { return Convert.ToInt32(this.txtNature.Text); }
            set { this.txtNature.Text = value.ToString(); }
        }

        public int? Perception
        {
            get { return Convert.ToInt32(this.txtPerception.Text); }
            set { this.txtPerception.Text = value.ToString(); }
        }

        public int? Performance
        {
            get { return Convert.ToInt32(this.txtPerformance.Text); }
            set { this.txtPerformance.Text = value.ToString(); }
        }

        public int? Persuasion
        {
            get { return Convert.ToInt32(this.txtPersuasion.Text); }
            set { this.txtPersuasion.Text = value.ToString(); }
        }

        public int? Religion
        {
            get { return Convert.ToInt32(this.txtReligion.Text); }
            set { this.txtReligion.Text = value.ToString(); }
        }

        public int? SleightOfHand
        {
            get { return Convert.ToInt32(this.txtSleightOfHand.Text); }
            set { this.txtSleightOfHand.Text = value.ToString(); }
        }

        public int? Stealth
        {
            get { return Convert.ToInt32(this.txtStealth.Text); }
            set { this.txtStealth.Text = value.ToString(); }
        }

        public int? Survival
        {
            get { return Convert.ToInt32(this.txtSurvival.Text); }
            set { this.txtSurvival.Text = value.ToString(); }
        }

        public DataGridView FeatGridView
        {
            get { return this.dgvFeats; }
            set { this.dgvFeats = value; }
        }

        public ComboBox RaceComboBox
        {
            get { return this.cmbRace; }
            set { this.cmbRace = value; }
        }

        public ComboBox ClassComboBox
        {
            get { return this.cmbClass; }
            set { this.cmbClass = value; }
        }

        public Label FeatDescription
        {
            get { return this.lblFeatDescription; }
            set { this.lblFeatDescription = value; }
        }
        
        private CharacterSheetController _controller;

        private int _characterId;

        #endregion

        #region Constructor
        public CharacterSheetForm()
        {
            CharacterSheetMode = FormMode.NewForm;

            _characterId = 0;

            InitializeComponent();
        }
        #endregion

        #region Methods

        public void SetController(CharacterSheetController controller)
        {
            _controller = controller;
        }

        public void UpdateFeatGrid()
        {
            if (_controller == null)
                return;

            _controller.UpdateFeatGrid();
        }

        public void UpdateClassControls()
        {
            if (_controller == null)
                return;

            _controller.UpdateCharacterClasses();
        }

        public void LoadCharacter(int characterId)
        {
            CharacterSheetMode = FormMode.EditForm;

            _characterId = characterId;

            _controller.BindData(_characterId);
            _controller.LoadCharacterSheet();

            UpdateFeatGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _controller.SaveCharacter();
        }
        
        private void dgvFeats_SelectionChanged(object sender, EventArgs e)
        {
            _controller.UpdateFeatControls();
        }

        private void btnManageFeats_Click(object sender, EventArgs e)
        {
            _controller.ManageFeats();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.UpdateLevel();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            _controller.AddClass();
        }

        #endregion

    }
}
