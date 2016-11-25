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
using System.Text.RegularExpressions;

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

            con.Open();
            string comtext = "select count(*) from Main_Dictionary ";
            SqlCommand cmd2 = new SqlCommand(comtext, con);
            long count = Convert.ToInt64(cmd2.ExecuteScalar());
            con.Close();
            System.Console.WriteLine(count);
            if (count < 100)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "szoszedet.txt");
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string[] lines = System.IO.File.ReadAllLines(path);
                int sorokszama = File.ReadLines(path).Count();
                string[,] szotar = new string[sorokszama, 2];
                string[] szavak;
                Char[] delimiter = { '*' };
                for (int i = 0; i <= sorokszama; i++)
                {
                    string sor = file.ReadLine();
                    szavak = new string[2];
                    try
                    {
                        szavak = Regex.Split(sor, " -» ");

                        comtext = "insert into Main_Dictionary (L1, L2) values ('" + szavak[0] + "','" + szavak[1] + "')";
                        adatManipulacio(con, comtext);
                    }
                    catch (Exception ex) { }
                    if (i % 1000 == 0) { System.Console.WriteLine(i + " / " + sorokszama); }
                }
            }
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

            
            Form3 szotar = new Form3(keresett, con, 1);
            //szotar.Width = this.Width;
            szotar.StartPosition = FormStartPosition.Manual;
            szotar.Location = new Point(MousePosition.X, MousePosition.Y);
            szotar.Show();
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
                if (s != "" && s != " ")
                {
                    Form3 szotar = new Form3(s, con, 1);
                    szotar.Width = this.Width;
                    szotar.StartPosition = FormStartPosition.Manual;
                    szotar.Location = new Point((this.Location.X), ((MousePosition.Y) + 10));
                    szotar.Show();
                }
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

        private void statisztikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisztika stat = new statisztika(con);
            stat.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void adatManipulacio(SqlConnection con, string comtext)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comtext;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(comtext+"\n"+ex.ToString());
            }
            con.Close();
        }

        private void szovegTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.V))
                (sender as TextBox).Paste();
        }

        private void megjelenítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                szovegTxt.Font = fontDialog1.Font;
            }
        }  
    }
}
