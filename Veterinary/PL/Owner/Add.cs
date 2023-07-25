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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Veterinary.PL.Owner
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                ML.CRUD crud = new ML.CRUD();

                crud.insert_owner(FN.Text, LN.Text, sex.Text,int.Parse(phone.Text),address.Text);

                MessageBox.Show("Client Added Successfully !!");

                PL.Owner.List list = new PL.Owner.List();
                list.Show();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            PL.Owner.List home = new PL.Owner.List();
            home.Show();
            Close();
        }

        private void LN_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
