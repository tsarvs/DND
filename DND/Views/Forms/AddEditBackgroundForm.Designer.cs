namespace DND.Views.Forms
{
    partial class AddEditBackgroundForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateCharacter
            // 
            this.btnUpdateCharacter.Location = new System.Drawing.Point(302, 478);
            this.btnUpdateCharacter.Name = "btnUpdateCharacter";
            this.btnUpdateCharacter.Size = new System.Drawing.Size(150, 28);
            this.btnUpdateCharacter.TabIndex = 0;
            this.btnUpdateCharacter.Text = "Update Character";
            this.btnUpdateCharacter.UseVisualStyleBackColor = true;
            this.btnUpdateCharacter.Click += new System.EventHandler(this.btnUpdateCharacter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(53, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(399, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 57);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 415);
            this.txtDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // AddEditBackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateCharacter);
            this.Name = "AddEditBackgroundForm";
            this.Text = "Background";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
    }
}