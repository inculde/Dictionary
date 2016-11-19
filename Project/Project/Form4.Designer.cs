namespace Project
{
    partial class Form4
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
            this.okBtn = new System.Windows.Forms.Button();
            this.szoLbl = new System.Windows.Forms.Label();
            this.beir = new System.Windows.Forms.TextBox();
            this.visszajelzesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(65, 128);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(56, 19);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // szoLbl
            // 
            this.szoLbl.AutoSize = true;
            this.szoLbl.Location = new System.Drawing.Point(22, 57);
            this.szoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.szoLbl.Name = "szoLbl";
            this.szoLbl.Size = new System.Drawing.Size(35, 13);
            this.szoLbl.TabIndex = 1;
            this.szoLbl.Text = "label1";
            // 
            // beir
            // 
            this.beir.Location = new System.Drawing.Point(100, 53);
            this.beir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.beir.Name = "beir";
            this.beir.Size = new System.Drawing.Size(76, 20);
            this.beir.TabIndex = 2;
            // 
            // visszajelzesLbl
            // 
            this.visszajelzesLbl.AutoSize = true;
            this.visszajelzesLbl.Location = new System.Drawing.Point(22, 162);
            this.visszajelzesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visszajelzesLbl.Name = "visszajelzesLbl";
            this.visszajelzesLbl.Size = new System.Drawing.Size(35, 13);
            this.visszajelzesLbl.TabIndex = 3;
            this.visszajelzesLbl.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.visszajelzesLbl);
            this.Controls.Add(this.beir);
            this.Controls.Add(this.szoLbl);
            this.Controls.Add(this.okBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label szoLbl;
        private System.Windows.Forms.TextBox beir;
        private System.Windows.Forms.Label visszajelzesLbl;
    }
}