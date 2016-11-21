namespace Project
{
    partial class statisztika
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
            this.statisticDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticDataGridView
            // 
            this.statisticDataGridView.AllowUserToAddRows = false;
            this.statisticDataGridView.AllowUserToDeleteRows = false;
            this.statisticDataGridView.AllowUserToOrderColumns = true;
            this.statisticDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticDataGridView.Location = new System.Drawing.Point(0, 0);
            this.statisticDataGridView.Name = "statisticDataGridView";
            this.statisticDataGridView.ReadOnly = true;
            this.statisticDataGridView.RowHeadersWidth = 10;
            this.statisticDataGridView.Size = new System.Drawing.Size(230, 262);
            this.statisticDataGridView.TabIndex = 0;
            // 
            // statisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 262);
            this.Controls.Add(this.statisticDataGridView);
            this.Name = "statisztika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statisztika";
            this.Load += new System.EventHandler(this.statisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticDataGridView;
    }
}