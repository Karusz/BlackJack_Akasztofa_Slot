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
            this.bet = new System.Windows.Forms.TextBox();
            this.betting = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.limebg.Size = new System.Drawing.Size(180, 22);
            this.limebg.Text = "Lime";
            this.limebg.Click += new System.EventHandler(this.limebg_Click);
            // 
            // greenbg
            // 
            this.greenbg.Name = "greenbg";
            this.greenbg.Size = new System.Drawing.Size(180, 22);
            this.greenbg.Text = "Zöld";
            this.greenbg.Click += new System.EventHandler(this.greenbg_Click);
            // 
            // redbg
            // 
            this.redbg.Name = "redbg";
            this.redbg.Size = new System.Drawing.Size(180, 22);
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
            // bet
            // 
            this.bet.Location = new System.Drawing.Point(644, 342);
            this.bet.Multiline = true;
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(144, 33);
            this.bet.TabIndex = 1;
            // 
            // betting
            // 
            this.betting.Location = new System.Drawing.Point(667, 393);
            this.betting.Name = "betting";
            this.betting.Size = new System.Drawing.Size(104, 45);
            this.betting.TabIndex = 2;
            this.betting.Text = "Tétrakás";
            this.betting.UseVisualStyleBackColor = true;
            this.betting.Click += new System.EventHandler(this.betting_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.betting);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        public System.Windows.Forms.TextBox bet;
        private System.Windows.Forms.Button betting;
    }
}