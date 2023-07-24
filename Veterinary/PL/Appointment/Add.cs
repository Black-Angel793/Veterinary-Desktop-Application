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


namespace Veterinary.PL.Appointment
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dt1 = new DataTable();

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

            ADate.Text = PL.Appointment.Home.sm + "/" + UserControlDays.sd + "/" + PL.Appointment.Home.sy;
        }

        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                crud.insert_appointment(ADate.Text, ST.Text, ET.Text, Reason.Text, Notes.Text,int.Parse(id_c.Text));

                MessageBox.Show("Appointment Added Successfully !!");

                PL.Appointment.Home list = new PL.Appointment.Home();
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
            PL.Appointment.Home home = new PL.Appointment.Home();
            home.Show();
            Close();
        }

        private void ET_TextChanged(object sender, EventArgs e)
        {

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
