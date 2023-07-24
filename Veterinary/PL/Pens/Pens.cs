using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Veterinary.ML;

namespace Veterinary.PL.Pens
{
    public partial class Pens : Form
    {
        public Pens()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dta = new DataTable();
        DataTable dtp = new DataTable();

        private void Pens_Load(object sender, EventArgs e)
        {
            dta = crud.list_animals();
            if (dta.Rows.Count > 0)
            {
                DataGridViewAnimal.DataSource = dta;

                //Datagridview Header 
                DataGridViewAnimal.Columns[0].HeaderText = "Identification";
                DataGridViewAnimal.Columns[1].HeaderText = "Animal Name";
                DataGridViewAnimal.Columns[2].HeaderText = "Species";
                DataGridViewAnimal.Columns[3].HeaderText = "Breed";
                DataGridViewAnimal.Columns[11].HeaderText = "Owner Name";
            }
            else
            {
                MessageBox.Show("List is Empty ");
            }

            dtp = crud.list_pens();
            if (dtp.Rows.Count > 0)
            {
                DataGridViewPens.DataSource = dtp;

                //Datagridview Header 
                DataGridViewPens.Columns[0].HeaderText = "Identification";
                DataGridViewPens.Columns[1].HeaderText = "Duration";
                DataGridViewPens.Columns[2].HeaderText = "Start Date";
                DataGridViewPens.Columns[3].HeaderText = "End Date";
                DataGridViewPens.Columns[3].HeaderText = "Price by Day";
                DataGridViewPens.Columns[3].HeaderText = "Animal";
            }
            else
            {
                MessageBox.Show("List is Empty");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                crud.insert_pens(int.Parse(dur.Text),sdate.Text,edate.Text,float.Parse(priced.Text),int.Parse(id_a.Text));
                MessageBox.Show("Pens Added Successfully!!!");
                dtp = crud.list_pens();
                DataGridViewPens.DataSource = dtp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                crud.update_pens(int.Parse(id_p.Text),int.Parse(dur.Text), sdate.Text, edate.Text, float.Parse(priced.Text), int.Parse(id_a.Text));
                MessageBox.Show("Pens Updated Successfully!!!");
                dtp = crud.list_pens();
                DataGridViewPens.DataSource = dtp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this pens ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    crud.delete_pens(int.Parse(id_p.Text));
                    MessageBox.Show("Deleted Successfully !!!");
                    dtp = crud.list_payment();
                    DataGridViewPens.DataSource = dtp;
                }

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

        private void DataGridViewPens_Click(object sender, EventArgs e)
        {
            if (DataGridViewPens.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_p.Text = DataGridViewPens.CurrentRow.Cells[0].Value.ToString();
            }
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
