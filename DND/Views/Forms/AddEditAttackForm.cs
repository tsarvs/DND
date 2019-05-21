using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND.Controllers;
using DND.Models;
using DND.Views.Enums;
using DND.Views.Interfaces;

namespace DND.Views.Forms
{
    public partial class AddEditAttackForm : Form, IAddEditAttackForm
    {
        #region Properties

        public int AttackId { get; set; }

        public string AttackName
        {
            get { return this.txtAttackName.Text; }
            set { this.txtAttackName.Text = value; }
        }

        public string AttackAbility
        {
            get { return this.cmbAttackAbility.Text; }
            set { this.cmbAttackAbility.Text = value; }
        }

        public int AttackBonus
        {
            get { return (int) this.txtAttackBonus.Value; }
            set { this.txtAttackBonus.Value = value; }
        }

        public bool IsProficient
        {
            get { return this.chkProficient.Checked; }
            set { this.chkProficient.Checked = value; }
        }

        public string AttackRange
        {
            get { return this.txtAttackRange.Text; }
            set { this.txtAttackRange.Text = value; }
        }

        public string Damage1
        {
            get { return this.txtDamage1.Text; }
            set { this.txtDamage1.Text = value; }
        }

        public string Damage2
        {
            get { return this.txtDamage2.Text; }
            set { this.txtDamage2.Text = value; }
        }

        public string AttackDescription
        {
            get { return this.txtAttackDescription.Text; }
            set { this.txtAttackDescription.Text = value; }
        }

        private AddAttackController _controller;

        private FormMode _mode;

        #endregion

        #region Constructor

        public AddEditAttackForm()
        {
            InitializeComponent();

            _mode = FormMode.NewForm;
        }
        public AddEditAttackForm(CHARACTER_ATTACK attack)
        {
            InitializeComponent();

            _mode = FormMode.EditForm;

            this.AttackId = attack.a_id;
            this.AttackName = attack.a_name;
            this.AttackAbility = attack.a_attackability;
            this.AttackBonus = attack.a_attackbonus.GetValueOrDefault(0);
            this.IsProficient = attack.a_isproficient.GetValueOrDefault(false);
            this.AttackRange = attack.a_range;
            this.Damage1 = attack.a_damage1;
            this.Damage2 = attack.a_damage2;
            this.AttackDescription = attack.a_description;
            
        }

        #endregion

        #region Methods

        public void SetController(AddAttackController controller)
        {
            _controller = controller;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddToForm(_mode);

            this.Close();
        }


        #endregion
        
    }
}
