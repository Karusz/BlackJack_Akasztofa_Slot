namespace MenuGames
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
            this.blackjack = new System.Windows.Forms.Button();
            this.Slot = new System.Windows.Forms.Button();
            this.Akaszto = new System.Windows.Forms.Button();
            this.easteregg = new System.Windows.Forms.Button();
            this.eggtext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blackjack
            // 
            this.blackjack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blackjack.Location = new System.Drawing.Point(326, 153);
            this.blackjack.Name = "blackjack";
            this.blackjack.Size = new System.Drawing.Size(107, 33);
            this.blackjack.TabIndex = 0;
            this.blackjack.Text = "BlackJack";
            this.blackjack.UseVisualStyleBackColor = true;
            this.blackjack.Click += new System.EventHandler(this.blackjack_Click);
            // 
            // Slot
            // 
            this.Slot.Location = new System.Drawing.Point(326, 202);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(107, 33);
            this.Slot.TabIndex = 1;
            this.Slot.Text = "Slot Machine";
            this.Slot.UseVisualStyleBackColor = true;
            this.Slot.Click += new System.EventHandler(this.Slot_Click);
            // 
            // Akaszto
            // 
            this.Akaszto.Location = new System.Drawing.Point(326, 253);
            this.Akaszto.Name = "Akaszto";
            this.Akaszto.Size = new System.Drawing.Size(107, 33);
            this.Akaszto.TabIndex = 2;
            this.Akaszto.Text = "Akasztófa";
            this.Akaszto.UseVisualStyleBackColor = true;
            this.Akaszto.Click += new System.EventHandler(this.Akaszto_Click);
            // 
            // easteregg
            // 
            this.easteregg.BackColor = System.Drawing.SystemColors.Window;
            this.easteregg.Cursor = System.Windows.Forms.Cursors.No;
            this.easteregg.Location = new System.Drawing.Point(0, 1);
            this.easteregg.Name = "easteregg";
            this.easteregg.Size = new System.Drawing.Size(75, 23);
            this.easteregg.TabIndex = 3;
            this.easteregg.Text = " ";
            this.easteregg.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.easteregg.UseVisualStyleBackColor = false;
            this.easteregg.Click += new System.EventHandler(this.easteregg_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eggtext);
            this.Controls.Add(this.easteregg);
            this.Controls.Add(this.Akaszto);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.blackjack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button blackjack;
        public System.Windows.Forms.Button Slot;
        public System.Windows.Forms.Button Akaszto;
        private System.Windows.Forms.Button easteregg;
        private System.Windows.Forms.Label eggtext;
    }
}

