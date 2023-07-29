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
using System.Xml.Linq;

namespace Veterinary.PL.Owner
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        ML.CRUD updt = new ML.CRUD();
        DataTable dt = new DataTable();

        private void Update_Load(object sender, EventArgs e)
        {
            id.Text = List.id;
            FN.Text = List.FN;
            LN.Text = List.LN;
            sex.Text = List.S;
            phone.Text = List.PH;
            address.Text = List.A;
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_owner(int.Parse(id.Text), FN.Text, LN.Text,sex.Text, int.Parse(phone.Text), address.Text);
               
                MessageBox.Show("Les informations ont été mises à jour avec succès !!!");
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
    }
}
