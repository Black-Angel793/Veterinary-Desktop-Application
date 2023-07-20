using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Appointment
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        int year, month;
        public static int sy, sm;

        private void Home_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            month = now.Month;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            MYL.Text = monthname + " " + year;

            sy = year;
            sm = month;

            //Start of the month
            DateTime startofthemonth = new DateTime(year, month,1) ;

            //count the days of the month
            int days = DateTime.DaysInMonth(year, month) ;

            //convert startofthemonth to int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);
            }

            //blank usercontrol
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            PL.Appointment.List list = new PL.Appointment.List();
            list.Show();
            this.Close();
        }

        private void Previousbtn_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //decrement month to previous month
            month--;
            if (month <1)
            {
                year--;
                month = 12;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            MYL.Text = monthname + " " + year;

            //Start of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //count the days of the month
            int days = DateTime.DaysInMonth(year, month);

            //convert startofthemonth to int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);
            }

            //blank usercontrol
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

           

            //increment month to next one
            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            MYL.Text = monthname + " " + year;

            //Start of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //count the days of the month
            int days = DateTime.DaysInMonth(year, month);

            //convert startofthemonth to int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);
            }

            //blank usercontrol
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

    }
}