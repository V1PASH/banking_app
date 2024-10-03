using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking
{
    public partial class mainscreen : KryptonForm
    {
        public mainscreen()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainscreen_Load(object sender, EventArgs e)
        {
            withdraw2.Hide();
            ecard1.Hide();
            transfer2.Hide();
            addfunds2.Hide();

        }

        private void transfer_Click(object sender, EventArgs e)
        {
            withdraw2.Hide();
            ecard1.Hide();
            transfer2.Show();
            addfunds2.Hide();
            userinfo2.Hide();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            withdraw2.Show();
            transfer2.Hide();
            ecard1.Hide();
            addfunds2.Hide();
            userinfo2.Hide();

        }

        private void funds_Click(object sender, EventArgs e)
        {
            withdraw2.Hide();
            ecard1.Hide();
            transfer2.Hide();
            addfunds2.Show();
            userinfo2.Hide();
        }

        private void info_Click(object sender, EventArgs e)
        {
            withdraw2.Hide();
            transfer2.Hide();
            addfunds2.Hide();
            ecard1.Hide();
            userinfo2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void debitcard_Click(object sender, EventArgs e)
        {
            withdraw2.Hide();
            transfer2.Hide();
            addfunds2.Hide();
            userinfo2.Hide();
            ecard1.Show();

        }

        private void ecard1_Load(object sender, EventArgs e)
        {

        }
    }
}
