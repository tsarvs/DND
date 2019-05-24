using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Views.Interfaces
{
    public interface ISpellbookManagerForm
    {
        ListBox SpellsListBox { get; set; }

        ListBox CharacterSpellsListBox { get; set; }

        string SpellDescription { get; set; }
    }
}
