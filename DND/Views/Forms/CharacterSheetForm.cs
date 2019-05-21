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
        
        private CharacterSheetController _controller;

        private int _characterId;

        #region Demographic

        public string CharacterName
        {
            get { return this.txtName.Text; }
            set { this.txtName.Text = value; }
        }

        public string Alignment
        {
            get { return this.cmbAlignment.Text; }
            set { this.cmbAlignment.Text = value; }
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

        public int Level
        {
            get { return (int)this.txtLevel.Value; }
            set { this.txtLevel.Value = value; }
        }

        public int Experience
        {
            get { return (int)this.txtExperience.Value; }
            set { this.txtExperience.Value = value; }
        }

        public bool IsNpc
        {
            get { return this.chkNPC.Checked; }
            set { this.chkNPC.Checked = value; }
        }

        #endregion
        
        #region Core Stats

        public int ArmorClass
        {
            get { return (int) this.txtAC.Value; }
            set { this.txtAC.Value = value; }
        }

        public int Speed
        {
            get { return (int) this.txtSpeed.Value; }
            set { this.txtSpeed.Value = value; }
        }

        public int Initiative
        {
            get { return (int)this.txtInitiative.Value; }
            set { this.txtInitiative.Value = value; }
        }

        public bool HasInspiration
        {
            get { return this.chkInspiration.Checked; }
            set { this.chkInspiration.Checked = value; }
        }

        public int HpCurrent
        {
            get { return Convert.ToInt32(this.txtHPcurrent.Text); }
            set { this.txtHPcurrent.Text = value.ToString(); }
        }

        public int HpMax
        {
            get { return Convert.ToInt32(this.txtHPmax.Text); }
            set { this.txtHPmax.Text = value.ToString(); }
        }

        public int HpTemp
        {
            get { return Convert.ToInt32(this.txtHPtemp.Text); }
            set { this.txtHPtemp.Text = value.ToString(); }
        }

        public string HitDiceType
        {
            get { return this.lblHitDiceType.Text; }
            set { this.lblHitDiceType.Text = value; }
        }

        public int HitDiceCurrent
        {
            get { return (int)this.txtHitDiceCurrent.Value; }
            set { this.txtHitDiceCurrent.Value = value; }
        }

        public int HitDiceMax
        {
            get { return (int)this.txtHitDiceMax.Value; }
            set { this.txtHitDiceMax.Value = value; }
        }

        #endregion

        #region Abilities

        public int CHA
        {
            get { return (int)this.txtCharisma.Value; }
            set { this.txtCharisma.Value = value; }
        }

        public int CON
        {
            get { return (int)this.txtConstitution.Value; }
            set { this.txtConstitution.Value = value; }
        }

        public int DEX
        {
            get { return (int)this.txtDexterity.Value; }
            set { this.txtDexterity.Value = value; }
        }

        public int INT
        {
            get { return (int)this.txtIntelligence.Value; }
            set { this.txtIntelligence.Value = value; }
        }

        public int STR
        {
            get { return (int)this.txtStrength.Value; }
            set { this.txtStrength.Value = value; }
        }

        public int WIS
        {
            get { return (int)this.txtWisdom.Value; }
            set { this.txtWisdom.Value = value; }
        }

        public int CHA_RacialBonus
        {
            get { return Convert.ToInt32(this.lblCharisma_RB.Text); }
            set { this.lblCharisma_RB.Text = value.ToString(); }
        }

        public int CON_RacialBonus
        {
            get { return Convert.ToInt32(this.lblConstitution_RB.Text); }
            set { this.lblConstitution_RB.Text = value.ToString(); }
        }

        public int DEX_RacialBonus
        {
            get { return Convert.ToInt32(this.lblDexterity_RB.Text); }
            set { this.lblDexterity_RB.Text = value.ToString(); }
        }

        public int INT_RacialBonus
        {
            get { return Convert.ToInt32(this.lblIntelligence_RB.Text); }
            set { this.lblIntelligence_RB.Text = value.ToString(); }
        }

        public int STR_RacialBonus
        {
            get { return Convert.ToInt32(this.lblStrength_RB.Text); }
            set { this.lblStrength_RB.Text = value.ToString(); }
        }

        public int WIS_RacialBonus
        {
            get { return Convert.ToInt32(this.lblWisdom_RB.Text); }
            set { this.lblWisdom_RB.Text = value.ToString(); }
        }

        public int CHA_SavingThrow
        {
            get { return Convert.ToInt32(this.lblCharisma_ST.Text); }
            set { this.lblCharisma_ST.Text = value.ToString(); }
        }

        public int CON_SavingThrow
        {
            get { return Convert.ToInt32(this.lblConstitution_ST.Text); }
            set { this.lblConstitution_ST.Text = value.ToString(); }
        }

        public int DEX_SavingThrow
        {
            get { return Convert.ToInt32(this.lblDexterity_ST.Text); }
            set { this.lblDexterity_ST.Text = value.ToString(); }
        }

        public int INT_SavingThrow
        {
            get { return Convert.ToInt32(this.lblIntelligence_ST.Text); }
            set { this.lblIntelligence_ST.Text = value.ToString(); }
        }

        public int STR_SavingThrow
        {
            get { return Convert.ToInt32(this.lblStrength_ST.Text); }
            set { this.lblStrength_ST.Text = value.ToString(); }
        }

        public int WIS_SavingThrow
        {
            get { return Convert.ToInt32(this.lblWisdom_ST.Text); }
            set { this.lblWisdom_ST.Text = value.ToString(); }
        }

        #endregion

        #region Skills

        public int AnimalHandling
        {
            get { return (int)this.txtAnimalHandling.Value; }
            set { this.txtAnimalHandling.Value = value; }
        }

        public int Arcana
        {
            get { return (int)this.txtArcana.Value; }
            set { this.txtArcana.Value = value; }
        }

        public int Athletics
        {
            get { return (int)this.txtAthletics.Value; }
            set { this.txtAthletics.Value = value; }
        }

        public int Deception
        {
            get { return (int)this.txtDeception.Value; }
            set { this.txtDeception.Value = value; }
        }

        public int History
        {
            get { return (int)this.txtHistory.Value; }
            set { this.txtHistory.Value = value; }
        }

        public int Insight
        {
            get { return (int)this.txtInsight.Value; }
            set { this.txtInsight.Value = value; }
        }

        public int Intimidation
        {
            get { return (int)this.txtIntimidation.Value; }
            set { this.txtIntimidation.Value = value; }
        }

        public int Medicine
        {
            get { return (int)this.txtMedicine.Value; }
            set { this.txtMedicine.Value = value; }
        }

        public int Nature
        {
            get { return (int)this.txtNature.Value; }
            set { this.txtNature.Value = value; }
        }

        public int Perception
        {
            get { return (int)this.txtPerception.Value; }
            set { this.txtPerception.Value = value; }
        }

        public int Performance
        {
            get { return (int)this.txtPerformance.Value; }
            set { this.txtPerformance.Value = value; }
        }

        public int Persuasion
        {
            get { return (int)this.txtPersuasion.Value; }
            set { this.txtPersuasion.Value = value; }
        }

        public int Religion
        {
            get { return (int)this.txtReligion.Value; }
            set { this.txtReligion.Value = value; }
        }

        public int SleightOfHand
        {
            get { return (int)this.txtSleightOfHand.Value; }
            set { this.txtSleightOfHand.Value = value; }
        }

        public int Stealth
        {
            get { return (int)this.txtStealth.Value; }
            set { this.txtStealth.Value = value; }
        }

        public int Survival
        {
            get { return (int)this.txtSurvival.Value; }
            set { this.txtSurvival.Value = value; }
        }

        #endregion

        #region Attacks

        public DataGridView AttackGridView
        {
            get { return this.dgvAttack; }
            set { this.dgvAttack = value; }
        }

        public string AttackDescription
        {
            get { return this.txtAttackDescription.Text; }
            set { this.txtAttackDescription.Text = value; }
        }

        #endregion

        #region Spellbook

        public ComboBox SpellcastingAbility
        {
            get { return this.cmbSpellcastingAbility; }
            set { this.cmbSpellcastingAbility = value; }
        }

        public DataGridView SpellsGridView
        {
            get { return this.dgvSpells; }
            set { this.dgvSpells = value; }
        }

        public int SpellCastingTime
        {
            get { return Convert.ToInt32(this.lblCastingTime.Text);}
            set { this.lblCastingTime.Text = value.ToString(); }
        }

        public int SpellRange
        {
            get { return Convert.ToInt32(this.lblRange.Text); }
            set { this.lblRange.Text = value.ToString(); }
        }

        public int SpellDuration
        {
            get { return Convert.ToInt32(this.lblDuration.Text); }
            set { this.lblDuration.Text = value.ToString(); }
        }

        public string SpellDescription
        {
            get { return this.txtSpellDescription.Text; }
            set { this.txtSpellDescription.Text = value; }
        }

        public int SpellSaveDC
        {
            get { return (int) this.txtSpellSaveDC.Value; }
            set { this.txtSpellSaveDC.Value = value; }
        }

        public int SpellAttackBonus
        {
            get { return (int)this.txtSpellAttackBonus.Value; }
            set { this.txtSpellAttackBonus.Value = value; }
        }

        public int SpellSlots_Level1_Current
        {
            get { return (int)this.txtSpellSlot_Level1_Current.Value; }
            set { this.txtSpellSlot_Level1_Current.Value = value; }
        }

        public int SpellSlots_Level2_Current
        {
            get { return (int)this.txtSpellSlot_Level2_Current.Value; }
            set { this.txtSpellSlot_Level2_Current.Value = value; }
        }

        public int SpellSlots_Level3_Current
        {
            get { return (int)this.txtSpellSlot_Level3_Current.Value; }
            set { this.txtSpellSlot_Level3_Current.Value = value; }
        }

        public int SpellSlots_Level4_Current
        {
            get { return (int)this.txtSpellSlot_Level4_Current.Value; }
            set { this.txtSpellSlot_Level4_Current.Value = value; }
        }

        public int SpellSlots_Level5_Current
        {
            get { return (int)this.txtSpellSlot_Level5_Current.Value; }
            set { this.txtSpellSlot_Level5_Current.Value = value; }
        }

        public int SpellSlots_Level6_Current
        {
            get { return (int)this.txtSpellSlot_Level6_Current.Value; }
            set { this.txtSpellSlot_Level6_Current.Value = value; }
        }

        public int SpellSlots_Level7_Current
        {
            get { return (int)this.txtSpellSlot_Level7_Current.Value; }
            set { this.txtSpellSlot_Level7_Current.Value = value; }
        }

        public int SpellSlots_Level8_Current
        {
            get { return (int)this.txtSpellSlot_Level8_Current.Value; }
            set { this.txtSpellSlot_Level8_Current.Value = value; }
        }

        public int SpellSlots_Level9_Current
        {
            get { return (int)this.txtSpellSlot_Level9_Current.Value; }
            set { this.txtSpellSlot_Level9_Current.Value = value; }
        }

        public int SpellSlots_Level1_Max
        {
            get { return (int)this.txtSpellSlot_Level1_Max.Value; }
            set { this.txtSpellSlot_Level1_Max.Value = value; }
        }

        public int SpellSlots_Level2_Max
        {
            get { return (int)this.txtSpellSlot_Level2_Max.Value; }
            set { this.txtSpellSlot_Level2_Max.Value = value; }
        }


        public int SpellSlots_Level3_Max
        {
            get { return (int)this.txtSpellSlot_Level3_Max.Value; }
            set { this.txtSpellSlot_Level3_Max.Value = value; }
        }


        public int SpellSlots_Level4_Max
        {
            get { return (int)this.txtSpellSlot_Level4_Max.Value; }
            set { this.txtSpellSlot_Level4_Max.Value = value; }
        }


        public int SpellSlots_Level5_Max
        {
            get { return (int)this.txtSpellSlot_Level5_Max.Value; }
            set { this.txtSpellSlot_Level5_Max.Value = value; }
        }


        public int SpellSlots_Level6_Max
        {
            get { return (int)this.txtSpellSlot_Level6_Max.Value; }
            set { this.txtSpellSlot_Level6_Max.Value = value; }
        }


        public int SpellSlots_Level7_Max
        {
            get { return (int)this.txtSpellSlot_Level7_Max.Value; }
            set { this.txtSpellSlot_Level7_Max.Value = value; }
        }

        public int SpellSlots_Level8_Max
        {
            get { return (int)this.txtSpellSlot_Level8_Max.Value; }
            set { this.txtSpellSlot_Level8_Max.Value = value; }
        }
        
        public int SpellSlots_Level9_Max
        {
            get { return (int)this.txtSpellSlot_Level9_Max.Value; }
            set { this.txtSpellSlot_Level9_Max.Value = value; }
        }


        #endregion

        #region Inventory

        public DataGridView InventoryGridView
        {
            get { return this.dgvInventory; }
            set { this.dgvInventory = value; }
        }

        public double InventoryWeight
        {
            get { return Convert.ToInt32(this.lblWeight.Text);}
            set { this.lblWeight.Text = value.ToString(); } //todo: set format
        }

        public double Gold
        {
            get { return (double) this.txtGold.Value; }
            set { this.txtGold.Value = (decimal) value; }
        }

        public string ItemDescription
        {
            get { return this.txtItemDescription.Text; }
            set { this.txtItemDescription.Text = value; }
        }

        #endregion

        #region Feats

        public DataGridView FeatGridView
        {
            get { return this.dgvFeats; }
            set { this.dgvFeats = value; }
        }

        public string FeatDescription
        {
            get { return this.txtFeatDescription.Text; }
            set { this.txtFeatDescription.Text = value; }
        }

        #endregion

        #region Proficiencies

        public DataGridView ProficienciesGridView
        {
            get { return this.dgvProficiencies; }
            set { this.dgvProficiencies = value; }
        }

        public int ProficiencyBonus
        {
            get { return (int) this.txtProficiencyBonus.Value; }
            set { this.txtProficiencyBonus.Value = value; }
        }

        #endregion

        #region Background

        public ComboBox LoreComboBox
        {
            get { return this.cmbLore; }
            set { this.cmbLore = value; }
        }

        public string LoreDescription
        {
            get { return this.txtLoreDescription.Text; }
            set { this.txtLoreDescription.Text = value; }
        }


        #endregion

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

        public void AddAttack(CHARACTER_ATTACK attack)
        {
            _controller.AddAttackToGrid(attack);
        }

        public void AddItem(ITEM item)
        {
            _controller.AddItemToGrid(item);
        }

        public void UpdateInventory(ITEM item)
        {
            if (_controller == null)
                return;

            _controller.UpdateInventoryGrid(item);
        }

        public void LoadCharacterClasses(List<CHARACTER_CLASS> characterClassList)
        {
            _controller.LoadCharacterClasses(characterClassList);
        }

        public void UpdateAttacks(CHARACTER_ATTACK attack)
        {
            if (_controller == null)
                return;

            _controller.UpdateAttackGrid(attack);
        }

        public void UpdateFeatGrid()
        {
            if (_controller == null)
                return;

            _controller.UpdateFeatGrid();
        }

        public void LoadCharacter(int characterId)
        {
            _characterId = characterId;

            _controller.InitializeData(_characterId);
            _controller.LoadCharacter();

            UpdateFeatGrid();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            _controller.SaveCharacter();

            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.SaveCharacter();
        }

        private void txtLevel_ValueChanged(object sender, EventArgs e)
        {
            _controller.UpdateClassLevel();
        }

        private void btnAddAttack_Click(object sender, EventArgs e)
        {
            _controller.AddAttack();
        }

        private void btnDeleteAttack_Click(object sender, EventArgs e)
        {
            _controller.DeleteSelectedAttack();
        }

        private void dgvAttack_SelectionChanged(object sender, EventArgs e)
        {
            _controller.UpdateAttackControls();
        }

        private void btnEditAttack_Click(object sender, EventArgs e)
        {
            _controller.EditAttack();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _controller.LoadAddEditItemForm(FormMode.NewForm);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            _controller.LoadAddEditItemForm(FormMode.EditForm);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteItem();
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            _controller.UpdateItemDescription();
        }

        #endregion


    }
}
