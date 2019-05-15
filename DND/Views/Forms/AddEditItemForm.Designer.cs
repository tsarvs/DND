namespace DND.Views.Forms
{
    partial class AddEditItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtItemWeight = new System.Windows.Forms.NumericUpDown();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(64, 12);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(293, 22);
            this.txtItemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity:";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(175, 40);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(57, 22);
            this.txtItemQuantity.TabIndex = 4;
            // 
            // txtItemWeight
            // 
            this.txtItemWeight.DecimalPlaces = 1;
            this.txtItemWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtItemWeight.Location = new System.Drawing.Point(300, 40);
            this.txtItemWeight.Name = "txtItemWeight";
            this.txtItemWeight.Size = new System.Drawing.Size(57, 22);
            this.txtItemWeight.TabIndex = 5;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(12, 85);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(345, 156);
            this.txtItemDescription.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Location = new System.Drawing.Point(226, 247);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(131, 25);
            this.btnUpdateInventory.TabIndex = 9;
            this.btnUpdateInventory.Text = "Update Inventory";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // AddEditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 283);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtItemWeight);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label1);
            this.Name = "AddEditItemForm";
            this.Text = "Add/Edit Item";
            ((System.ComponentModel.ISupportInitialize)(this.txtItemQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtItemQuantity;
        private System.Windows.Forms.NumericUpDown txtItemWeight;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateInventory;
    }
}