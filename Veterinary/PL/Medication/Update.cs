using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinary.PL.Medication
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
            MN.Text = List.MN;
            des.Text = List.Des;
            dosage.Text = List.Dosform;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_medication(int.Parse(id.Text), MN.Text, des.Text,dosage.Text);

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
            PL.Medication.List home = new PL.Medication.List();
            home.Show();
            Close();
        }
    }
}
