using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Veterinary.PL.Consultation
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dt1 = new DataTable();
        DataTable dt_ct = new DataTable();

        private void Add_Load(object sender, EventArgs e)
        {
            dt1 = crud.list_animals();
            if (dt1.Rows.Count > 0)
            {
                DataGridViewAnimal.DataSource = dt1;

                //Datagridview Header 
                DataGridViewAnimal.Columns[0].HeaderText = "Identification";
                DataGridViewAnimal.Columns[1].HeaderText = "Animal Name";
                DataGridViewAnimal.Columns[2].HeaderText = "Species";
                DataGridViewAnimal.Columns[3].HeaderText = "Breed";
                DataGridViewAnimal.Columns[4].HeaderText = "BirthDate";
                DataGridViewAnimal.Columns[5].HeaderText = "Sex";
                DataGridViewAnimal.Columns[6].HeaderText = "Color";
                DataGridViewAnimal.Columns[7].HeaderText = "Weight";
                DataGridViewAnimal.Columns[8].HeaderText = "Medical Condition";
                DataGridViewAnimal.Columns[9].HeaderText = "Vaccin Status";
                DataGridViewAnimal.Columns[8].HeaderText = "Picture";
                DataGridViewAnimal.Columns[9].HeaderText = "Owner Name";
            }
            else
            {
                MessageBox.Show("list vide");
            }

            dt_ct = crud.list_consultType();
            foreach (DataRow dr in dt_ct.Rows)
            {
                conType.Items.Add(dr["Name_T"].ToString());
            }

        }

        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                ML.CRUD crud = new ML.CRUD();

                crud.insert_consultation(ConDate.Text, ConTime.Text, observation.Text, diagnosis.Text, int.Parse(id_a.Text),conType.SelectedIndex);
   
                MessageBox.Show("Consultation Added Successfully !!");

                PL.Consultation.List list = new PL.Consultation.List();
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
            Form1 home = new Form1();
            home.Show();
            Close();
        }

        private void DataGridViewAnimal_Click(object sender, EventArgs e)
        {
            if (DataGridViewAnimal.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_a.Text = DataGridViewAnimal.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
