using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Enums;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class AddAttackController
    {
        #region Properties

        private IAddEditAttackForm _view;

        private ICharacterSheetForm _parentView;

        #endregion

        #region Constructor

        public AddAttackController(IAddEditAttackForm view, ICharacterSheetForm parentView)
        {
            _view = view;
            _parentView = parentView;
        }

        public void AddToForm(FormMode mode)
        {
            var rowCount = _parentView.AttackGridView.Rows.Count;
            
            //if new form then get new attack id
            if (mode == FormMode.NewForm)
            {
                if (rowCount > 0)
                {
                    //get the ID of the last row + 1
                    _view.AttackId = (int)_parentView.AttackGridView.Rows[rowCount - 1].Cells[0].Value + 1;
                }
                else
                {
                    _view.AttackId = 0;
                }
            }

            CHARACTER_ATTACK attack = new CHARACTER_ATTACK
            {
                a_id = _view.AttackId,
                a_name = _view.AttackName,
                a_attackability = _view.AttackAbility,
                a_attackbonus = _view.AttackBonus,
                a_isproficient = _view.IsProficient,
                a_range = _view.AttackRange,
                a_damage1 = _view.Damage1,
                a_damage2 = _view.Damage2,
                a_description = _view.AttackDescription
            };

            if (mode == FormMode.NewForm)
            {
                _parentView.AddAttack(attack);
            }
            else
            {
                _parentView.UpdateAttacks(attack);
            }
        }

        #endregion
    }
}
