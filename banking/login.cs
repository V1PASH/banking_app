using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace banking
{
    public partial class login : KryptonForm
    {
        public static string user;
        public static string conn = "Data Source=V1PASH;Initial Catalog = my; Integrated Security = True; TrustServerCertificate=True";
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
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "Select * from login where username='" + username.Text + "' and password='" + password.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                user = username.Text;
                username.Hide();
                password.Hide();
                signup.Hide();
                mainscreen main = new mainscreen();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No account available");
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            username.Hide();
            password.Hide();
            button1.Hide();
            signup.Hide();
            pictureBox2.Hide();
            loadfrom(new signup());
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
