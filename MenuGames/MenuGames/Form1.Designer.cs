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
            this.SuspendLayout();
            // 
            // blackjack
            // 
            this.blackjack.Location = new System.Drawing.Point(315, 126);
            this.blackjack.Name = "blackjack";
            this.blackjack.Size = new System.Drawing.Size(75, 23);
            this.blackjack.TabIndex = 0;
            this.blackjack.Text = "BJ";
            this.blackjack.UseVisualStyleBackColor = true;
            this.blackjack.Click += new System.EventHandler(this.blackjack_Click);
            // 
            // Slot
            // 
            this.Slot.Location = new System.Drawing.Point(315, 201);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(75, 23);
            this.Slot.TabIndex = 1;
            this.Slot.Text = "Slot";
            this.Slot.UseVisualStyleBackColor = true;
            this.Slot.Click += new System.EventHandler(this.Slot_Click);
            // 
            // Akaszto
            // 
            this.Akaszto.Location = new System.Drawing.Point(418, 165);
            this.Akaszto.Name = "Akaszto";
            this.Akaszto.Size = new System.Drawing.Size(75, 23);
            this.Akaszto.TabIndex = 2;
            this.Akaszto.Text = "Akasztó";
            this.Akaszto.UseVisualStyleBackColor = true;
            this.Akaszto.Click += new System.EventHandler(this.Akaszto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Akaszto);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.blackjack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button blackjack;
        public System.Windows.Forms.Button Slot;
        public System.Windows.Forms.Button Akaszto;
    }
}

