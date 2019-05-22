using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Views.Interfaces
{
    interface IAddEditRaceForm
    {
        Button AddRace { get; set; }
        Button DeleteRace { get; set; }
        Button AddFeat { get; set; }
        Button SaveCloseRace { get; set; }
        String RaceDescription { get; set; }
        String FeatDescription { get; set; }
        String RaceName { get; set; }
        int STR { get; set; }
        int DEX { get; set; }
        int CON { get; set; }
        int INT { get; set; }
        int WIS { get; set; }
        int CHA { get; set; }
        ComboBox RaceSelector { get; set; }

        //void SetController(AddEditRaceController controller);
    }
}