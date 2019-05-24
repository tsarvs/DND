namespace DND.Views.Forms
{
    partial class SpellbookManagerForm
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
            this.btnUpdateCharacter = new System.Windows.Forms.Button();
            this.btnRemoveSpellsFromCharacter = new System.Windows.Forms.Button();
            this.btnAddSpellsToCharacter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCharacterSpells = new System.Windows.Forms.ListBox();
            this.lbSpells = new System.Windows.Forms.ListBox();
            this.txtSpellDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateCharacter
            // 
            this.btnUpdateCharacter.Location = new System.Drawing.Point(432, 817);
            this.btnUpdateCharacter.Name = "btnUpdateCharacter";
            this.btnUpdateCharacter.Size = new System.Drawing.Size(157, 29);
            this.btnUpdateCharacter.TabIndex = 15;
            this.btnUpdateCharacter.Text = "Update Character";
            this.btnUpdateCharacter.UseVisualStyleBackColor = true;
            this.btnUpdateCharacter.Click += new System.EventHandler(this.btnUpdateCharacter_Click);
            // 
            // btnRemoveSpellsFromCharacter
            // 
            this.btnRemoveSpellsFromCharacter.Location = new System.Drawing.Point(264, 212);
            this.btnRemoveSpellsFromCharacter.Name = "btnRemoveSpellsFromCharacter";
            this.btnRemoveSpellsFromCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSpellsFromCharacter.TabIndex = 14;
            this.btnRemoveSpellsFromCharacter.Text = "<-";
            this.btnRemoveSpellsFromCharacter.UseVisualStyleBackColor = true;
            this.btnRemoveSpellsFromCharacter.Click += new System.EventHandler(this.btnRemoveSpellsFromCharacter_Click);
            // 
            // btnAddSpellsToCharacter
            // 
            this.btnAddSpellsToCharacter.Location = new System.Drawing.Point(264, 182);
            this.btnAddSpellsToCharacter.Name = "btnAddSpellsToCharacter";
            this.btnAddSpellsToCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpellsToCharacter.TabIndex = 13;
            this.btnAddSpellsToCharacter.Text = "->";
            this.btnAddSpellsToCharacter.UseVisualStyleBackColor = true;
            this.btnAddSpellsToCharacter.Click += new System.EventHandler(this.btnAddSpellsToCharacter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Character Spells";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Spells";
            // 
            // lbCharacterSpells
            // 
            this.lbCharacterSpells.FormattingEnabled = true;
            this.lbCharacterSpells.ItemHeight = 16;
            this.lbCharacterSpells.Location = new System.Drawing.Point(345, 30);
            this.lbCharacterSpells.Name = "lbCharacterSpells";
            this.lbCharacterSpells.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbCharacterSpells.Size = new System.Drawing.Size(243, 356);
            this.lbCharacterSpells.TabIndex = 10;
            this.lbCharacterSpells.Click += new System.EventHandler(this.lbCharacterSpells_Click);
            this.lbCharacterSpells.SelectedIndexChanged += new System.EventHandler(this.lbCharacterSpells_SelectedIndexChanged);
            // 
            // lbSpells
            // 
            this.lbSpells.FormattingEnabled = true;
            this.lbSpells.ItemHeight = 16;
            this.lbSpells.Location = new System.Drawing.Point(15, 30);
            this.lbSpells.Name = "lbSpells";
            this.lbSpells.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSpells.Size = new System.Drawing.Size(243, 356);
            this.lbSpells.TabIndex = 9;
            this.lbSpells.Click += new System.EventHandler(this.lbSpells_Click);
            this.lbSpells.SelectedIndexChanged += new System.EventHandler(this.lbSpells_SelectedIndexChanged);
            // 
            // txtSpellDescription
            // 
            this.txtSpellDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpellDescription.Location = new System.Drawing.Point(15, 392);
            this.txtSpellDescription.Multiline = true;
            this.txtSpellDescription.Name = "txtSpellDescription";
            this.txtSpellDescription.ReadOnly = true;
            this.txtSpellDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpellDescription.Size = new System.Drawing.Size(573, 419);
            this.txtSpellDescription.TabIndex = 4;
            // 
            // SpellbookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 858);
            this.Controls.Add(this.txtSpellDescription);
            this.Controls.Add(this.btnUpdateCharacter);
            this.Controls.Add(this.btnRemoveSpellsFromCharacter);
            this.Controls.Add(this.btnAddSpellsToCharacter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCharacterSpells);
            this.Controls.Add(this.lbSpells);
            this.Name = "SpellbookManagerForm";
            this.Text = "Spellbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateCharacter;
        private System.Windows.Forms.Button btnRemoveSpellsFromCharacter;
        private System.Windows.Forms.Button btnAddSpellsToCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCharacterSpells;
        private System.Windows.Forms.ListBox lbSpells;
        private System.Windows.Forms.TextBox txtSpellDescription;
    }
}