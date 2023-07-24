﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;

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
            dt = updt.list_consultations();
            if (dt.Rows.Count > 0)
            {
                DataGridViewConsult.DataSource = dt;
            }
            else
            {
                MessageBox.Show("list vide");
            }

            id.Text = List.id;
            ADate.Text = List.AD;
            ST.Text = List.ST;
            ET.Text = List.ET;
            Reason.Text = List.Res;
            Notes.Text = List.Not;
            id_c.Text = List.consult;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_appointment(int.Parse(id.Text), ADate.Text, ST.Text,
                    ET.Text, Reason.Text, Notes.Text, int.Parse(id_c.Text));

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

        private void DataGridViewConsult_Click(object sender, EventArgs e)
        {
            if (DataGridViewConsult.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_c.Text = DataGridViewConsult.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
