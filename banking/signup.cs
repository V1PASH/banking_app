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
using ComponentFactory.Krypton.Toolkit;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace banking
{
    public partial class signup : KryptonForm
    {
        public static string conn = "Data Source=V1PASH;Initial Catalog = my; Integrated Security = True; TrustServerCertificate=True";

        public signup()
        {
            InitializeComponent();
        }

        public void loadfrom(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            Random rnd = new Random();
            long cvv = rnd.Next(100, 999);
            var cardno = new StringBuilder();
            while (cardno.Length < 16)
            {
                cardno.Append(rnd.Next(10).ToString());
            }
            string expiry = "11/32";
            string query = "INSERT INTO Login(username,password,name,mobile,email,address,balance,cardnumber,cvv,expirydate) VALUES('" + username.Text+"','"+ password.Text+"','"+name.Text+"','"+mobile.Text+"','"+email.Text+"','" +address.Text+"','0','"+cardno+"','"+cvv+"','"+expiry+"') ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();

      login login = new login();
            login.Show();
            this.Hide();


        }
    }
}
