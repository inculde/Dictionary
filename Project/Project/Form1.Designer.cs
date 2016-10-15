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
            this.szovegTxt = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
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
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            this.fájlToolStripMenuItem.Click += new System.EventHandler(this.fájlToolStripMenuItem_Click);
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // bezárásToolStripMenuItem
            // 
            this.bezárásToolStripMenuItem.Name = "bezárásToolStripMenuItem";
            this.bezárásToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bezárásToolStripMenuItem.Text = "Bezárás";
            this.bezárásToolStripMenuItem.Click += new System.EventHandler(this.bezárásToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szótárToolStripMenuItem,
            this.megjelenítésToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // szótárToolStripMenuItem
            // 
            this.szótárToolStripMenuItem.Name = "szótárToolStripMenuItem";
            this.szótárToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.szótárToolStripMenuItem.Text = "Szótár";
            this.szótárToolStripMenuItem.Click += new System.EventHandler(this.szótárToolStripMenuItem_Click);
            // 
            // megjelenítésToolStripMenuItem
            // 
            this.megjelenítésToolStripMenuItem.Name = "megjelenítésToolStripMenuItem";
            this.megjelenítésToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.megjelenítésToolStripMenuItem.Text = "Megjelenítés";
            // 
            // tanulásiSegédletToolStripMenuItem
            // 
            this.tanulásiSegédletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szótárfüzetToolStripMenuItem,
            this.tesztToolStripMenuItem,
            this.statisztikaToolStripMenuItem});
            this.tanulásiSegédletToolStripMenuItem.Name = "tanulásiSegédletToolStripMenuItem";
            this.tanulásiSegédletToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.tanulásiSegédletToolStripMenuItem.Text = "Tanulási segédlet";
            this.tanulásiSegédletToolStripMenuItem.Click += new System.EventHandler(this.tanulásiSegédletToolStripMenuItem_Click);
            // 
            // szótárfüzetToolStripMenuItem
            // 
            this.szótárfüzetToolStripMenuItem.Name = "szótárfüzetToolStripMenuItem";
            this.szótárfüzetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.szótárfüzetToolStripMenuItem.Text = "Szótárfüzet";
            this.szótárfüzetToolStripMenuItem.Click += new System.EventHandler(this.szótárfüzetToolStripMenuItem_Click);
            // 
            // tesztToolStripMenuItem
            // 
            this.tesztToolStripMenuItem.Name = "tesztToolStripMenuItem";
            this.tesztToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tesztToolStripMenuItem.Text = "Teszt";
            // 
            // statisztikaToolStripMenuItem
            // 
            this.statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            this.statisztikaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statisztikaToolStripMenuItem.Text = "Statisztika";
            // 
            // szovegTxt
            // 
            this.szovegTxt.Location = new System.Drawing.Point(9, 25);
            this.szovegTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.szovegTxt.Multiline = true;
            this.szovegTxt.Name = "szovegTxt";
            this.szovegTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.szovegTxt.Size = new System.Drawing.Size(330, 319);
            this.szovegTxt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.szovegTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox szovegTxt;
    }
}

