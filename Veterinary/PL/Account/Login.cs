using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ML.CRUD log = new ML.CRUD();
        DataTable dt = new DataTable();

        public static string un;

        private void Login_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            dt = log.login(username.Text, password.Text);
            if (dt.Rows.Count > 0)
            {
                un = username.Text;
                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Vérifier les informations");
            }
        }

        private void eyeclose_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            eyeopen.Show();
            eyeclose.Hide();
        }

        private void eyeopen_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            eyeclose.Show();
            eyeopen.Hide();
        }

        private void registerlbl_Click(object sender, EventArgs e)
        {
            PL.Account.Registration register = new PL.Account.Registration();
            register.Show();
            this.Hide();
        }

        private void me(object sender, EventArgs e)
        {
            registerlbl.ForeColor = Color.Turquoise;
        }

        private void ml(object sender, EventArgs e)
        {
            registerlbl.ForeColor = Color.Black;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
