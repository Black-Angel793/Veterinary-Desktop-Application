using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Animal
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            id.Text = List.id;
            AN.Text = List.AN;
            breed.Text = List.Breed;
        }
        private void yes_Click(object sender, EventArgs e)
        {
            ML.CRUD del = new ML.CRUD();
            try
            {
                del.delete_animal(int.Parse(id.Text));
                MessageBox.Show("deleted successfully !!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
