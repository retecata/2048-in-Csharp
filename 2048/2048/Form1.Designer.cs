namespace _2048
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
            this.Scor = new System.Windows.Forms.Button();
            this.gata = new System.Windows.Forms.RichTextBox();
            this.Highscore = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scor
            // 
            this.Scor.BackColor = System.Drawing.Color.PeachPuff;
            this.Scor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scor.Location = new System.Drawing.Point(216, 31);
            this.Scor.Name = "Scor";
            this.Scor.Size = new System.Drawing.Size(130, 59);
            this.Scor.TabIndex = 0;
            this.Scor.Text = "0";
            this.Scor.UseVisualStyleBackColor = false;
            // 
            // gata
            // 
            this.gata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gata.Location = new System.Drawing.Point(31, 215);
            this.gata.Name = "gata";
            this.gata.Size = new System.Drawing.Size(325, 91);
            this.gata.TabIndex = 1;
            this.gata.Text = " Ai pierdut! Incepe un joc nou";
            this.gata.TextChanged += new System.EventHandler(this.gata_TextChanged);
            // 
            // Highscore
            // 
            this.Highscore.BackColor = System.Drawing.Color.PeachPuff;
            this.Highscore.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore.Location = new System.Drawing.Point(31, 31);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(130, 59);
            this.Highscore.TabIndex = 2;
            this.Highscore.Text = "0";
            this.Highscore.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 448);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.gata);
            this.Controls.Add(this.Scor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Scor;
        private System.Windows.Forms.RichTextBox gata;
        private System.Windows.Forms.Button Highscore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;

    }
}

