namespace Project
{
    partial class szoszedet
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
            this.dbDataSet = new Project.dbDataSet();
            this.vocabularyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vocabularyDataGridView
            // 
            this.vocabularyDataGridView.AllowUserToOrderColumns = true;
            this.vocabularyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vocabularyDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vocabularyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vocabularyDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.vocabularyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vocabularyDataGridView.Name = "vocabularyDataGridView";
            this.vocabularyDataGridView.RowHeadersWidth = 25;
            this.vocabularyDataGridView.Size = new System.Drawing.Size(362, 339);
            this.vocabularyDataGridView.TabIndex = 1;
            this.vocabularyDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vocabularyDataGridView_KeyDown);
            // 
            // szoszedet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.vocabularyDataGridView);
            this.Name = "szoszedet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szószedet";
            this.Load += new System.EventHandler(this.szoszedet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.DataGridView vocabularyDataGridView;
    }
}