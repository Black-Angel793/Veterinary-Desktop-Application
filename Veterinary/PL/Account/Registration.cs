using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Account
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();

        private void Registration_Load(object sender, EventArgs e)
        {
            DataTable dt_Type = new DataTable();
            dt_Type = crud.list_role();
            foreach (DataRow dr in dt_Type.Rows)
            {
                roles.Items.Add(dr["RoleType"].ToString());
            }
            password.UseSystemPasswordChar = true;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {               
                crud.insert_user(username.Text, password.Text, roles.Text);

                MessageBox.Show("User Added Successfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void loginlbl_Click(object sender, EventArgs e)
        {
            PL.Account.Login login = new PL.Account.Login();
            login.Show();
            this.Hide();
        }

        private void me(object sender, EventArgs e)
        {
            loginlbl.ForeColor = Color.Turquoise;
        }

        private void ml(object sender, EventArgs e)
        {
            loginlbl.ForeColor = Color.Black;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
