using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Views.Interfaces
{
    interface ICharacterJournalForm
    {
        String JournalBody { get; set; }
        String PageNumber { get; set; }
        Button PrevPage { get; set; }
        Button NextPage { get; set; }
        Button AddEntry { get; set; }
        Button DeleteEntry { get; set; }

        //void SetController(CharacterJournalController controller);

    }
}
