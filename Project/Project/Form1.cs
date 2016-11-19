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
using System.Configuration;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["Project.Properties.Settings.dbConnectionString"].ConnectionString;
        static SqlConnection con = new SqlConnection(conString);

        Form2 BeallitasForm = new Form2();
        szoszedet SzoszedetForm = new szoszedet(con);

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
                openOFD.Filter = "Szövegfájlok | *.txt";
                szovegTxt.Text = File.ReadAllText(openOFD.FileName, Encoding.UTF8);
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
            BeallitasForm.ShowDialog();            
        }

        private void szótárfüzetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SzoszedetForm.ShowDialog();
        }
       

        private void pro_MouseClick(object sender, MouseEventArgs e)
        {
            string keresett = (sender as Label).Text;

            //MessageBox.Show((sender as Label).Location.ToString() + "\n" + this.Location.ToString());
            Form3 szotar = new Form3(keresett, con, 1);
            szotar.Width = this.Width;
            
            szotar.ShowDialog();
        }

        private void szovegTxt_TextChanged(object sender, EventArgs e)
        {
            string s = szovegTxt.Text;
            string[] szo = s.Split(' ');
        }

        private void szovegTxt_MouseUp(object sender, MouseEventArgs e)
        {
            string keresett = szovegTxt.SelectedText;
            string[] szo = keresett.Split(' ');
            //MessageBox.Show(keresett);
            foreach(string s in szo){
                Form3 szotar = new Form3(s, con, 1);
                szotar.Width = this.Width;
                szotar.Show();
            }
            /*Form3 szotar = new Form3(keresett, con, 1);
            szotar.Width = this.Width;
            szotar.ShowDialog();*/


        }

        private void tesztToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 teszt = new Form4(con);
            teszt.ShowDialog();
        }
    }
}
