using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Consultation
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dt = new DataTable();

        public static string id;
        public static string CD;
        public static string Diagn;
        public static string Price;
        public static string animal;
        public static string conType;

        private void List_Load(object sender, EventArgs e)
        {
            dt = crud.list_consultations();
            if (dt.Rows.Count > 0)
            {
                DGVcons.DataSource = dt;
                //Datagridview Header 
                DGVcons.Columns[0].HeaderText = "Identification";
                DGVcons.Columns[1].HeaderText = "Consultation Date";
                DGVcons.Columns[2].HeaderText = "Diagnosis";
                DGVcons.Columns[3].HeaderText = "Price";
                DGVcons.Columns[4].HeaderText = "Animal";
                DGVcons.Columns[5].HeaderText = "Consultation Type";
            }
            else
            {
                MessageBox.Show("List is Empty...");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVcons.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVcons.CurrentRow.Cells[0].Value.ToString();
                CD = DGVcons.CurrentRow.Cells[1].Value.ToString();
                Diagn = DGVcons.CurrentRow.Cells[2].Value.ToString();
                Price = DGVcons.CurrentRow.Cells[3].Value.ToString();
                animal = DGVcons.CurrentRow.Cells[4].Value.ToString();
                conType = DGVcons.CurrentRow.Cells[5].Value.ToString();

                PL.Consultation.Update u = new PL.Consultation.Update();
                u.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVcons.SelectedRows.Count > 1)
            {
                MessageBox.Show("Pleas Select one row !!");
            }
            else
            {
                id = DGVcons.CurrentRow.Cells[0].Value.ToString();
                animal = DGVcons.CurrentRow.Cells[1].Value.ToString();
                conType = DGVcons.CurrentRow.Cells[3].Value.ToString();

                PL.Consultation.Delete u = new PL.Consultation.Delete();
                u.Show();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_consultations();
            if (dt.Rows.Count > 0)
            {
                DGVcons.DataSource = dt;
            }
            else
            {
                MessageBox.Show("List is Empty ...");
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = crud.search_consultation(search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVcons.DataSource = dt;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            PL.Consultation.Add h = new PL.Consultation.Add();
            h.Show();
            Close();
        }

        private void appointbtn_Click(object sender, EventArgs e)
        {
            if (DGVcons.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVcons.CurrentRow.Cells[0].Value.ToString();

                PL.Appointment.Home add = new PL.Appointment.Home();
                add.Show();
                Close();
            }
        }

        private void treatbtn_Click(object sender, EventArgs e)
        {
            if (DGVcons.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVcons.CurrentRow.Cells[0].Value.ToString();
                
                PL.Treatment.Add add = new PL.Treatment.Add();
                add.Show();
                Close();
            }
        }

        private void surgerybtn_Click(object sender, EventArgs e)
        {
            if (DGVcons.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVcons.CurrentRow.Cells[0].Value.ToString();

                PL.Surgery.Add add = new PL.Surgery.Add();
                add.Show();
                Close();
            }
        }
    }
}
