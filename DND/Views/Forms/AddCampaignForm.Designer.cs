namespace DND.Views.Forms
{
    partial class AddCampaignForm
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
            this.btnCreateCampaign = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDM = new System.Windows.Forms.Label();
            this.txtDM = new System.Windows.Forms.TextBox();
            this.txtCampaignBackground = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCampaign
            // 
            this.btnCreateCampaign.Location = new System.Drawing.Point(428, 138);
            this.btnCreateCampaign.Name = "btnCreateCampaign";
            this.btnCreateCampaign.Size = new System.Drawing.Size(136, 30);
            this.btnCreateCampaign.TabIndex = 3;
            this.btnCreateCampaign.Text = "Create Campaign";
            this.btnCreateCampaign.UseVisualStyleBackColor = true;
            this.btnCreateCampaign.Click += new System.EventHandler(this.btnCreateCampaign_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(80, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(422, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Location = new System.Drawing.Point(3, 39);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(121, 17);
            this.lblDM.TabIndex = 4;
            this.lblDM.Text = "Dungeon Master: ";
            // 
            // txtDM
            // 
            this.txtDM.Location = new System.Drawing.Point(130, 36);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(422, 22);
            this.txtDM.TabIndex = 1;
            // 
            // txtCampaignBackground
            // 
            this.txtCampaignBackground.Location = new System.Drawing.Point(3, 20);
            this.txtCampaignBackground.Multiline = true;
            this.txtCampaignBackground.Name = "txtCampaignBackground";
            this.txtCampaignBackground.Size = new System.Drawing.Size(561, 112);
            this.txtCampaignBackground.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Background";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblDM);
            this.panel1.Controls.Add(this.txtDM);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel1.Size = new System.Drawing.Size(568, 71);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCampaignBackground);
            this.panel2.Controls.Add(this.btnCreateCampaign);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 179);
            this.panel2.TabIndex = 8;
            // 
            // AddCampaignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(595, 284);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddCampaignForm";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "New Campaign";
            this.Load += new System.EventHandler(this.CampaignForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateCampaign;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDM;
        private System.Windows.Forms.TextBox txtDM;
        private System.Windows.Forms.TextBox txtCampaignBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}