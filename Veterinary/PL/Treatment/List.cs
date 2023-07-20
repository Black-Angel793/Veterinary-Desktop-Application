using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Treatment
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
        public static string SD;
        public static string ED;
        public static string Ins;
        public static string notes;
        public static string consultation;

        private void List_Load(object sender, EventArgs e)
        {
            dt = crud.list_treatments();
            if (dt.Rows.Count > 0)
            {
                DGVtreatment.DataSource = dt;
                //Datagridview Header 
                DGVtreatment.Columns[0].HeaderText = "Identification";
                DGVtreatment.Columns[1].HeaderText = "Start Date";
                DGVtreatment.Columns[2].HeaderText = "End Date";
                DGVtreatment.Columns[3].HeaderText = "Instructions";
                DGVtreatment.Columns[4].HeaderText = "Notes";
                DGVtreatment.Columns[5].HeaderText = "Consultation ID";
            }
            else
            {
                MessageBox.Show("List is Empty...");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVtreatment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVtreatment.CurrentRow.Cells[0].Value.ToString();
                SD = DGVtreatment.CurrentRow.Cells[1].Value.ToString();
                ED = DGVtreatment.CurrentRow.Cells[2].Value.ToString();
                Ins = DGVtreatment.CurrentRow.Cells[3].Value.ToString();
                notes = DGVtreatment.CurrentRow.Cells[4].Value.ToString();
                consultation = DGVtreatment.CurrentRow.Cells[5].Value.ToString();

                PL.Treatment.Update u = new PL.Treatment.Update();
                u.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVtreatment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Pleas Select one row !!");
            }
            else
            {
                id = DGVtreatment.CurrentRow.Cells[0].Value.ToString();
                SD = DGVtreatment.CurrentRow.Cells[1].Value.ToString();
                consultation = DGVtreatment.CurrentRow.Cells[5].Value.ToString();

                PL.Treatment.Delete u = new PL.Treatment.Delete();
                u.Show();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_treatments();
            if (dt.Rows.Count > 0)
            {
                DGVtreatment.DataSource = dt;
            }
            else
            {
                MessageBox.Show("List is Empty ...");
            }
        }

        private void search_TextChange(object sender, EventArgs e)
        {
            try
            {
                dt = crud.search_treatment(search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVtreatment.DataSource = dt;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            PL.Treatment.Add h = new PL.Treatment.Add();
            h.Show();
            this.Close();
        }

        private void tretmedbtn_Click(object sender, EventArgs e)
        {
            if (DGVtreatment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVtreatment.CurrentRow.Cells[0].Value.ToString();

                PL.MedicationTreatment.MedicationTreatment medicationTreatment = new MedicationTreatment.MedicationTreatment();
                medicationTreatment.Show();
                this.Close();
            }
            
        }
    }
}
