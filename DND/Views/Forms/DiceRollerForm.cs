using DND.Controllers;
using DND.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Views.Forms
{
    public partial class DiceRollerForm : Form, IDiceRollerForm
    {
        public int NumberOfDice
        {
            get { return (int) this.txtNumberofDice.Value; }
            set { this.txtNumberofDice.Value = value; }
        }

        public int Bonus {
            get { return (int)this.txtBonus.Value; }
            set { this.txtBonus.Value = value; }
        }
        public int Result {
            get {
                return Convert.ToInt32(this.lblResult.Text); }
            set { this.lblResult.Text = value.ToString(); }
        }
        public String DiceID {
            get { return this.cmbDiceID.Text; }
            set { this.cmbDiceID.Text = value; }
        }
        private DiceRollerController _controller;

        public DiceRollerForm()
        {
            InitializeComponent();
        }

        public void SetController(DiceRollerController controller)
        {
            _controller = controller;
        }

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            _controller.RollDice();
        }
    }
}
