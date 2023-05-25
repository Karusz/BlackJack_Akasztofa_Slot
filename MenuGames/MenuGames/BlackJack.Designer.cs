namespace MenuGames
{
    partial class BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.háttérToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limebg = new System.Windows.Forms.ToolStripMenuItem();
            this.redbg = new System.Windows.Forms.ToolStripMenuItem();
            this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.betting = new System.Windows.Forms.Button();
            this.bet = new System.Windows.Forms.TextBox();
            this.buttonpanel = new System.Windows.Forms.Panel();
            this.getbank = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.newcard = new System.Windows.Forms.Button();
            this.split = new System.Windows.Forms.Button();
            this.losebet = new System.Windows.Forms.Label();
            this.losepont = new System.Windows.Forms.Label();
            this.winbet = new System.Windows.Forms.Label();
            this.winpont = new System.Windows.Forms.Label();
            this.chips = new System.Windows.Forms.Label();
            this.nowbet = new System.Windows.Forms.Label();
            this.cardspanel = new System.Windows.Forms.Panel();
            this.dealernewcardpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dc1 = new System.Windows.Forms.PictureBox();
            this.pcnewcardpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cardback = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dealerponts = new System.Windows.Forms.Label();
            this.playerpoint = new System.Windows.Forms.Label();
            this.dc2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.buttonpanel.SuspendLayout();
            this.cardspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállításokToolStripMenuItem,
            this.segítségToolStripMenuItem,
            this.backmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.háttérToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // háttérToolStripMenuItem
            // 
            this.háttérToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limebg,
            this.redbg});
            this.háttérToolStripMenuItem.Name = "háttérToolStripMenuItem";
            this.háttérToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.háttérToolStripMenuItem.Text = "Háttér";
            // 
            // limebg
            // 
            this.limebg.Name = "limebg";
            this.limebg.Size = new System.Drawing.Size(124, 26);
            this.limebg.Text = "Lime";
            this.limebg.Click += new System.EventHandler(this.limebg_Click);
            // 
            // redbg
            // 
            this.redbg.Name = "redbg";
            this.redbg.Size = new System.Drawing.Size(124, 26);
            this.redbg.Text = "Piros";
            this.redbg.Click += new System.EventHandler(this.redbg_Click);
            // 
            // segítségToolStripMenuItem
            // 
            this.segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
            this.segítségToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.segítségToolStripMenuItem.Text = "Segítség";
            this.segítségToolStripMenuItem.Click += new System.EventHandler(this.segítségToolStripMenuItem_Click);
            // 
            // backmenu
            // 
            this.backmenu.Name = "backmenu";
            this.backmenu.Size = new System.Drawing.Size(133, 24);
            this.backmenu.Text = "Vissza a menübe";
            this.backmenu.Click += new System.EventHandler(this.backmenu_Click);
            // 
            // betting
            // 
            this.betting.Location = new System.Drawing.Point(124, 452);
            this.betting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betting.Name = "betting";
            this.betting.Size = new System.Drawing.Size(139, 39);
            this.betting.TabIndex = 6;
            this.betting.Text = "Tétrakás";
            this.betting.UseVisualStyleBackColor = true;
            this.betting.Click += new System.EventHandler(this.betting_Click);
            // 
            // bet
            // 
            this.bet.Location = new System.Drawing.Point(99, 420);
            this.bet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(191, 22);
            this.bet.TabIndex = 5;
            this.bet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bet_KeyDown);
            // 
            // buttonpanel
            // 
            this.buttonpanel.Controls.Add(this.getbank);
            this.buttonpanel.Controls.Add(this.stop);
            this.buttonpanel.Controls.Add(this.newcard);
            this.buttonpanel.Controls.Add(this.split);
            this.buttonpanel.Controls.Add(this.losebet);
            this.buttonpanel.Controls.Add(this.losepont);
            this.buttonpanel.Controls.Add(this.winbet);
            this.buttonpanel.Controls.Add(this.winpont);
            this.buttonpanel.Controls.Add(this.chips);
            this.buttonpanel.Controls.Add(this.nowbet);
            this.buttonpanel.Controls.Add(this.bet);
            this.buttonpanel.Controls.Add(this.betting);
            this.buttonpanel.Location = new System.Drawing.Point(700, 33);
            this.buttonpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(367, 519);
            this.buttonpanel.TabIndex = 7;
            // 
            // getbank
            // 
            this.getbank.Location = new System.Drawing.Point(257, 4);
            this.getbank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getbank.Name = "getbank";
            this.getbank.Size = new System.Drawing.Size(107, 34);
            this.getbank.TabIndex = 26;
            this.getbank.Text = "+1000 zseton";
            this.getbank.UseVisualStyleBackColor = true;
            this.getbank.Click += new System.EventHandler(this.getbank_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(128, 359);
            this.stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(123, 34);
            this.stop.TabIndex = 25;
            this.stop.Text = "Megáll";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // newcard
            // 
            this.newcard.Location = new System.Drawing.Point(229, 302);
            this.newcard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newcard.Name = "newcard";
            this.newcard.Size = new System.Drawing.Size(123, 34);
            this.newcard.TabIndex = 24;
            this.newcard.Text = "Újlap";
            this.newcard.UseVisualStyleBackColor = true;
            this.newcard.Click += new System.EventHandler(this.newcard_Click);
            // 
            // split
            // 
            this.split.Location = new System.Drawing.Point(23, 302);
            this.split.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(123, 34);
            this.split.TabIndex = 23;
            this.split.Text = "Split";
            this.split.UseVisualStyleBackColor = true;
            this.split.Click += new System.EventHandler(this.split_Click);
            // 
            // losebet
            // 
            this.losebet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.losebet.Location = new System.Drawing.Point(151, 75);
            this.losebet.Name = "losebet";
            this.losebet.Size = new System.Drawing.Size(112, 34);
            this.losebet.TabIndex = 22;
            this.losebet.Text = "0";
            // 
            // losepont
            // 
            this.losepont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.losepont.Location = new System.Drawing.Point(3, 75);
            this.losepont.Name = "losepont";
            this.losepont.Size = new System.Drawing.Size(143, 34);
            this.losepont.TabIndex = 21;
            this.losepont.Text = "Veszteség:";
            // 
            // winbet
            // 
            this.winbet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winbet.Location = new System.Drawing.Point(151, 41);
            this.winbet.Name = "winbet";
            this.winbet.Size = new System.Drawing.Size(112, 34);
            this.winbet.TabIndex = 20;
            this.winbet.Text = "0";
            // 
            // winpont
            // 
            this.winpont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winpont.Location = new System.Drawing.Point(3, 41);
            this.winpont.Name = "winpont";
            this.winpont.Size = new System.Drawing.Size(143, 34);
            this.winpont.TabIndex = 19;
            this.winpont.Text = "Nyeremény:";
            // 
            // chips
            // 
            this.chips.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chips.Location = new System.Drawing.Point(139, 6);
            this.chips.Name = "chips";
            this.chips.Size = new System.Drawing.Size(112, 34);
            this.chips.TabIndex = 18;
            this.chips.Text = "1000";
            // 
            // nowbet
            // 
            this.nowbet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowbet.Location = new System.Drawing.Point(3, 6);
            this.nowbet.Name = "nowbet";
            this.nowbet.Size = new System.Drawing.Size(123, 34);
            this.nowbet.TabIndex = 17;
            this.nowbet.Text = "Zsetonjaid:";
            // 
            // cardspanel
            // 
            this.cardspanel.Controls.Add(this.dealernewcardpanel);
            this.cardspanel.Controls.Add(this.dc1);
            this.cardspanel.Controls.Add(this.pcnewcardpanel);
            this.cardspanel.Controls.Add(this.cardback);
            this.cardspanel.Controls.Add(this.pc1);
            this.cardspanel.Controls.Add(this.pc2);
            this.cardspanel.Controls.Add(this.label1);
            this.cardspanel.Controls.Add(this.dealerponts);
            this.cardspanel.Controls.Add(this.playerpoint);
            this.cardspanel.Controls.Add(this.dc2);
            this.cardspanel.Location = new System.Drawing.Point(0, 33);
            this.cardspanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardspanel.Name = "cardspanel";
            this.cardspanel.Size = new System.Drawing.Size(701, 519);
            this.cardspanel.TabIndex = 7;
            // 
            // dealernewcardpanel
            // 
            this.dealernewcardpanel.Location = new System.Drawing.Point(237, 34);
            this.dealernewcardpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealernewcardpanel.Name = "dealernewcardpanel";
            this.dealernewcardpanel.Size = new System.Drawing.Size(293, 118);
            this.dealernewcardpanel.TabIndex = 20;
            // 
            // dc1
            // 
            this.dc1.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.dc1.Location = new System.Drawing.Point(19, 34);
            this.dc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dc1.Name = "dc1";
            this.dc1.Size = new System.Drawing.Size(95, 117);
            this.dc1.TabIndex = 0;
            this.dc1.TabStop = false;
            // 
            // pcnewcardpanel
            // 
            this.pcnewcardpanel.Location = new System.Drawing.Point(237, 386);
            this.pcnewcardpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcnewcardpanel.Name = "pcnewcardpanel";
            this.pcnewcardpanel.Size = new System.Drawing.Size(293, 118);
            this.pcnewcardpanel.TabIndex = 19;
            // 
            // cardback
            // 
            this.cardback.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.cardback.Location = new System.Drawing.Point(121, 34);
            this.cardback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardback.Name = "cardback";
            this.cardback.Size = new System.Drawing.Size(95, 117);
            this.cardback.TabIndex = 4;
            this.cardback.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.pc1.Location = new System.Drawing.Point(19, 389);
            this.pc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(95, 117);
            this.pc1.TabIndex = 2;
            this.pc1.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.pc2.Location = new System.Drawing.Point(121, 389);
            this.pc2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(95, 117);
            this.pc2.TabIndex = 3;
            this.pc2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(539, 431);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Points:";
            // 
            // dealerponts
            // 
            this.dealerponts.AutoSize = true;
            this.dealerponts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dealerponts.Location = new System.Drawing.Point(617, 64);
            this.dealerponts.Name = "dealerponts";
            this.dealerponts.Size = new System.Drawing.Size(32, 32);
            this.dealerponts.TabIndex = 17;
            this.dealerponts.Text = "0";
            // 
            // playerpoint
            // 
            this.playerpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerpoint.Location = new System.Drawing.Point(616, 425);
            this.playerpoint.Name = "playerpoint";
            this.playerpoint.Size = new System.Drawing.Size(61, 34);
            this.playerpoint.TabIndex = 14;
            this.playerpoint.Text = "0";
            // 
            // dc2
            // 
            this.dc2.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.dc2.Location = new System.Drawing.Point(121, 34);
            this.dc2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dc2.Name = "dc2";
            this.dc2.Size = new System.Drawing.Size(95, 117);
            this.dc2.TabIndex = 1;
            this.dc2.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cardspanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.buttonpanel.ResumeLayout(false);
            this.buttonpanel.PerformLayout();
            this.cardspanel.ResumeLayout(false);
            this.cardspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem háttérToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limebg;
        private System.Windows.Forms.ToolStripMenuItem redbg;
        private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
        private System.Windows.Forms.Button betting;
        public System.Windows.Forms.TextBox bet;
        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Panel cardspanel;
        private System.Windows.Forms.ToolStripMenuItem backmenu;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button newcard;
        private System.Windows.Forms.Button split;
        public System.Windows.Forms.Label losebet;
        public System.Windows.Forms.Label losepont;
        public System.Windows.Forms.Label winbet;
        public System.Windows.Forms.Label winpont;
        public System.Windows.Forms.Label chips;
        public System.Windows.Forms.Label nowbet;
        private System.Windows.Forms.PictureBox dc1;
        private System.Windows.Forms.PictureBox cardback;
        private System.Windows.Forms.PictureBox dc2;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        public System.Windows.Forms.Label playerpoint;
        private System.Windows.Forms.Label dealerponts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pcnewcardpanel;
        private System.Windows.Forms.FlowLayoutPanel dealernewcardpanel;
        private System.Windows.Forms.Button getbank;
    }
}