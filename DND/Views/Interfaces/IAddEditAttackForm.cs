using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Controllers;

namespace DND.Views.Interfaces
{
    public interface IAddEditAttackForm
    {
        #region Properties

        int AttackId { get; set; }

        string AttackName { get; set; }

        string AttackAbility { get; set; }

        int AttackBonus { get; set; }

        bool IsProficient { get; set; }

        string AttackRange { get; set; }

        string Damage1 { get; set; }

        string Damage2 { get; set; }

        string AttackDescription { get; set; }

        #endregion

        #region Methods

        void SetController(AddAttackController controller);



        #endregion
    }
}
