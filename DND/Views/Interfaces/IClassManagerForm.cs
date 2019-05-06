using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Views.Interfaces
{
    public interface IClassManagerForm
    {
        #region Properties

        Button AddClassToCharacterButton { get; set; }

        Button RemoveClassFromCharacterButton { get; set; }

        ListBox ClassListBox { get; set; }

        ListBox CharacterClassListBox{ get; set; }

        NumericUpDown ClassLevel { get; set; }

        #endregion
    }
}
