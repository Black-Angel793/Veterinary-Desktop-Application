using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;

namespace Veterinary.PL.Appointment
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        public static string sd;

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays)
        {
            labeldays.Text = numdays+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            sd = labeldays.Text;
            PL.Appointment.Add add = new PL.Appointment.Add();
            add.Show();
        }

    }
}
