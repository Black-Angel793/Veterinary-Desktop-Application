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
            ADate.Text = List.AD;
            ST.Text = List.ST;
            ET.Text = List.ET;
            Reason.Text = List.Res;
            Notes.Text = List.Not;
            client.Text = List.client;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_appointment(int.Parse(id.Text), ADate.Text, ST.Text,
                    ET.Text, Reason.Text, Notes.Text, int.Parse(client.Text));

                MessageBox.Show("Information Updated successfully !!!");
                this.Close();
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
            this.Close();
        }
    }
}
