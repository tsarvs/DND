using System.Windows.Forms;
using DND.Controllers;

namespace DND.Views.Interfaces
{
    public interface IFeatManagerForm
    {
        #region Properties

        Button AddFeatToCharacterButton { get; set; }

        Button RemoveFeatFromCharacterButton { get; set; }

        Label FeatSource { get; set; }

        Label FeatDescription { get; set; }

        ListBox FeatsListBox { get; set; }

        ListBox CharacterFeatsListBox { get; set; }

        #endregion

        #region Methods

        void SetController(FeatManagerController controller);
        void Reload();

        #endregion
    }
}