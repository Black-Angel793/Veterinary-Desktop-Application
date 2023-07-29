using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Store
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dt = new DataTable();

        private void Update_Load(object sender, EventArgs e)
        {
            idp.Text = List.id;
            pn.Text = List.pn;
            qts.Text = List.qts;
            price.Text = List.price;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                crud.update_product(int.Parse(idp.Text), pn.Text, int.Parse(qts.Text),float.Parse(price.Text));

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
            PL.Store.List list = new PL.Store.List();
            list.Show();
            Close();
        }
    }
}
