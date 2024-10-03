using System;
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
    public partial class userinfo : UserControl
    {
        public userinfo()
        {
            InitializeComponent();
        }
        public static string conn = "Data Source=V1PASH;Initial Catalog = my; Integrated Security = True; TrustServerCertificate=True";

        private void userinfo_Load(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(conn);
            con.Open();
            string query = "Select * from login where username='" + login.user + "'";
            SqlCommand cmd=new SqlCommand(query, con); 
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Accno.Text = dr["id"].ToString();
                name.Text   =$" :   {dr["name"].ToString()}";
                email.Text  =$" :   {dr["email"].ToString()}";
                address.Text=$" :   {dr["address"].ToString()}";
                mobile.Text =$" :   {dr["mobile"].ToString()}";
                bal.Text= $" :   {dr["balance"].ToString()}";
            }
            con.Close();
        }
    }
}
