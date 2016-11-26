using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        public Form3(string szo, SqlConnection con, int szotar)
        {
            InitializeComponent();
            this.Text = szo;
            this.con = con;
            string q = "select L2 from Main_Dictionary where L1='"+szo+"' and Dic="+szotar;//oda-vissza miatt valt
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);

            DataTable szocikk = new DataTable();
            adapter.Fill(szocikk);

            szoListBox.DisplayMember = "L2";
            szoListBox.ValueMember = "L2";
            szoListBox.DataSource = szocikk;
        }

        private void szoszedetButton_Click(object sender, EventArgs e)
        {
            string comtext = "insert into Vocabulary (L1, L2) values ";
            foreach (DataRowView item in szoListBox.Items)
            {
                string szo=item.Row[szoListBox.ValueMember].ToString();
                if (this.Text != " " && this.Text != "" && szo!= " " && szo!="")
                    comtext += "('" + this.Text + "', '" + szo + "'), ";                
            }
            comtext=comtext.Remove((comtext.Length) - 2);

            adatManipulacio(con, comtext);
            this.Close();
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
                //MessageBox.Show(ex.ToString());
            }
            con.Close();
        }     
    }
}
