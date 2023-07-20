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

namespace Veterinary.PL.Medication
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
        public static string MN;
        public static string Des;
        public static string Dosform;

        private void List_Load(object sender, EventArgs e)
        {
            dt = crud.list_medications();
            if (dt.Rows.Count > 0)
            {
                DGVMed.DataSource = dt;
                //Datagridview Header 
                DGVMed.Columns[0].HeaderText = "Identification";
                DGVMed.Columns[1].HeaderText = "Medication Name";
                DGVMed.Columns[2].HeaderText = "Description";
                DGVMed.Columns[3].HeaderText = "Dosage Form";
            }
            else
            {
                MessageBox.Show("List is Empty...");
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVMed.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVMed.CurrentRow.Cells[0].Value.ToString();
                MN = DGVMed.CurrentRow.Cells[1].Value.ToString();
                Des = DGVMed.CurrentRow.Cells[2].Value.ToString();
                Dosform = DGVMed.CurrentRow.Cells[3].Value.ToString();

                PL.Medication.Update u = new PL.Medication.Update();
                u.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVMed.SelectedRows.Count > 1)
            {
                MessageBox.Show("Pleas Select one row !!");
            }
            else
            {
                id = DGVMed.CurrentRow.Cells[0].Value.ToString();
                MN = DGVMed.CurrentRow.Cells[1].Value.ToString();
                Des = DGVMed.CurrentRow.Cells[2].Value.ToString();

                PL.Medication.Delete u = new PL.Medication.Delete();
                u.Show();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_medications();
            if (dt.Rows.Count > 0)
            {
                DGVMed.DataSource = dt;
            }
            else
            {
                MessageBox.Show("List is Empty ...");
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            this.Close();
        }

        private void search_TextChange(object sender, EventArgs e)
        {
            try
            {
                dt = crud.search_medication(search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVMed.DataSource = dt;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            PL.Medication.Add h = new PL.Medication.Add();
            h.Show();
            this.Close();
        }
    }
}
