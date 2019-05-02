using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND.Controllers;

namespace DND.Views.Interfaces
{
    public interface ILoadCharacterSheetForm
    {
        #region Properties

        DataGridView CharacterGridView { get; set; }

        #endregion

        #region Methods

        void SetController(LoadCharacterSheetController controller);

        #endregion

    }
}
