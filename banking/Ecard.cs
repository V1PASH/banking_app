using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace banking
{
    public partial class Ecard : UserControl
    {
        public Ecard()
        {
            InitializeComponent();
            cvv.Hide();
        }
        public static string conn = "Data Source=V1PASH;Initial Catalog = my; Integrated Security = True; TrustServerCertificate=True";

        private void Ecard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "Select * from login where username='" + login.user + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cardno.Text = dr["cardnumber"].ToString();
                cvv.Text = dr["cvv"].ToString();
                expiry.Text = dr["expirydate"].ToString();
                name.Text = dr["name"].ToString().ToUpper();


            }
            con.Close();
        }

        private void cvv_Click(object sender, EventArgs e)
        {
            cvv.Hide();
            hiddencvv.Show();
        }

        private void hiddencvv_Click(object sender, EventArgs e)
        {
            cvv.Show();
            hiddencvv.Hide();
        }
    }
}
