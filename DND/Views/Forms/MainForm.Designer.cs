namespace DND.Views.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterSheetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceRollerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaveyardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungeonMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campaignManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.episodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEncounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageQuestlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spellToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.dungeonMasterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campaignToolStripMenuItem,
            this.connectToDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // campaignToolStripMenuItem
            // 
            this.campaignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCampaignToolStripMenuItem,
            this.newCampaignToolStripMenuItem});
            this.campaignToolStripMenuItem.Name = "campaignToolStripMenuItem";
            this.campaignToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.campaignToolStripMenuItem.Text = "Campaign";
            // 
            // loadCampaignToolStripMenuItem
            // 
            this.loadCampaignToolStripMenuItem.Name = "loadCampaignToolStripMenuItem";
            this.loadCampaignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadCampaignToolStripMenuItem.Text = "Load Campaign";
            this.loadCampaignToolStripMenuItem.Click += new System.EventHandler(this.loadCampaignToolStripMenuItem_Click);
            // 
            // newCampaignToolStripMenuItem
            // 
            this.newCampaignToolStripMenuItem.Name = "newCampaignToolStripMenuItem";
            this.newCampaignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newCampaignToolStripMenuItem.Text = "New Campaign";
            this.newCampaignToolStripMenuItem.Click += new System.EventHandler(this.newCampaignToolStripMenuItem_Click);
            // 
            // connectToDatabaseToolStripMenuItem
            // 
            this.connectToDatabaseToolStripMenuItem.Name = "connectToDatabaseToolStripMenuItem";
            this.connectToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.connectToDatabaseToolStripMenuItem.Text = "Connect to Database";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterSheetToolStripMenuItem1,
            this.diceRollerToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.gaveyardToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // characterSheetToolStripMenuItem1
            // 
            this.characterSheetToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCharacterToolStripMenuItem,
            this.newCharacterToolStripMenuItem});
            this.characterSheetToolStripMenuItem1.Name = "characterSheetToolStripMenuItem1";
            this.characterSheetToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.characterSheetToolStripMenuItem1.Text = "Character Sheet";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loadCharacterToolStripMenuItem.Text = "Load Character";
            this.loadCharacterToolStripMenuItem.Click += new System.EventHandler(this.loadCharacterToolStripMenuItem_Click);
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // diceRollerToolStripMenuItem
            // 
            this.diceRollerToolStripMenuItem.Name = "diceRollerToolStripMenuItem";
            this.diceRollerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.diceRollerToolStripMenuItem.Text = "Dice Roller";
            this.diceRollerToolStripMenuItem.Click += new System.EventHandler(this.diceRollerToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.notepadToolStripMenuItem.Text = "Journal";
            // 
            // gaveyardToolStripMenuItem
            // 
            this.gaveyardToolStripMenuItem.Name = "gaveyardToolStripMenuItem";
            this.gaveyardToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gaveyardToolStripMenuItem.Text = "Graveyard";
            // 
            // dungeonMasterToolStripMenuItem
            // 
            this.dungeonMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campaignManagerToolStripMenuItem,
            this.createToolStripMenuItem1});
            this.dungeonMasterToolStripMenuItem.Name = "dungeonMasterToolStripMenuItem";
            this.dungeonMasterToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.dungeonMasterToolStripMenuItem.Text = "Dungeon Master";
            // 
            // campaignManagerToolStripMenuItem
            // 
            this.campaignManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.episodeToolStripMenuItem,
            this.manageTiToolStripMenuItem,
            this.managePartyToolStripMenuItem,
            this.manageQuestlinesToolStripMenuItem,
            this.manageLocationsToolStripMenuItem});
            this.campaignManagerToolStripMenuItem.Name = "campaignManagerToolStripMenuItem";
            this.campaignManagerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.campaignManagerToolStripMenuItem.Text = "Manage Campaign";
            // 
            // episodeToolStripMenuItem
            // 
            this.episodeToolStripMenuItem.Name = "episodeToolStripMenuItem";
            this.episodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.episodeToolStripMenuItem.Text = "Game Sessions";
            // 
            // manageTiToolStripMenuItem
            // 
            this.manageTiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEncounterToolStripMenuItem});
            this.manageTiToolStripMenuItem.Name = "manageTiToolStripMenuItem";
            this.manageTiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageTiToolStripMenuItem.Text = "Timeline";
            // 
            // addEncounterToolStripMenuItem
            // 
            this.addEncounterToolStripMenuItem.Name = "addEncounterToolStripMenuItem";
            this.addEncounterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addEncounterToolStripMenuItem.Text = "Add Encounter";
            // 
            // managePartyToolStripMenuItem
            // 
            this.managePartyToolStripMenuItem.Name = "managePartyToolStripMenuItem";
            this.managePartyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.managePartyToolStripMenuItem.Text = "Party";
            // 
            // manageQuestlinesToolStripMenuItem
            // 
            this.manageQuestlinesToolStripMenuItem.Name = "manageQuestlinesToolStripMenuItem";
            this.manageQuestlinesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageQuestlinesToolStripMenuItem.Text = "Questlines";
            // 
            // manageLocationsToolStripMenuItem
            // 
            this.manageLocationsToolStripMenuItem.Name = "manageLocationsToolStripMenuItem";
            this.manageLocationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageLocationsToolStripMenuItem.Text = "Locations";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterToolStripMenuItem,
            this.raceToolStripMenuItem,
            this.classToolStripMenuItem,
            this.itemToolStripMenuItem1,
            this.spellToolStripMenuItem1});
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.createToolStripMenuItem1.Text = "Add/Edit...";
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCharacterToolStripMenuItem1,
            this.newCharacterToolStripMenuItem1});
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.characterToolStripMenuItem.Text = "Character";
            // 
            // loadCharacterToolStripMenuItem1
            // 
            this.loadCharacterToolStripMenuItem1.Name = "loadCharacterToolStripMenuItem1";
            this.loadCharacterToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.loadCharacterToolStripMenuItem1.Text = "Load Character";
            // 
            // newCharacterToolStripMenuItem1
            // 
            this.newCharacterToolStripMenuItem1.Name = "newCharacterToolStripMenuItem1";
            this.newCharacterToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.newCharacterToolStripMenuItem1.Text = "New Character";
            // 
            // raceToolStripMenuItem
            // 
            this.raceToolStripMenuItem.Name = "raceToolStripMenuItem";
            this.raceToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.raceToolStripMenuItem.Text = "Race";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.classToolStripMenuItem.Text = "Class";
            // 
            // itemToolStripMenuItem1
            // 
            this.itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            this.itemToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.itemToolStripMenuItem1.Text = "Item";
            // 
            // spellToolStripMenuItem1
            // 
            this.spellToolStripMenuItem1.Name = "spellToolStripMenuItem1";
            this.spellToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.spellToolStripMenuItem1.Text = "Spell";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DND.Properties.Resources.pixel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 379);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Data N\' Dragons";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterSheetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceRollerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungeonMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campaignManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageQuestlinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spellToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gaveyardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem episodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEncounterToolStripMenuItem;
    }
}