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
using static System.Net.Mime.MediaTypeNames;

using Veterinary.ML;

namespace Veterinary.PL.Store
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                crud.insert_product(pn.Text, int.Parse(qts.Text), float.Parse(price.Text));

                MessageBox.Show("Le produit a été ajouté avec succès !!");

                PL.Store.List list = new PL.Store.List();
                list.Show();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void id_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            PL.Store.List h = new PL.Store.List();
            h.Show();
            Close();
        }
    }
}
