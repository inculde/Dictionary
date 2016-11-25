namespace Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.szoszedetButton = new System.Windows.Forms.Button();
            this.szoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // szoszedetButton
            // 
            this.szoszedetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szoszedetButton.Location = new System.Drawing.Point(0, 89);
            this.szoszedetButton.Name = "szoszedetButton";
            this.szoszedetButton.Size = new System.Drawing.Size(284, 23);
            this.szoszedetButton.TabIndex = 2;
            this.szoszedetButton.Text = "Hozzáadás";
            this.szoszedetButton.UseVisualStyleBackColor = true;
            this.szoszedetButton.Click += new System.EventHandler(this.szoszedetButton_Click);
            // 
            // szoListBox
            // 
            this.szoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.szoListBox.FormattingEnabled = true;
            this.szoListBox.Location = new System.Drawing.Point(0, 0);
            this.szoListBox.MultiColumn = true;
            this.szoListBox.Name = "szoListBox";
            this.szoListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.szoListBox.Size = new System.Drawing.Size(284, 89);
            this.szoListBox.Sorted = true;
            this.szoListBox.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.szoListBox);
            this.Controls.Add(this.szoszedetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button szoszedetButton;
        private System.Windows.Forms.ListBox szoListBox;
    }
}