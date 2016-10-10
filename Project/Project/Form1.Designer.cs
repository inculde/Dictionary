namespace Project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezárásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szótárToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megjelenítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanulásiSegédletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szótárfüzetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesztToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.beállításokToolStripMenuItem,
            this.tanulásiSegédletToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem,
            this.bezárásToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // bezárásToolStripMenuItem
            // 
            this.bezárásToolStripMenuItem.Name = "bezárásToolStripMenuItem";
            this.bezárásToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bezárásToolStripMenuItem.Text = "Bezárás";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szótárToolStripMenuItem,
            this.megjelenítésToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // szótárToolStripMenuItem
            // 
            this.szótárToolStripMenuItem.Name = "szótárToolStripMenuItem";
            this.szótárToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.szótárToolStripMenuItem.Text = "Szótár";
            // 
            // megjelenítésToolStripMenuItem
            // 
            this.megjelenítésToolStripMenuItem.Name = "megjelenítésToolStripMenuItem";
            this.megjelenítésToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.megjelenítésToolStripMenuItem.Text = "Megjelenítés";
            // 
            // tanulásiSegédletToolStripMenuItem
            // 
            this.tanulásiSegédletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szótárfüzetToolStripMenuItem,
            this.tesztToolStripMenuItem,
            this.statisztikaToolStripMenuItem});
            this.tanulásiSegédletToolStripMenuItem.Name = "tanulásiSegédletToolStripMenuItem";
            this.tanulásiSegédletToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.tanulásiSegédletToolStripMenuItem.Text = "Tanulási segédlet";
            this.tanulásiSegédletToolStripMenuItem.Click += new System.EventHandler(this.tanulásiSegédletToolStripMenuItem_Click);
            // 
            // szótárfüzetToolStripMenuItem
            // 
            this.szótárfüzetToolStripMenuItem.Name = "szótárfüzetToolStripMenuItem";
            this.szótárfüzetToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.szótárfüzetToolStripMenuItem.Text = "Szótárfüzet";
            // 
            // tesztToolStripMenuItem
            // 
            this.tesztToolStripMenuItem.Name = "tesztToolStripMenuItem";
            this.tesztToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.tesztToolStripMenuItem.Text = "Teszt";
            // 
            // statisztikaToolStripMenuItem
            // 
            this.statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            this.statisztikaToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.statisztikaToolStripMenuItem.Text = "Statisztika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanulásiSegédletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezárásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szótárToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megjelenítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szótárfüzetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesztToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikaToolStripMenuItem;
    }
}

