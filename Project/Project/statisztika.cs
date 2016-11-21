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
    public partial class statisztika : Form
    {
        SqlConnection con;

        public statisztika(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
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

        private void statisztika_Load(object sender, EventArgs e)
        {
            adatMegjelenites(con, statisticDataGridView, "select Date, Point from Statistic order by Date");
        }
    }
}
