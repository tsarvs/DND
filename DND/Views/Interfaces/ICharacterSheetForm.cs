using System.Windows.Forms;
using DND.Controllers;
using DND.Views.Enums;

namespace DND.Views.Interfaces
{
    public interface ICharacterSheetForm
    {
        #region Properties

        FormMode CharacterSheetMode { get; set; }

        string CharacterName { get; set; }

        string Race { get; set; }

        string Class { get; set; }

        int? Level { get; set; }

        string Alignment { get; set; }

        int? HPcurrent { get; set; }

        int? HPmax { get; set; }

        int? HPtemp { get; set; }

        bool? IsNPC { get; set; }

        bool? HasInspiration { get; set; }

        int? CHA { get; set; }

        int? CON { get; set; }

        int? DEX { get; set; }

        int? INT { get; set; }

        int? STR { get; set; }

        int? WIS { get; set; }

        int? AnimalHandling { get; set; }

        int? Arcana { get; set; }

        int? Athletics { get; set; }

        int? Deception { get; set; }

        int? History { get; set; }

        int? Insight { get; set; }

        int? Intimidation { get; set; }

        int? Medicine { get; set; }

        int? Nature { get; set; }

        int? Perception { get; set; }

        int? Performance { get; set; }

        int? Persuasion { get; set; }

        int? Religion { get; set; }

        int? SleightOfHand { get; set; }

        int? Stealth { get; set; }

        int? Survival { get; set; }

        #region Controlls

        DataGridView FeatGridView { get; set; }

        ComboBox RaceComboBox { get; set; }

        ComboBox ClassComboBox { get; set; }

        Label FeatDescription { get; set; }

        Panel FeatDescriptionPanel { get; set; }

        #endregion

        #endregion

        #region Methods

        void SetController(CharacterSheetController controller);

        #endregion
    }
}