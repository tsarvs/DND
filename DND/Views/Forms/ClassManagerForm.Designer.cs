namespace DND.Views.Forms
{
    partial class ClassManagerForm
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
            this.btnRemoveClassFromCharacter = new System.Windows.Forms.Button();
            this.btnAddClassToCharacter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCharacterClasses = new System.Windows.Forms.ListBox();
            this.lbClasses = new System.Windows.Forms.ListBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveClassFromCharacter
            // 
            this.btnRemoveClassFromCharacter.Location = new System.Drawing.Point(264, 211);
            this.btnRemoveClassFromCharacter.Name = "btnRemoveClassFromCharacter";
            this.btnRemoveClassFromCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveClassFromCharacter.TabIndex = 11;
            this.btnRemoveClassFromCharacter.Text = "<-";
            this.btnRemoveClassFromCharacter.UseVisualStyleBackColor = true;
            this.btnRemoveClassFromCharacter.Click += new System.EventHandler(this.btnRemoveClassFromCharacter_Click);
            // 
            // btnAddClassToCharacter
            // 
            this.btnAddClassToCharacter.Location = new System.Drawing.Point(264, 181);
            this.btnAddClassToCharacter.Name = "btnAddClassToCharacter";
            this.btnAddClassToCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnAddClassToCharacter.TabIndex = 10;
            this.btnAddClassToCharacter.Text = "->";
            this.btnAddClassToCharacter.UseVisualStyleBackColor = true;
            this.btnAddClassToCharacter.Click += new System.EventHandler(this.btnAddClassToCharacter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Character Classes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classes";
            // 
            // lbCharacterClasses
            // 
            this.lbCharacterClasses.FormattingEnabled = true;
            this.lbCharacterClasses.ItemHeight = 16;
            this.lbCharacterClasses.Location = new System.Drawing.Point(345, 29);
            this.lbCharacterClasses.Name = "lbCharacterClasses";
            this.lbCharacterClasses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbCharacterClasses.Size = new System.Drawing.Size(243, 356);
            this.lbCharacterClasses.TabIndex = 7;
            this.lbCharacterClasses.SelectedIndexChanged += new System.EventHandler(this.lbCharacterClasses_SelectedIndexChanged);
            // 
            // lbClasses
            // 
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.ItemHeight = 16;
            this.lbClasses.Location = new System.Drawing.Point(15, 29);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbClasses.Size = new System.Drawing.Size(243, 356);
            this.lbClasses.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(346, 394);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 17);
            this.lblLevel.TabIndex = 13;
            this.lblLevel.Text = "Level:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(475, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(398, 392);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(42, 22);
            this.txtLevel.TabIndex = 15;
            this.txtLevel.ValueChanged += new System.EventHandler(this.txtLevel_ValueChanged);
            // 
            // ClassManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 455);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveClassFromCharacter);
            this.Controls.Add(this.btnAddClassToCharacter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCharacterClasses);
            this.Controls.Add(this.lbClasses);
            this.Name = "ClassManagerForm";
            this.Text = "ClassManagerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClassManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ClassManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveClassFromCharacter;
        private System.Windows.Forms.Button btnAddClassToCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCharacterClasses;
        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown txtLevel;
    }
}