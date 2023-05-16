namespace Menu
{
    partial class Blackjack
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
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.háttérToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.red = new System.Windows.Forms.ToolStripMenuItem();
            this.lime = new System.Windows.Forms.ToolStripMenuItem();
            this.green = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.bet = new System.Windows.Forms.TextBox();
            this.betpull = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settings
            // 
            this.settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.háttérToolStripMenuItem});
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 20);
            this.settings.Text = "Beállítások";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // háttérToolStripMenuItem
            // 
            this.háttérToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.red,
            this.lime,
            this.green});
            this.háttérToolStripMenuItem.Name = "háttérToolStripMenuItem";
            this.háttérToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.háttérToolStripMenuItem.Text = "Háttér";
            // 
            // red
            // 
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(100, 22);
            this.red.Text = "Piros";
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // lime
            // 
            this.lime.Name = "lime";
            this.lime.Size = new System.Drawing.Size(100, 22);
            this.lime.Text = "Lime";
            this.lime.Click += new System.EventHandler(this.lime_Click);
            // 
            // green
            // 
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(100, 22);
            this.green.Text = "Zöld";
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(63, 20);
            this.help.Text = "Segítség";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // bet
            // 
            this.bet.Location = new System.Drawing.Point(675, 304);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(104, 20);
            this.bet.TabIndex = 1;
            // 
            // betpull
            // 
            this.betpull.Location = new System.Drawing.Point(675, 350);
            this.betpull.Name = "betpull";
            this.betpull.Size = new System.Drawing.Size(103, 41);
            this.betpull.TabIndex = 2;
            this.betpull.Text = "Tétrakás";
            this.betpull.UseVisualStyleBackColor = true;
            this.betpull.Click += new System.EventHandler(this.betpull_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.sajatbg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.betpull);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem háttérToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem red;
        private System.Windows.Forms.ToolStripMenuItem lime;
        private System.Windows.Forms.ToolStripMenuItem green;
        private System.Windows.Forms.ToolStripMenuItem help;
        public System.Windows.Forms.TextBox bet;
        private System.Windows.Forms.Button betpull;
    }
}