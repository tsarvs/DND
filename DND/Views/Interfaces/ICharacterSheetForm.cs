using System.Collections.Generic;
using System.Windows.Forms;
using DND.Controllers;
using DND.Models;
using DND.Views.Enums;

namespace DND.Views.Interfaces
{
    public interface ICharacterSheetForm
    {
        #region Properties

        FormMode CharacterSheetMode { get; set; }

        #region Demographic

        string CharacterName { get; set; }

        string Alignment { get; set; }

        ComboBox RaceComboBox { get; set; }

        ComboBox ClassComboBox { get; set; }

        int Level { get; set; }
        
        int Experience { get; set; }
        
        bool IsNpc { get; set; }

        #endregion

        #region Core Stats
        int ArmorClass { get; set; }

        int Speed { get; set; }

        int Initiative { get; set; }
        
        bool HasInspiration { get; set; }

        int HpCurrent { get; set; }

        int HpMax { get; set; }

        int HpTemp { get; set; }

        string HitDiceType { get; set; }

        int HitDiceCurrent { get; set; }

        int HitDiceMax { get; set; }
        
        #endregion

        #region Abilities

        int CHA { get; set; }

        int CON { get; set; }

        int DEX { get; set; }

        int INT { get; set; }

        int STR { get; set; }

        int WIS { get; set; }

        int CHA_RacialBonus { get; set; }

        int CON_RacialBonus { get; set; }

        int DEX_RacialBonus { get; set; }

        int INT_RacialBonus { get; set; }

        int STR_RacialBonus { get; set; }

        int WIS_RacialBonus { get; set; }

        int CHA_SavingThrow { get; set; }

        int CON_SavingThrow { get; set; }

        int DEX_SavingThrow { get; set; }

        int INT_SavingThrow { get; set; }

        int STR_SavingThrow { get; set; }

        int WIS_SavingThrow { get; set; }

        #endregion

        #region Skills

        int AnimalHandling { get; set; }

        int Arcana { get; set; }

        int Athletics { get; set; }

        int Deception { get; set; }

        int History { get; set; }

        int Insight { get; set; }

        int Intimidation { get; set; }

        int Medicine { get; set; }

        int Nature { get; set; }

        int Perception { get; set; }

        int Performance { get; set; }

        int Persuasion { get; set; }

        int Religion { get; set; }

        int SleightOfHand { get; set; }

        int Stealth { get; set; }

        int Survival { get; set; }

        #endregion

        #region Attacks

        DataGridView AttackGridView { get; set; }
        
        string AttackDescription { get; set; }

        #endregion

        #region Spellbook

        ComboBox SpellcastingAbility { get; set; }

        DataGridView SpellsGridView { get; set; }

        int SpellCastingTime { get; set; }

        int SpellRange { get; set; }

        int SpellDuration { get; set; }

        string SpellDescription { get; set; }

        int SpellSaveDC { get; set; }

        int SpellAttackBonus { get; set; }

        int SpellSlots_Level1_Current { get; set; }

        int SpellSlots_Level2_Current { get; set; }

        int SpellSlots_Level3_Current { get; set; }

        int SpellSlots_Level4_Current { get; set; }

        int SpellSlots_Level5_Current { get; set; }

        int SpellSlots_Level6_Current { get; set; }

        int SpellSlots_Level7_Current { get; set; }

        int SpellSlots_Level8_Current { get; set; }

        int SpellSlots_Level9_Current { get; set; }

        int SpellSlots_Level1_Max { get; set; }

        int SpellSlots_Level2_Max { get; set; }

        int SpellSlots_Level3_Max { get; set; }

        int SpellSlots_Level4_Max { get; set; }

        int SpellSlots_Level5_Max { get; set; }

        int SpellSlots_Level6_Max { get; set; }

        int SpellSlots_Level7_Max { get; set; }

        int SpellSlots_Level8_Max { get; set; }

        int SpellSlots_Level9_Max { get; set; }

        #endregion

        #region Inventory

        DataGridView InventoryGridView { get; set; }

        double InventoryWeight { get; set; }

        double Gold { get; set; }

        void AddFeats(List<FEATS> characterFeats);

        string ItemDescription { get; set; }

        #endregion

        #region Feats

        DataGridView FeatGridView { get; set; }

        string FeatDescription { get; set; }


        #endregion
        
        #region Proficiencies
        
        DataGridView ProficienciesGridView { get; set; }

        int ProficiencyBonus { get; set; }

        #endregion

        #region Background

        ComboBox LoreComboBox { get; set; }

        string LoreDescription { get; set; }

        #endregion

        #endregion

        #region Methods
        
        void UpdateFeatGrid();
        
        void LoadCharacterClasses(List<CHARACTER_CLASS> characterClassList);

        void SetController(CharacterSheetController controller);
        
        void AddAttack(CHARACTER_ATTACK attack);

        void UpdateAttacks(CHARACTER_ATTACK attack);

        void AddItem(ITEM item);

        void UpdateInventory(ITEM item);

        #endregion
    }
}