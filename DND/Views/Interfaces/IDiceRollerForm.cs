using DND.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Views.Interfaces
{
    public interface IDiceRollerForm
    {
        int NumberOfDice { get; set; }
        int Bonus { get; set; }
        int Result { get; set; }
        string DiceID { get; set;}

        void SetController(DiceRollerController controller);
    }
}
