using DND.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Views.Interfaces
{
    public interface IAddEditRaceForm
    {
        string RaceDescription { get; set; }
        string RaceName { get; set; }
        int STR { get; set; }
        int DEX { get; set; }
        int CON { get; set; }
        int INT { get; set; }
        int WIS { get; set; }
        int CHA { get; set; }
        ComboBox RaceSelector { get; set; }

        void SetController(AddEditRaceController controller);
    }
}