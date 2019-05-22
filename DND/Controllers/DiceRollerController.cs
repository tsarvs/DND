using DND.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DND.Controllers
{
    public class DiceRollerController
    {
        private IDiceRollerForm _view;
        private Random _randomRoll;

        public DiceRollerController(IDiceRollerForm view)
        {
            _view = view;
            _randomRoll = new Random();
        }

        public void RollDice()
        {
            var numOfDice = _view.NumberOfDice;
            var bonus = _view.Bonus;
            var diceID = _view.DiceID;

            var rollResult = RollSelectedDice(diceID, numOfDice);
            _view.Result = rollResult + bonus;
        }

        private int RollSelectedDice(string diceID, int numOfDice) {
            var roll = 0;
            var rollTotal = 0;
            var i = 1;

            while (i <= numOfDice)
            {

                if (diceID == "d4")
                {
                    roll = _randomRoll.Next(1, 4);
                }
                else if (diceID == "d6")
                {
                    roll = _randomRoll.Next(1, 6);
                }
                else if (diceID == "d8")
                {
                    roll = _randomRoll.Next(1, 8);
                }
                else if (diceID == "d10")
                {
                    roll = _randomRoll.Next(1, 10);
                }
                else if (diceID == "d12")
                {
                    roll = _randomRoll.Next(1, 12);
                }
                else if (diceID == "d20")
                {
                    roll = _randomRoll.Next(1, 20);
                }
                else if (diceID == "d100")
                {
                    roll = _randomRoll.Next(1, 100);
                }

                rollTotal = rollTotal + roll;
                i = i + 1;
            }

            return rollTotal;

        }
    }
}
