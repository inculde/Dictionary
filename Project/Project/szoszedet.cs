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
    public partial class szoszedet : Form
    {                
        SqlConnection con;

        public szoszedet(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void szoszedet_Load(object sender, EventArgs e)
        {
            adatMegjelenites(con, vocabularyDataGridView, "select * from Vocabulary");
        }

        private void vocabularyDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string l1 = vocabularyDataGridView.CurrentRow.Cells[0].Value.ToString();
                string l2 = vocabularyDataGridView.CurrentRow.Cells[1].Value.ToString();
                string comtext = "delete from Vocabulary where L1='" + l1 + "' and L2='" + l2 + "'";
                adatManipulacio(con, comtext);
                adatMegjelenites(con, vocabularyDataGridView, "select * from Vocabulary");
            }
        } 


        public void adatMegjelenites(SqlConnection con, DataGridView gv, string comtext)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comtext;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gv.DataSource = dt;

            con.Close();
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
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

                     
        
    }
}
