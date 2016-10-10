using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openOFD = new OpenFileDialog();
            if (openOFD.ShowDialog() == DialogResult.OK)
            {
                szovegTxt.Text = File.ReadAllText(openOFD.FileName);
            }
            
        }

        private void tanulásiSegédletToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fájlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bezárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegTxt.Text = "";

        }

        private void szótárToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 BeallitasForm= new Form2();
            BeallitasForm.Visible = true;
            
        }
    }
}
