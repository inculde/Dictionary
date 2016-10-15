using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void vocabularyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vocabularyBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Vocabulary' table. You can move, or remove it, as needed.
            this.vocabularyTableAdapter.Fill(this.dbDataSet.Vocabulary);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vocabularyBindingSource.EndEdit();
            
        }

        

        
        
    }
}
