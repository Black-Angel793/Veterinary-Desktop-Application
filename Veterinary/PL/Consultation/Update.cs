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
using Veterinary.ML;
//using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Veterinary.PL.Consultation
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        ML.CRUD updt = new ML.CRUD();
        DataTable dt = new DataTable();
        DataTable dt_ct = new DataTable();

        private void Update_Load(object sender, EventArgs e)
        {
            id.Text = List.id;
            ConDate.Text = List.CD;
            diagnosis.Text = List.Diagn;
            price.Text = List.Price;
            id_a.Text = List.animal;
            conType.Text = List.conType;

            dt_ct = updt.list_consultType();
            foreach (DataRow dr in dt_ct.Rows)
            {
                conType.Items.Add(dr["Name_T"].ToString());
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_consultation(int.Parse(id.Text), ConDate.Text, diagnosis.Text,float.Parse(price.Text), int.Parse(id_a.Text),int.Parse(conType.Text));

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
            PL.Consultation.List home = new PL.Consultation.List();
            home.Show();
            Close();
        }

        private void DataGridViewAnimal_Click(object sender, EventArgs e)
        {
            if (DataGridViewAnimal.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_a.Text = DataGridViewAnimal.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
