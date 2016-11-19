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
        List<string> szavak= new List<string>();
        Random veletlen = new Random();
        SqlConnection con;
        
        public Form4(SqlConnection con)//sqlconnection, melyik szótár, melyik nyelvszerint
        {
            InitializeComponent();
            //a tömb tesztelési céllal való feltöltése, ide majd sql kell
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

            int index = veletlen.Next(szavak.Count);
            szoLbl.Text = szavak[index];
        }

        public bool helyese(string l1, string l2) {

            
            con.Open();
            string comtext = "select count(*) from Vocabulary where (L1='" + l1 + "' and L2='" + l2 + "') or (L1='" + l2 + "' and L2='" + l1 + "') ";
            SqlCommand cmd2 = new SqlCommand(comtext, con);
            int count = Convert.ToInt16(cmd2.ExecuteScalar());
            con.Close();

            if (count > 0) return true;
            else return false;            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            bool helyes = helyese(szoLbl.Text, beir.Text);
            int index;
            //ide kellene a válasz ellenőrzése, helyes válasz esetén a helyes=true, egyébként false
            if (helyes == true)
            {
                index = veletlen.Next(szavak.Count);
                szoLbl.Text = szavak[index];
                visszajelzesLbl.Text = "A válasz helyes!";
                beir.Text = "";
            }
            else
            {
                visszajelzesLbl.Text = "A válasz helytelen, próbáld újra!";
                beir.Text = "";                
            }



        }
    }
}
