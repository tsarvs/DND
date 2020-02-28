namespace DND.Views.Forms
{
    partial class AddEditRaceForm
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
            this.cmbRaceSelector = new System.Windows.Forms.ComboBox();
            this.btnAddRace = new System.Windows.Forms.Button();
            this.btnDeleteRace = new System.Windows.Forms.Button();
            this.lblRaceName = new System.Windows.Forms.Label();
            this.txtRaceName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAbilities = new System.Windows.Forms.Label();
            this.txtSTR = new System.Windows.Forms.NumericUpDown();
            this.txtCHA = new System.Windows.Forms.NumericUpDown();
            this.txtWIS = new System.Windows.Forms.NumericUpDown();
            this.txtINT = new System.Windows.Forms.NumericUpDown();
            this.txtCON = new System.Windows.Forms.NumericUpDown();
            this.txtDEX = new System.Windows.Forms.NumericUpDown();
            this.lblSTR = new System.Windows.Forms.Label();
            this.lblDEX = new System.Windows.Forms.Label();
            this.lblCON = new System.Windows.Forms.Label();
            this.lblINT = new System.Windows.Forms.Label();
            this.lblWIS = new System.Windows.Forms.Label();
            this.lblCHA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFeats = new System.Windows.Forms.DataGridView();
            this.lblFeats = new System.Windows.Forms.Label();
            this.txtFeatDescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddFeat = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeats)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRaceSelector
            // 
            this.cmbRaceSelector.FormattingEnabled = true;
            this.cmbRaceSelector.Location = new System.Drawing.Point(12, 12);
            this.cmbRaceSelector.Name = "cmbRaceSelector";
            this.cmbRaceSelector.Size = new System.Drawing.Size(449, 21);
            this.cmbRaceSelector.TabIndex = 0;
            this.cmbRaceSelector.SelectedIndexChanged += new System.EventHandler(this.cmbRaceSelector_SelectedIndexChanged);
            // 
            // btnAddRace
            // 
            this.btnAddRace.Location = new System.Drawing.Point(305, 39);
            this.btnAddRace.Name = "btnAddRace";
            this.btnAddRace.Size = new System.Drawing.Size(75, 23);
            this.btnAddRace.TabIndex = 1;
            this.btnAddRace.Text = "Add Race";
            this.btnAddRace.UseVisualStyleBackColor = true;
            this.btnAddRace.Click += new System.EventHandler(this.btnAddRace_Click);
            // 
            // btnDeleteRace
            // 
            this.btnDeleteRace.Location = new System.Drawing.Point(386, 39);
            this.btnDeleteRace.Name = "btnDeleteRace";
            this.btnDeleteRace.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRace.TabIndex = 2;
            this.btnDeleteRace.Text = "Delete Race";
            this.btnDeleteRace.UseVisualStyleBackColor = true;
            // 
            // lblRaceName
            // 
            this.lblRaceName.AutoSize = true;
            this.lblRaceName.Location = new System.Drawing.Point(12, 70);
            this.lblRaceName.Name = "lblRaceName";
            this.lblRaceName.Size = new System.Drawing.Size(36, 13);
            this.lblRaceName.TabIndex = 3;
            this.lblRaceName.Text = "Race:";
            // 
            // txtRaceName
            // 
            this.txtRaceName.Location = new System.Drawing.Point(12, 86);
            this.txtRaceName.Name = "txtRaceName";
            this.txtRaceName.Size = new System.Drawing.Size(182, 20);
            this.txtRaceName.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 251);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 101);
            this.txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 235);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblAbilities
            // 
            this.lblAbilities.AutoSize = true;
            this.lblAbilities.Location = new System.Drawing.Point(3, 0);
            this.lblAbilities.Name = "lblAbilities";
            this.lblAbilities.Size = new System.Drawing.Size(84, 13);
            this.lblAbilities.TabIndex = 7;
            this.lblAbilities.Text = "Abilitiy Modifiers:";
            // 
            // txtSTR
            // 
            this.txtSTR.Location = new System.Drawing.Point(6, 35);
            this.txtSTR.Name = "txtSTR";
            this.txtSTR.Size = new System.Drawing.Size(38, 20);
            this.txtSTR.TabIndex = 8;
            // 
            // txtCHA
            // 
            this.txtCHA.Location = new System.Drawing.Point(94, 80);
            this.txtCHA.Name = "txtCHA";
            this.txtCHA.Size = new System.Drawing.Size(38, 20);
            this.txtCHA.TabIndex = 9;
            // 
            // txtWIS
            // 
            this.txtWIS.Location = new System.Drawing.Point(50, 80);
            this.txtWIS.Name = "txtWIS";
            this.txtWIS.Size = new System.Drawing.Size(38, 20);
            this.txtWIS.TabIndex = 10;
            // 
            // txtINT
            // 
            this.txtINT.Location = new System.Drawing.Point(6, 80);
            this.txtINT.Name = "txtINT";
            this.txtINT.Size = new System.Drawing.Size(38, 20);
            this.txtINT.TabIndex = 11;
            // 
            // txtCON
            // 
            this.txtCON.Location = new System.Drawing.Point(94, 35);
            this.txtCON.Name = "txtCON";
            this.txtCON.Size = new System.Drawing.Size(38, 20);
            this.txtCON.TabIndex = 12;
            // 
            // txtDEX
            // 
            this.txtDEX.Location = new System.Drawing.Point(50, 35);
            this.txtDEX.Name = "txtDEX";
            this.txtDEX.Size = new System.Drawing.Size(38, 20);
            this.txtDEX.TabIndex = 13;
            // 
            // lblSTR
            // 
            this.lblSTR.AutoSize = true;
            this.lblSTR.Location = new System.Drawing.Point(3, 20);
            this.lblSTR.Name = "lblSTR";
            this.lblSTR.Size = new System.Drawing.Size(29, 13);
            this.lblSTR.TabIndex = 14;
            this.lblSTR.Text = "STR";
            // 
            // lblDEX
            // 
            this.lblDEX.AutoSize = true;
            this.lblDEX.Location = new System.Drawing.Point(47, 20);
            this.lblDEX.Name = "lblDEX";
            this.lblDEX.Size = new System.Drawing.Size(29, 13);
            this.lblDEX.TabIndex = 15;
            this.lblDEX.Text = "DEX";
            // 
            // lblCON
            // 
            this.lblCON.AutoSize = true;
            this.lblCON.Location = new System.Drawing.Point(91, 20);
            this.lblCON.Name = "lblCON";
            this.lblCON.Size = new System.Drawing.Size(30, 13);
            this.lblCON.TabIndex = 16;
            this.lblCON.Text = "CON";
            // 
            // lblINT
            // 
            this.lblINT.AutoSize = true;
            this.lblINT.Location = new System.Drawing.Point(3, 64);
            this.lblINT.Name = "lblINT";
            this.lblINT.Size = new System.Drawing.Size(25, 13);
            this.lblINT.TabIndex = 17;
            this.lblINT.Text = "INT";
            // 
            // lblWIS
            // 
            this.lblWIS.AutoSize = true;
            this.lblWIS.Location = new System.Drawing.Point(50, 64);
            this.lblWIS.Name = "lblWIS";
            this.lblWIS.Size = new System.Drawing.Size(28, 13);
            this.lblWIS.TabIndex = 18;
            this.lblWIS.Text = "WIS";
            // 
            // lblCHA
            // 
            this.lblCHA.AutoSize = true;
            this.lblCHA.Location = new System.Drawing.Point(94, 64);
            this.lblCHA.Name = "lblCHA";
            this.lblCHA.Size = new System.Drawing.Size(29, 13);
            this.lblCHA.TabIndex = 19;
            this.lblCHA.Text = "CHA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSTR);
            this.panel1.Controls.Add(this.lblCHA);
            this.panel1.Controls.Add(this.txtSTR);
            this.panel1.Controls.Add(this.lblAbilities);
            this.panel1.Controls.Add(this.lblWIS);
            this.panel1.Controls.Add(this.txtCHA);
            this.panel1.Controls.Add(this.lblINT);
            this.panel1.Controls.Add(this.txtWIS);
            this.panel1.Controls.Add(this.lblCON);
            this.panel1.Controls.Add(this.txtINT);
            this.panel1.Controls.Add(this.lblDEX);
            this.panel1.Controls.Add(this.txtCON);
            this.panel1.Controls.Add(this.txtDEX);
            this.panel1.Location = new System.Drawing.Point(12, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 110);
            this.panel1.TabIndex = 20;
            // 
            // dgvFeats
            // 
            this.dgvFeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeats.Location = new System.Drawing.Point(11, 16);
            this.dgvFeats.Name = "dgvFeats";
            this.dgvFeats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFeats.Size = new System.Drawing.Size(240, 159);
            this.dgvFeats.TabIndex = 21;
            // 
            // lblFeats
            // 
            this.lblFeats.AutoSize = true;
            this.lblFeats.Location = new System.Drawing.Point(8, 2);
            this.lblFeats.Name = "lblFeats";
            this.lblFeats.Size = new System.Drawing.Size(36, 13);
            this.lblFeats.TabIndex = 22;
            this.lblFeats.Text = "Feats:";
            // 
            // txtFeatDescription
            // 
            this.txtFeatDescription.Location = new System.Drawing.Point(11, 181);
            this.txtFeatDescription.Multiline = true;
            this.txtFeatDescription.Name = "txtFeatDescription";
            this.txtFeatDescription.ReadOnly = true;
            this.txtFeatDescription.Size = new System.Drawing.Size(240, 72);
            this.txtFeatDescription.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddFeat);
            this.panel2.Controls.Add(this.txtFeatDescription);
            this.panel2.Controls.Add(this.lblFeats);
            this.panel2.Controls.Add(this.dgvFeats);
            this.panel2.Location = new System.Drawing.Point(200, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 287);
            this.panel2.TabIndex = 24;
            // 
            // btnAddFeat
            // 
            this.btnAddFeat.Location = new System.Drawing.Point(193, 259);
            this.btnAddFeat.Name = "btnAddFeat";
            this.btnAddFeat.Size = new System.Drawing.Size(58, 23);
            this.btnAddFeat.TabIndex = 24;
            this.btnAddFeat.Text = "Add Feat";
            this.btnAddFeat.UseVisualStyleBackColor = true;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(350, 363);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(111, 23);
            this.btnSaveClose.TabIndex = 25;
            this.btnSaveClose.Text = "Save and Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            // 
            // AddEditRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 394);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtRaceName);
            this.Controls.Add(this.lblRaceName);
            this.Controls.Add(this.btnDeleteRace);
            this.Controls.Add(this.btnAddRace);
            this.Controls.Add(this.cmbRaceSelector);
            this.Name = "AddEditRaceForm";
            this.Text = "AddEditRaceForm";
            this.Load += new System.EventHandler(this.AddEditRaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeats)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRaceSelector;
        private System.Windows.Forms.Button btnAddRace;
        private System.Windows.Forms.Button btnDeleteRace;
        private System.Windows.Forms.Label lblRaceName;
        private System.Windows.Forms.TextBox txtRaceName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAbilities;
        private System.Windows.Forms.NumericUpDown txtSTR;
        private System.Windows.Forms.NumericUpDown txtCHA;
        private System.Windows.Forms.NumericUpDown txtWIS;
        private System.Windows.Forms.NumericUpDown txtINT;
        private System.Windows.Forms.NumericUpDown txtCON;
        private System.Windows.Forms.NumericUpDown txtDEX;
        private System.Windows.Forms.Label lblSTR;
        private System.Windows.Forms.Label lblDEX;
        private System.Windows.Forms.Label lblCON;
        private System.Windows.Forms.Label lblINT;
        private System.Windows.Forms.Label lblWIS;
        private System.Windows.Forms.Label lblCHA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFeats;
        private System.Windows.Forms.Label lblFeats;
        private System.Windows.Forms.TextBox txtFeatDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddFeat;
        private System.Windows.Forms.Button btnSaveClose;
    }
}