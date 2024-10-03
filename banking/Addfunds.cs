using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking
{
    public partial class Addfunds : UserControl
    {
        public Addfunds()
        {
            InitializeComponent();
        }
        public static string conn = "Data Source=V1PASH;Initial Catalog = my; Integrated Security = True; TrustServerCertificate=True";
        SqlConnection con = new SqlConnection(conn);
        static int mainaccbalance = 0;
        private void ADD_Click(object sender, EventArgs e)
        {
            con.Open();
           string query = "select * from Login where username='" + login.user + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string m = dr["balance"].ToString();
                mainaccbalance = Convert.ToInt32(m);

                mainaccbalance += Convert.ToInt32(amt.Text);

            }
            dr.Close();
            query = "update Login set balance='" + mainaccbalance + "' where username='" + login.user + "'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("done");
            amt.Text = "";
        }
    }
}
