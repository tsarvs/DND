namespace DND.Views.Forms
{
    partial class FeatManagerForm
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
            this.lbFeats = new System.Windows.Forms.ListBox();
            this.lbCharacterFeats = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFeatToCharacter = new System.Windows.Forms.Button();
            this.btnRemoveFeatFromCharacter = new System.Windows.Forms.Button();
            this.btnNewFeat = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFeatDescription = new System.Windows.Forms.Label();
            this.lblFeatSource = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFeats
            // 
            this.lbFeats.FormattingEnabled = true;
            this.lbFeats.ItemHeight = 16;
            this.lbFeats.Location = new System.Drawing.Point(15, 29);
            this.lbFeats.Name = "lbFeats";
            this.lbFeats.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFeats.Size = new System.Drawing.Size(243, 356);
            this.lbFeats.TabIndex = 0;
            this.lbFeats.Click += new System.EventHandler(this.lbFeats_Click);
            this.lbFeats.SelectedIndexChanged += new System.EventHandler(this.lbFeats_SelectedIndexChanged);
            // 
            // lbCharacterFeats
            // 
            this.lbCharacterFeats.FormattingEnabled = true;
            this.lbCharacterFeats.ItemHeight = 16;
            this.lbCharacterFeats.Location = new System.Drawing.Point(345, 29);
            this.lbCharacterFeats.Name = "lbCharacterFeats";
            this.lbCharacterFeats.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbCharacterFeats.Size = new System.Drawing.Size(243, 356);
            this.lbCharacterFeats.TabIndex = 1;
            this.lbCharacterFeats.Click += new System.EventHandler(this.lbCharacterFeats_Click);
            this.lbCharacterFeats.SelectedIndexChanged += new System.EventHandler(this.lbCharacterFeats_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Character Feats";
            // 
            // btnAddFeatToCharacter
            // 
            this.btnAddFeatToCharacter.Location = new System.Drawing.Point(264, 181);
            this.btnAddFeatToCharacter.Name = "btnAddFeatToCharacter";
            this.btnAddFeatToCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnAddFeatToCharacter.TabIndex = 4;
            this.btnAddFeatToCharacter.Text = "->";
            this.btnAddFeatToCharacter.UseVisualStyleBackColor = true;
            this.btnAddFeatToCharacter.Click += new System.EventHandler(this.btnAddFeatToCharacter_Click);
            // 
            // btnRemoveFeatFromCharacter
            // 
            this.btnRemoveFeatFromCharacter.Location = new System.Drawing.Point(264, 211);
            this.btnRemoveFeatFromCharacter.Name = "btnRemoveFeatFromCharacter";
            this.btnRemoveFeatFromCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFeatFromCharacter.TabIndex = 5;
            this.btnRemoveFeatFromCharacter.Text = "<-";
            this.btnRemoveFeatFromCharacter.UseVisualStyleBackColor = true;
            this.btnRemoveFeatFromCharacter.Click += new System.EventHandler(this.btnRemoveFeatFromCharacter_Click);
            // 
            // btnNewFeat
            // 
            this.btnNewFeat.Location = new System.Drawing.Point(356, 560);
            this.btnNewFeat.Name = "btnNewFeat";
            this.btnNewFeat.Size = new System.Drawing.Size(113, 23);
            this.btnNewFeat.TabIndex = 6;
            this.btnNewFeat.Text = "Add/Edit Feat";
            this.btnNewFeat.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(475, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFeatDescription);
            this.panel1.Controls.Add(this.lblFeatSource);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 163);
            this.panel1.TabIndex = 8;
            // 
            // lblFeatDescription
            // 
            this.lblFeatDescription.AutoSize = true;
            this.lblFeatDescription.Location = new System.Drawing.Point(3, 23);
            this.lblFeatDescription.MaximumSize = new System.Drawing.Size(571, 126);
            this.lblFeatDescription.MinimumSize = new System.Drawing.Size(571, 126);
            this.lblFeatDescription.Name = "lblFeatDescription";
            this.lblFeatDescription.Size = new System.Drawing.Size(571, 126);
            this.lblFeatDescription.TabIndex = 3;
            // 
            // lblFeatSource
            // 
            this.lblFeatSource.AutoSize = true;
            this.lblFeatSource.Location = new System.Drawing.Point(60, 0);
            this.lblFeatSource.Name = "lblFeatSource";
            this.lblFeatSource.Size = new System.Drawing.Size(0, 17);
            this.lblFeatSource.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source:";
            // 
            // FeatManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewFeat);
            this.Controls.Add(this.btnRemoveFeatFromCharacter);
            this.Controls.Add(this.btnAddFeatToCharacter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCharacterFeats);
            this.Controls.Add(this.lbFeats);
            this.Name = "FeatManagerForm";
            this.Text = "Feat Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FeatManagerForm_FormClosed);
            this.Shown += new System.EventHandler(this.FeatManagerForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFeats;
        private System.Windows.Forms.ListBox lbCharacterFeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFeatToCharacter;
        private System.Windows.Forms.Button btnRemoveFeatFromCharacter;
        private System.Windows.Forms.Button btnNewFeat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFeatDescription;
        private System.Windows.Forms.Label lblFeatSource;
        private System.Windows.Forms.Label label3;
    }
}