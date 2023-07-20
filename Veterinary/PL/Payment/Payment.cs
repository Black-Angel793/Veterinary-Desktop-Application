using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Payment
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dtc = new DataTable();
        DataTable dtp = new DataTable();

        private void Payment_Load(object sender, EventArgs e)
        {
            dtc = crud.list_owner();
            if (dtc.Rows.Count > 0)
            {
                DataGridViewClient.DataSource = dtc;

                //Datagridview Header 
                DataGridViewClient.Columns[0].HeaderText = "Identification";
                DataGridViewClient.Columns[1].HeaderText = "First Name";
                DataGridViewClient.Columns[2].HeaderText = "Last Name";
                DataGridViewClient.Columns[3].HeaderText = "BirthDate";
                DataGridViewClient.Columns[4].HeaderText = "Email";
                DataGridViewClient.Columns[5].HeaderText = "Adress";
                DataGridViewClient.Columns[6].HeaderText = "Phone";
            }
            else
            {
                MessageBox.Show("List is Empty ");
            }

            dtp = crud.list_payment();
            if (dtp.Rows.Count > 0)
            {
                DataGridViewPayment.DataSource = dtp;

                //Datagridview Header 
                DataGridViewClient.Columns[0].HeaderText = "Identification";
                DataGridViewClient.Columns[1].HeaderText = "Date Payment";
                DataGridViewClient.Columns[2].HeaderText = "Payment Amount";
                DataGridViewClient.Columns[3].HeaderText = "consultation Id";
            }
            else
            {
                MessageBox.Show("List is Empty");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                crud.insert_payment(float.Parse(amount.Text), int.Parse(id_c.Text));
                MessageBox.Show("Payment Added Successfully!!!");
                dtp = crud.list_payment();
                DataGridViewPayment.DataSource = dtp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                crud.update_payment(int.Parse(id_p.Text),float.Parse(amount.Text), int.Parse(id_c.Text));
                MessageBox.Show("Payment Updated Successfully!!!");
                dtp = crud.list_payment();
                DataGridViewPayment.DataSource = dtp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this payment ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    crud.delete_payment(int.Parse(id_p.Text));
                    MessageBox.Show("Deleted Successfully !!!");
                    dtp = crud.list_payment();
                    DataGridViewPayment.DataSource = dtp;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void DataGridViewClient_Click(object sender, EventArgs e)
        {
            if (DataGridViewClient.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_c.Text = DataGridViewClient.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void DataGridPayment_Click(object sender, EventArgs e)
        {
            if (DataGridViewPayment.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_p.Text = DataGridViewPayment.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
