namespace DND.Views.Forms
{
    partial class AddEditAttackForm
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
            this.txtAttackName = new System.Windows.Forms.TextBox();
            this.txtAttackBonus = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkProficient = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAttackRange = new System.Windows.Forms.TextBox();
            this.txtDamage1 = new System.Windows.Forms.TextBox();
            this.txtDamage2 = new System.Windows.Forms.TextBox();
            this.txtAttackDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAttackAbility = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttackBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAttackName
            // 
            this.txtAttackName.Location = new System.Drawing.Point(69, 12);
            this.txtAttackName.Name = "txtAttackName";
            this.txtAttackName.Size = new System.Drawing.Size(251, 22);
            this.txtAttackName.TabIndex = 21;
            // 
            // txtAttackBonus
            // 
            this.txtAttackBonus.Location = new System.Drawing.Point(174, 41);
            this.txtAttackBonus.Name = "txtAttackBonus";
            this.txtAttackBonus.Size = new System.Drawing.Size(51, 22);
            this.txtAttackBonus.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "+";
            // 
            // chkProficient
            // 
            this.chkProficient.AutoSize = true;
            this.chkProficient.Location = new System.Drawing.Point(231, 42);
            this.chkProficient.Name = "chkProficient";
            this.chkProficient.Size = new System.Drawing.Size(89, 21);
            this.chkProficient.TabIndex = 17;
            this.chkProficient.Text = "Proficient";
            this.chkProficient.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Damage 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Damage 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Attack:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // txtAttackRange
            // 
            this.txtAttackRange.Location = new System.Drawing.Point(69, 70);
            this.txtAttackRange.Name = "txtAttackRange";
            this.txtAttackRange.Size = new System.Drawing.Size(77, 22);
            this.txtAttackRange.TabIndex = 22;
            // 
            // txtDamage1
            // 
            this.txtDamage1.Location = new System.Drawing.Point(93, 98);
            this.txtDamage1.Name = "txtDamage1";
            this.txtDamage1.Size = new System.Drawing.Size(227, 22);
            this.txtDamage1.TabIndex = 23;
            // 
            // txtDamage2
            // 
            this.txtDamage2.Location = new System.Drawing.Point(93, 126);
            this.txtDamage2.Name = "txtDamage2";
            this.txtDamage2.Size = new System.Drawing.Size(227, 22);
            this.txtDamage2.TabIndex = 24;
            // 
            // txtAttackDescription
            // 
            this.txtAttackDescription.Location = new System.Drawing.Point(12, 171);
            this.txtAttackDescription.Multiline = true;
            this.txtAttackDescription.Name = "txtAttackDescription";
            this.txtAttackDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAttackDescription.Size = new System.Drawing.Size(308, 188);
            this.txtAttackDescription.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 28);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Update Attacks";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Description:";
            // 
            // cmbAttackAbility
            // 
            this.cmbAttackAbility.FormattingEnabled = true;
            this.cmbAttackAbility.Items.AddRange(new object[] {
            "None",
            "CHA",
            "CON",
            "DEX",
            "INT",
            "STR",
            "WIS"});
            this.cmbAttackAbility.Location = new System.Drawing.Point(69, 40);
            this.cmbAttackAbility.Name = "cmbAttackAbility";
            this.cmbAttackAbility.Size = new System.Drawing.Size(77, 24);
            this.cmbAttackAbility.TabIndex = 28;
            // 
            // AddEditAttackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 406);
            this.Controls.Add(this.cmbAttackAbility);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAttackDescription);
            this.Controls.Add(this.txtDamage2);
            this.Controls.Add(this.txtDamage1);
            this.Controls.Add(this.txtAttackRange);
            this.Controls.Add(this.txtAttackName);
            this.Controls.Add(this.txtAttackBonus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkProficient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddEditAttackForm";
            this.Text = "Add/Edit Attack";
            ((System.ComponentModel.ISupportInitialize)(this.txtAttackBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAttackName;
        private System.Windows.Forms.NumericUpDown txtAttackBonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkProficient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAttackRange;
        private System.Windows.Forms.TextBox txtDamage1;
        private System.Windows.Forms.TextBox txtDamage2;
        private System.Windows.Forms.TextBox txtAttackDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAttackAbility;
    }
}