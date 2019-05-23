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
            var k = 0;
            
                if (diceID == "d4")
                {
                    k = 4;
                }
                else if (diceID == "d6")
                {
                    k = 6;
                }
                else if (diceID == "d8")
                {
                    k = 8;
                }
                else if (diceID == "d10")
                {
                    k = 10;
                }
                else if (diceID == "d12")
                {
                    k = 12;
                }
                else if (diceID == "d20")
                {
                    k = 20;
                }
                else if (diceID == "d100")
                {
                    k = 100;
                }

            while (i <= numOfDice)
            {
                roll = _randomRoll.Next(1, k);
                rollTotal = rollTotal + roll;
                i = i + 1;
            }
            
            return rollTotal;
        }
    }
}
