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
    public partial class AddEditItemForm : Form, IAddEditItemForm
    {
        #region Properties

        public int ItemId { get; set; }

        public string ItemName
        {
            get { return this.txtItemName.Text; }
            set { this.txtItemName.Text = value; }
        }

        public int ItemQuantity
        {
            get { return (int)this.txtItemQuantity.Value; }
            set { this.txtItemQuantity.Value = value; }
        }

        public decimal? ItemWeight
        {
            get { return this.txtItemWeight.Value; }
            set { this.txtItemWeight.Value = value.GetValueOrDefault(); }
        }

        public string ItemDescription
        {
            get { return this.txtItemDescription.Text; }
            set { this.txtItemDescription.Text = value; }
        }

        private AddEditItemController _controller;

        private FormMode _mode;

        #endregion

        #region Constructors

        public AddEditItemForm()
        {
            InitializeComponent();

            _mode = FormMode.NewForm;
        }

        public AddEditItemForm(ITEM item)
        {
            InitializeComponent();

            _mode = FormMode.EditForm;

            PopulateContols(item);
        }

        #endregion

        #region Methods

        public void SetController(AddEditItemController controller)
        {
            _controller = controller;
        }

        private void PopulateContols(ITEM item)
        {
            //todo: try to move this into controller
            this.ItemId = item.i_id;
            this.ItemName = item.i_name;
            this.ItemQuantity = item.i_quantity.GetValueOrDefault(0);
            this.ItemWeight = item.i_weight;
            this.ItemDescription = item.i_description;
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            _controller.UpdateInventory(_mode);

            this.Close();
        }

        #endregion
    }
}
