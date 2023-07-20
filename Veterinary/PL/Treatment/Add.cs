using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;

namespace Veterinary.PL.Treatment
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        DataTable dt1 = new DataTable();
        ML.CRUD crud = new ML.CRUD();
        private void Add_Load(object sender, EventArgs e)
        {
            id_c.Text = PL.Consultation.List.id;

            dt1 = crud.list_consultations();
            if (dt1.Rows.Count > 0)
            {
                DataGridView1.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("list vide");
            }
        }
        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                crud.insert_treatment(SDate.Text, EDate.Text, Inst.Text, Notes.Text,int.Parse(id_c.Text));

                MessageBox.Show("Treatment Added Successfully !!");

                PL.Treatment.List list = new PL.Treatment.List();
                list.Show();
                this.Close();

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
            this.Close();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_c.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
