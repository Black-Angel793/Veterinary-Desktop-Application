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

namespace Veterinary.PL.Appointment
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
        public static string AD;
        public static string Res;
        public static string Not;
        public static string consult;

        private void List_Load(object sender, EventArgs e)
        {
            dt = crud.list_appointments();
            if (dt.Rows.Count > 0)
            {
                DGVappoint.DataSource = dt;
                //Datagridview Header 
                DGVappoint.Columns[0].HeaderText = "Identification";
                DGVappoint.Columns[1].HeaderText = "Appointment Date";
                DGVappoint.Columns[2].HeaderText = "Reason";
                DGVappoint.Columns[3].HeaderText = "Notes";
                DGVappoint.Columns[4].HeaderText = "Consultation ID";
            }
            else
            {
                MessageBox.Show("List est Vide");
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVappoint.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne ");
            }
            else
            {
                id = DGVappoint.CurrentRow.Cells[0].Value.ToString();
                AD = DGVappoint.CurrentRow.Cells[1].Value.ToString();
                Res= DGVappoint.CurrentRow.Cells[2].Value.ToString();
                Not= DGVappoint.CurrentRow.Cells[3].Value.ToString();
                consult = DGVappoint.CurrentRow.Cells[4].Value.ToString();

                PL.Appointment.Update u = new PL.Appointment.Update();
                u.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVappoint.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id = DGVappoint.CurrentRow.Cells[0].Value.ToString();
                AD = DGVappoint.CurrentRow.Cells[1].Value.ToString();
                consult = DGVappoint.CurrentRow.Cells[4].Value.ToString();

                PL.Appointment.Delete u = new PL.Appointment.Delete();
                u.Show();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_appointments();
            if (dt.Rows.Count > 0)
            {
                DGVappoint.DataSource = dt;
            }
            else
            {
                MessageBox.Show("List est Vide");
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            PL.Appointment.Home h = new PL.Appointment.Home();
            h.Show();
            Close();
        }

        private void search_TextChange(object sender, EventArgs e)
        {
            try
            {
                dt = crud.search_appointment(search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVappoint.DataSource = dt;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            PL.Appointment.Home h = new PL.Appointment.Home();
            h.Show();
            Close();
        }
    }
}
