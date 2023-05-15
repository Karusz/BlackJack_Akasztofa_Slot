namespace Menu
{
    partial class Menu
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
            this.bj = new System.Windows.Forms.Button();
            this.af = new System.Windows.Forms.Button();
            this.sm = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bj
            // 
            this.bj.Location = new System.Drawing.Point(285, 128);
            this.bj.Name = "bj";
            this.bj.Size = new System.Drawing.Size(230, 61);
            this.bj.TabIndex = 0;
            this.bj.Text = "Black Jack";
            this.bj.UseVisualStyleBackColor = true;
            this.bj.Click += new System.EventHandler(this.bj_Click);
            // 
            // af
            // 
            this.af.Location = new System.Drawing.Point(285, 195);
            this.af.Name = "af";
            this.af.Size = new System.Drawing.Size(230, 61);
            this.af.TabIndex = 1;
            this.af.Text = "Akasztófa";
            this.af.UseVisualStyleBackColor = true;
            this.af.Click += new System.EventHandler(this.af_Click);
            // 
            // sm
            // 
            this.sm.Location = new System.Drawing.Point(285, 262);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(230, 61);
            this.sm.TabIndex = 2;
            this.sm.Text = "Slot Machine";
            this.sm.UseVisualStyleBackColor = true;
            this.sm.Click += new System.EventHandler(this.sm_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(665, 388);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(104, 30);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.af);
            this.Controls.Add(this.bj);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bj;
        private System.Windows.Forms.Button af;
        private System.Windows.Forms.Button sm;
        private System.Windows.Forms.Button quit;
    }
}

