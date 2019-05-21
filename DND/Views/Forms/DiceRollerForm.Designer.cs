namespace DND.Views.Forms
{
    partial class DiceRollerForm
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
            this.txtNumberofDice = new System.Windows.Forms.NumericUpDown();
            this.txtBonus = new System.Windows.Forms.NumericUpDown();
            this.cmbDiceID = new System.Windows.Forms.ComboBox();
            this.lblNumberofDice = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberofDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumberofDice
            // 
            this.txtNumberofDice.Location = new System.Drawing.Point(32, 25);
            this.txtNumberofDice.Name = "txtNumberofDice";
            this.txtNumberofDice.Size = new System.Drawing.Size(51, 20);
            this.txtNumberofDice.TabIndex = 0;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(190, 25);
            this.txtBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(51, 20);
            this.txtBonus.TabIndex = 2;
            // 
            // cmbDiceID
            // 
            this.cmbDiceID.FormattingEnabled = true;
            this.cmbDiceID.Items.AddRange(new object[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"});
            this.cmbDiceID.Location = new System.Drawing.Point(89, 25);
            this.cmbDiceID.Name = "cmbDiceID";
            this.cmbDiceID.Size = new System.Drawing.Size(95, 21);
            this.cmbDiceID.TabIndex = 3;
            // 
            // lblNumberofDice
            // 
            this.lblNumberofDice.AutoSize = true;
            this.lblNumberofDice.Location = new System.Drawing.Point(12, 9);
            this.lblNumberofDice.Name = "lblNumberofDice";
            this.lblNumberofDice.Size = new System.Drawing.Size(81, 13);
            this.lblNumberofDice.TabIndex = 4;
            this.lblNumberofDice.Text = "Number of Dice";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(197, 9);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 6;
            this.lblBonus.Text = "Bonus";
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Location = new System.Drawing.Point(166, 52);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(75, 23);
            this.btnDiceRoll.TabIndex = 7;
            this.btnDiceRoll.Text = "Roll Dice";
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 57);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // DiceRollerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 90);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblNumberofDice);
            this.Controls.Add(this.cmbDiceID);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtNumberofDice);
            this.Name = "DiceRollerForm";
            this.Text = "DiceRollerForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberofDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtNumberofDice;
        private System.Windows.Forms.NumericUpDown txtBonus;
        private System.Windows.Forms.ComboBox cmbDiceID;
        private System.Windows.Forms.Label lblNumberofDice;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Button btnDiceRoll;
        private System.Windows.Forms.Label lblResult;
    }
}