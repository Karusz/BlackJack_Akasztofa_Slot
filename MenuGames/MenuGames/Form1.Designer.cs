﻿namespace MenuGames
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.blackjack = new System.Windows.Forms.Button();
            this.Slot = new System.Windows.Forms.Button();
            this.Akaszto = new System.Windows.Forms.Button();
            this.eggtext = new System.Windows.Forms.Label();
            this.easteregg = new System.Windows.Forms.CheckBox();
            this.creators = new System.Windows.Forms.Button();
            this.minigame = new System.Windows.Forms.Button();
            this.click_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blackjack
            // 
            this.blackjack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blackjack.Location = new System.Drawing.Point(329, 131);
            this.blackjack.Name = "blackjack";
            this.blackjack.Size = new System.Drawing.Size(107, 33);
            this.blackjack.TabIndex = 0;
            this.blackjack.Text = "BlackJack";
            this.blackjack.UseVisualStyleBackColor = true;
            this.blackjack.Click += new System.EventHandler(this.blackjack_Click);
            // 
            // Slot
            // 
            this.Slot.Location = new System.Drawing.Point(329, 180);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(107, 33);
            this.Slot.TabIndex = 1;
            this.Slot.Text = "Slot Machine";
            this.Slot.UseVisualStyleBackColor = true;
            this.Slot.Click += new System.EventHandler(this.Slot_Click);
            // 
            // Akaszto
            // 
            this.Akaszto.Location = new System.Drawing.Point(329, 231);
            this.Akaszto.Name = "Akaszto";
            this.Akaszto.Size = new System.Drawing.Size(107, 33);
            this.Akaszto.TabIndex = 2;
            this.Akaszto.Text = "Akasztófa";
            this.Akaszto.UseVisualStyleBackColor = true;
            this.Akaszto.Click += new System.EventHandler(this.Akaszto_Click);
            // 
            // eggtext
            // 
            this.eggtext.BackColor = System.Drawing.Color.Transparent;
            this.eggtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eggtext.ForeColor = System.Drawing.SystemColors.Control;
            this.eggtext.Location = new System.Drawing.Point(275, 1);
            this.eggtext.Name = "eggtext";
            this.eggtext.Size = new System.Drawing.Size(205, 84);
            this.eggtext.TabIndex = 4;
            this.eggtext.Text = "Hannah Montana Style";
            this.eggtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eggtext.Visible = false;
            // 
            // easteregg
            // 
            this.easteregg.AutoSize = true;
            this.easteregg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easteregg.Location = new System.Drawing.Point(-4, 446);
            this.easteregg.Name = "easteregg";
            this.easteregg.Size = new System.Drawing.Size(12, 11);
            this.easteregg.TabIndex = 6;
            this.easteregg.UseVisualStyleBackColor = true;
            this.easteregg.CheckedChanged += new System.EventHandler(this.easteregg_CheckedChanged);
            // 
            // creators
            // 
            this.creators.Location = new System.Drawing.Point(329, 279);
            this.creators.Name = "creators";
            this.creators.Size = new System.Drawing.Size(107, 33);
            this.creators.TabIndex = 7;
            this.creators.Text = "Készítők";
            this.creators.UseVisualStyleBackColor = true;
            this.creators.Click += new System.EventHandler(this.creators_Click);
            // 
            // minigame
            // 
            this.minigame.Location = new System.Drawing.Point(329, 330);
            this.minigame.Name = "minigame";
            this.minigame.Size = new System.Drawing.Size(107, 33);
            this.minigame.TabIndex = 8;
            this.minigame.Text = "Minigame";
            this.minigame.UseVisualStyleBackColor = true;
            this.minigame.Click += new System.EventHandler(this.minigame_Click);
            // 
            // click_btn
            // 
            this.click_btn.Location = new System.Drawing.Point(38, 61);
            this.click_btn.Name = "click_btn";
            this.click_btn.Size = new System.Drawing.Size(78, 24);
            this.click_btn.TabIndex = 9;
            this.click_btn.Text = "Nyomj Meg!";
            this.click_btn.UseVisualStyleBackColor = true;
            this.click_btn.Click += new System.EventHandler(this.click_btn_Click);
            this.click_btn.MouseEnter += new System.EventHandler(this.click_btn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.click_btn);
            this.Controls.Add(this.minigame);
            this.Controls.Add(this.creators);
            this.Controls.Add(this.easteregg);
            this.Controls.Add(this.eggtext);
            this.Controls.Add(this.Akaszto);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.blackjack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button blackjack;
        public System.Windows.Forms.Button Slot;
        public System.Windows.Forms.Button Akaszto;
        private System.Windows.Forms.Label eggtext;
        private System.Windows.Forms.CheckBox easteregg;
        private System.Windows.Forms.Button creators;
        private System.Windows.Forms.Button minigame;
        private System.Windows.Forms.Button click_btn;
    }
}

