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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.háttérToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limebg = new System.Windows.Forms.ToolStripMenuItem();
            this.greenbg = new System.Windows.Forms.ToolStripMenuItem();
            this.redbg = new System.Windows.Forms.ToolStripMenuItem();
            this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betting = new System.Windows.Forms.Button();
            this.bet = new System.Windows.Forms.TextBox();
            this.buttonpanel = new System.Windows.Forms.Panel();
            this.cardspanel = new System.Windows.Forms.Panel();
            this.dc1 = new System.Windows.Forms.PictureBox();
            this.dc2 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.buttonpanel.SuspendLayout();
            this.cardspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállításokToolStripMenuItem,
            this.segítségToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.háttérToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // háttérToolStripMenuItem
            // 
            this.háttérToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limebg,
            this.greenbg,
            this.redbg});
            this.háttérToolStripMenuItem.Name = "háttérToolStripMenuItem";
            this.háttérToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.háttérToolStripMenuItem.Text = "Háttér";
            // 
            // limebg
            // 
            this.limebg.Name = "limebg";
            this.limebg.Size = new System.Drawing.Size(100, 22);
            this.limebg.Text = "Lime";
            this.limebg.Click += new System.EventHandler(this.limebg_Click);
            // 
            // greenbg
            // 
            this.greenbg.Name = "greenbg";
            this.greenbg.Size = new System.Drawing.Size(100, 22);
            this.greenbg.Text = "Zöld";
            this.greenbg.Click += new System.EventHandler(this.greenbg_Click);
            // 
            // redbg
            // 
            this.redbg.Name = "redbg";
            this.redbg.Size = new System.Drawing.Size(100, 22);
            this.redbg.Text = "Piros";
            this.redbg.Click += new System.EventHandler(this.redbg_Click);
            // 
            // segítségToolStripMenuItem
            // 
            this.segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
            this.segítségToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.segítségToolStripMenuItem.Text = "Segítség";
            this.segítségToolStripMenuItem.Click += new System.EventHandler(this.segítségToolStripMenuItem_Click);
            // 
            // betting
            // 
            this.betting.Location = new System.Drawing.Point(109, 367);
            this.betting.Name = "betting";
            this.betting.Size = new System.Drawing.Size(104, 32);
            this.betting.TabIndex = 6;
            this.betting.Text = "Tétrakás";
            this.betting.UseVisualStyleBackColor = true;
            this.betting.Click += new System.EventHandler(this.betting_Click);
            // 
            // bet
            // 
            this.bet.Location = new System.Drawing.Point(87, 328);
            this.bet.Multiline = true;
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(144, 33);
            this.bet.TabIndex = 5;
            // 
            // buttonpanel
            // 
            this.buttonpanel.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.buttonpanel.Controls.Add(this.bet);
            this.buttonpanel.Controls.Add(this.betting);
            this.buttonpanel.Location = new System.Drawing.Point(525, 27);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(275, 422);
            this.buttonpanel.TabIndex = 7;
            // 
            // cardspanel
            // 
            this.cardspanel.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.cardspanel.Controls.Add(this.pc2);
            this.cardspanel.Controls.Add(this.pc1);
            this.cardspanel.Controls.Add(this.dc2);
            this.cardspanel.Controls.Add(this.dc1);
            this.cardspanel.Location = new System.Drawing.Point(0, 27);
            this.cardspanel.Name = "cardspanel";
            this.cardspanel.Size = new System.Drawing.Size(526, 422);
            this.cardspanel.TabIndex = 7;
            // 
            // dc1
            // 
            this.dc1.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.dc1.Location = new System.Drawing.Point(47, 46);
            this.dc1.Name = "dc1";
            this.dc1.Size = new System.Drawing.Size(98, 125);
            this.dc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dc1.TabIndex = 0;
            this.dc1.TabStop = false;
            // 
            // dc2
            // 
            this.dc2.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.dc2.Location = new System.Drawing.Point(151, 46);
            this.dc2.Name = "dc2";
            this.dc2.Size = new System.Drawing.Size(98, 125);
            this.dc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dc2.TabIndex = 1;
            this.dc2.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.pc1.Location = new System.Drawing.Point(47, 274);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(98, 125);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc1.TabIndex = 2;
            this.pc1.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.pc2.Location = new System.Drawing.Point(151, 274);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(98, 125);
            this.pc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc2.TabIndex = 3;
            this.pc2.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuGames.Properties.Resources.sajatbg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardspanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonpanel);
            this.MainMenuStrip = this.menuStrip1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem háttérToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limebg;
        private System.Windows.Forms.ToolStripMenuItem greenbg;
        private System.Windows.Forms.ToolStripMenuItem redbg;
        private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
        private System.Windows.Forms.Button betting;
        public System.Windows.Forms.TextBox bet;
        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Panel cardspanel;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox dc2;
        private System.Windows.Forms.PictureBox dc1;
    }
}