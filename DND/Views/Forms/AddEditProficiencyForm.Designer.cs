namespace DND.Views.Forms
{
    partial class AddEditProficiencyForm
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
            this.cmbProficiencyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProficiencyName = new System.Windows.Forms.TextBox();
            this.btnUpdateCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProficiencyType
            // 
            this.cmbProficiencyType.FormattingEnabled = true;
            this.cmbProficiencyType.Items.AddRange(new object[] {
            "Armor",
            "Language",
            "Saving Throw",
            "Skill",
            "Tool",
            "Weapon",
            "Other"});
            this.cmbProficiencyType.Location = new System.Drawing.Point(130, 12);
            this.cmbProficiencyType.Name = "cmbProficiencyType";
            this.cmbProficiencyType.Size = new System.Drawing.Size(199, 24);
            this.cmbProficiencyType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proficiency Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proficiency Name";
            // 
            // txtProficiencyName
            // 
            this.txtProficiencyName.Location = new System.Drawing.Point(130, 42);
            this.txtProficiencyName.Name = "txtProficiencyName";
            this.txtProficiencyName.Size = new System.Drawing.Size(199, 22);
            this.txtProficiencyName.TabIndex = 3;
            // 
            // btnUpdateCharacter
            // 
            this.btnUpdateCharacter.Location = new System.Drawing.Point(181, 70);
            this.btnUpdateCharacter.Name = "btnUpdateCharacter";
            this.btnUpdateCharacter.Size = new System.Drawing.Size(148, 23);
            this.btnUpdateCharacter.TabIndex = 4;
            this.btnUpdateCharacter.Text = "Update Character";
            this.btnUpdateCharacter.UseVisualStyleBackColor = true;
            this.btnUpdateCharacter.Click += new System.EventHandler(this.btnUpdateCharacter_Click);
            // 
            // AddEditProficiencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 107);
            this.Controls.Add(this.btnUpdateCharacter);
            this.Controls.Add(this.txtProficiencyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProficiencyType);
            this.Name = "AddEditProficiencyForm";
            this.Text = "Proficiency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProficiencyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProficiencyName;
        private System.Windows.Forms.Button btnUpdateCharacter;
    }
}