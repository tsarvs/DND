namespace DND.Views.Forms
{
    partial class CharacterJournalForm
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
            this.txtJournalBody = new System.Windows.Forms.TextBox();
            this.btnPrevEntry = new System.Windows.Forms.Button();
            this.btnNextEntry = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJournalBody
            // 
            this.txtJournalBody.Location = new System.Drawing.Point(12, 12);
            this.txtJournalBody.Multiline = true;
            this.txtJournalBody.Name = "txtJournalBody";
            this.txtJournalBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJournalBody.Size = new System.Drawing.Size(424, 262);
            this.txtJournalBody.TabIndex = 0;
            // 
            // btnPrevEntry
            // 
            this.btnPrevEntry.Location = new System.Drawing.Point(12, 280);
            this.btnPrevEntry.Name = "btnPrevEntry";
            this.btnPrevEntry.Size = new System.Drawing.Size(98, 23);
            this.btnPrevEntry.TabIndex = 1;
            this.btnPrevEntry.Text = "← Previous Page";
            this.btnPrevEntry.UseVisualStyleBackColor = true;
            // 
            // btnNextEntry
            // 
            this.btnNextEntry.Location = new System.Drawing.Point(338, 280);
            this.btnNextEntry.Name = "btnNextEntry";
            this.btnNextEntry.Size = new System.Drawing.Size(98, 23);
            this.btnNextEntry.TabIndex = 2;
            this.btnNextEntry.Text = "Next Page →";
            this.btnNextEntry.UseVisualStyleBackColor = true;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(204, 290);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(42, 13);
            this.lblPageNumber.TabIndex = 3;
            this.lblPageNumber.Text = "Page #";
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(240, 306);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(79, 23);
            this.btnDeleteEntry.TabIndex = 4;
            this.btnDeleteEntry.Text = "- Delete Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(128, 306);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(80, 23);
            this.btnAddEntry.TabIndex = 5;
            this.btnAddEntry.Text = "+ Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            // 
            // CharacterJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 340);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNextEntry);
            this.Controls.Add(this.btnPrevEntry);
            this.Controls.Add(this.txtJournalBody);
            this.Name = "CharacterJournalForm";
            this.Text = "CharacterJournalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJournalBody;
        private System.Windows.Forms.Button btnPrevEntry;
        private System.Windows.Forms.Button btnNextEntry;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Button btnAddEntry;
    }
}