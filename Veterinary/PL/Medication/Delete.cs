using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Medication
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
            MN.Text = List.MN;
            Dosform.Text = List.Dosform;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            ML.CRUD del = new ML.CRUD();
            try
            {
                del.delete_medication(int.Parse(id.Text));
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
