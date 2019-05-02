namespace DND.Views.Forms
{
    partial class LoadCharacterSheetForm
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
            this.dgvCharacters = new System.Windows.Forms.DataGridView();
            this.btnLoadCharacterSheet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCharacters
            // 
            this.dgvCharacters.AllowUserToResizeColumns = false;
            this.dgvCharacters.AllowUserToResizeRows = false;
            this.dgvCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacters.Location = new System.Drawing.Point(12, 12);
            this.dgvCharacters.MultiSelect = false;
            this.dgvCharacters.Name = "dgvCharacters";
            this.dgvCharacters.RowHeadersVisible = false;
            this.dgvCharacters.RowTemplate.Height = 24;
            this.dgvCharacters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCharacters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCharacters.Size = new System.Drawing.Size(363, 150);
            this.dgvCharacters.TabIndex = 0;
            // 
            // btnLoadCharacterSheet
            // 
            this.btnLoadCharacterSheet.Location = new System.Drawing.Point(300, 168);
            this.btnLoadCharacterSheet.Name = "btnLoadCharacterSheet";
            this.btnLoadCharacterSheet.Size = new System.Drawing.Size(75, 27);
            this.btnLoadCharacterSheet.TabIndex = 1;
            this.btnLoadCharacterSheet.Text = "Load";
            this.btnLoadCharacterSheet.UseVisualStyleBackColor = true;
            this.btnLoadCharacterSheet.Click += new System.EventHandler(this.btnLoadCharacterSheet_Click);
            // 
            // LoadCharacterSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 203);
            this.Controls.Add(this.btnLoadCharacterSheet);
            this.Controls.Add(this.dgvCharacters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoadCharacterSheetForm";
            this.Text = "Load Character Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCharacters;
        private System.Windows.Forms.Button btnLoadCharacterSheet;
    }
}