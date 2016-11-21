using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        List<string> szavak = new List<string>();
        List<string> adhato = new List<string>();
        Random veletlen=new Random();
        int adhatoDarab;
        Label[] kerdesek;
        TextBox[] valaszok;

        public Form4(SqlConnection con)
        {
            
            InitializeComponent();
            

            this.con = con;
            string comtext;
            con.Open();
            comtext = "select L1 from Vocabulary group by L1";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comtext;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                szavak.Add(row["L1"].ToString());

            }

            comtext = "select L2 from Vocabulary group by L2";
            cmd.CommandText = comtext;
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                szavak.Add(row["L2"].ToString());

            }

            con.Close();
            

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int helyesDarab = 0;
            bool[] helyes = new bool[10];
            for (int j=0; j<10; j++)
            {
                helyes[j] = true;
            }
            for (int k=0; k<10; k++)
            {
                //ide kellene a válasz ellenőrzése, helyes válasz esetén a helyes k. eleme=true, egyébként false
                helyes[k] = helyese(kerdesek[k].Text, valaszok[k].Text);
                if (helyes[k] == true)
                {
                    helyesDarab++;
                }
                
            }
            visszajelzes.Text = helyesDarab.ToString()+" helyes válasz van";
            DateTime most = DateTime.Now;
            string pro = most.Year + "-";
            pro += most.Month + "-";
            pro += most.Day;
            visszajelzes.Text += " " + pro;

            
            string comtext = "insert into Statistic (Date, Point) values ('" + pro + "', " + helyesDarab + ")";
            adatManipulacio(con, comtext);

        }


        private void Form4_Load(object sender, EventArgs e)
        {
            kerdesek = new Label[10];
            valaszok = new TextBox[10];
            for (int i=0; i<10; i++)
            {
                kerdesek[i] = new Label()
                {
                    Text = "[ ]",
                    Height = 20,
                    Width = 100,
                    Location = new Point(35, 10 + i * 30),
                    Visible = true,
                };
                valaszok[i] = new TextBox()
                {
                    Text = "",
                    Height = 20,
                    Width = 100,
                    Location = new Point(150, 10 + i * 30),
                    Visible = true,
                };
                this.Controls.Add(kerdesek[i]);
                this.Controls.Add(valaszok[i]);
            }
            //azért van, hogy 10 különböző szót generáljon
            foreach (string element in szavak)
            {
                adhato.Add(element);
            }
            int index;
            for (int j = 0; j < 10; j++)
            {
                adhatoDarab = adhato.Count();
                index = veletlen.Next(0, adhatoDarab);
                kerdesek[j].Text= adhato.ElementAt(index);
                adhato.Remove(adhato.ElementAt(index));

            }

        }

        public bool helyese(string l1, string l2)
        {


            con.Open();
            string comtext = "select count(*) from Vocabulary where (L1='" + l1 + "' and L2='" + l2 + "') or (L1='" + l2 + "' and L2='" + l1 + "') ";
            SqlCommand cmd2 = new SqlCommand(comtext, con);
            int count = Convert.ToInt16(cmd2.ExecuteScalar());
            con.Close();

            if (count > 0) return true;
            else return false;
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
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }
    }
}
