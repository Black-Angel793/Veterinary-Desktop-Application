using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.PL.Account;

namespace Veterinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ML.CRUD crud = new ML.CRUD();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        List<Events> eventControls;

        private void Form1_Load(object sender, EventArgs e)
        {
            doctorname.Text = Login.un;
            dt = crud.user_role(doctorname.Text);

            dt2 = crud.eventday();

            // Create controls 
            foreach (DataRow row in dt2.Rows)
            {
                Veterinary.Events control = new Veterinary.Events();
                control.PopulateFromRow(row);

                flowLayoutPanel1.Controls.Add(control);
            }
        }
        private void ownerbtn_Click(object sender, EventArgs e)
        {
            PL.Owner.List home = new PL.Owner.List();
            home.Show();
            Hide();
        }

        private void animalbtn_Click(object sender, EventArgs e)
        {
            PL.Animal.List home = new PL.Animal.List();
            home.Show();
            Hide();
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            PL.Appointment.Home home = new PL.Appointment.Home();
            home.Show();
            Hide();
        }

        private void consultationbtn_Click(object sender, EventArgs e)
        {
            PL.Consultation.List list = new PL.Consultation.List();
            list.Show();
            Hide();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            PL.Payment.Payment payment = new PL.Payment.Payment();
            payment.Show(); 
            Hide();
        }

        private void storebtn_Click(object sender, EventArgs e)
        {
            PL.Store.List list = new PL.Store.List();
            list.Show();
            Hide();
        }

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            PL.Purchase.Purchase purchase = new PL.Purchase.Purchase();
            purchase.Show();
            Hide();
        }

        private void pensbtn_Click(object sender, EventArgs e)
        {
            PL.Pens.Pens pens = new PL.Pens.Pens();
            pens.Show();
            Hide();
        }

        private void treatmentbtn_Click(object sender, EventArgs e)
        {
            PL.Treatment.List list = new PL.Treatment.List();
            list.Show();
            Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void medbtn_Click(object sender, EventArgs e)
        {
            PL.Medication.List list = new PL.Medication.List(); 
            list.Show();
            Hide();
        }
    }
}
