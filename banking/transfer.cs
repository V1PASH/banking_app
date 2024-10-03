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
    public partial class transfer : UserControl
    {
        public transfer()
        {
            InitializeComponent();
        }

        public static string conn = "Data Source=V1PASH;Initial Catalog = my; Integrated Security = True; TrustServerCertificate=True";
        SqlConnection con = new SqlConnection(conn);
        static int mainaccbalance = 0;
        static int secondaryaccbalance = 0;
        string query = "";
        private void transfer_Load(object sender, EventArgs e)
        {
            name.Text = "";
            amount.Hide();
            transferbutton.Hide();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            query = "Select * from login where id='" + transferaccount.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    name.Text = $"Account Holder Name : {dr["name"].ToString()}";
                    string aa = dr["balance"].ToString();

                    secondaryaccbalance = Convert.ToInt32(aa);

                    label2.Show();
                    amount.Show();
                    amount.Text = "";
                    transferbutton.Show();

                }
                else
                {
                    transferaccount.Text = "";
                    MessageBox.Show("cheak and re enter account number");
                }
            }
            catch(Exception E)
            {
                transferaccount.Text = "";
                MessageBox.Show("you can only enter number in acoount number column");
            }

            con.Close();
        }

        private void transferbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            query = "select * from Login where username='" + login.user + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                string m = dr["balance"].ToString();
                mainaccbalance = Convert.ToInt32(m);

                mainaccbalance -= Convert.ToInt32(amount.Text);

            }
            dr.Close();
            query = "update Login set balance='" + mainaccbalance + "' where username='" + login.user + "'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            query = "select * from Login where id='" +transferaccount.Text + "'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            int a = 5;

            if (dr.Read())
            {
                string m = dr["balance"].ToString();
                secondaryaccbalance = Convert.ToInt32(m);
                secondaryaccbalance += Convert.ToInt32(amount.Text);
            }
            query = "update Login set balance='" + secondaryaccbalance + "' where id='" + transferaccount.Text + "'";
            cmd = new SqlCommand(query, con);
            dr.Close();
            cmd.ExecuteNonQuery();

            MessageBox.Show("done");
        }
    }
}
