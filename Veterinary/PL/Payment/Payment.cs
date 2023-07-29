using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        decimal prices;
        decimal Rests = 0;

        private void Payment_Load(object sender, EventArgs e)
        {
            dtc = crud.list_consultations();
            if (dtc.Rows.Count > 0)
            {
                DataGridViewConsult.DataSource = dtc;

                //Datagridview Header 
                DataGridViewConsult.Columns[0].HeaderText = "Identification";
                DataGridViewConsult.Columns[1].HeaderText = "Consultation Date";
                DataGridViewConsult.Columns[2].HeaderText = "Diagnosis";
                DataGridViewConsult.Columns[3].HeaderText = "Price";
                DataGridViewConsult.Columns[4].HeaderText = "Animal ID";
                DataGridViewConsult.Columns[5].HeaderText = "Consultation Type";
            }
            else
            {
                MessageBox.Show("List est Vide ");
            }

            dtp = crud.list_payment();
            if (dtp.Rows.Count > 0)
            {
                DataGridViewPayment.DataSource = dtp;

                //Datagridview Header 
                DataGridViewPayment.Columns[0].HeaderText = "Identification";
                DataGridViewPayment.Columns[1].HeaderText = "Date Payment";
                DataGridViewPayment.Columns[2].HeaderText = "Payment Amount";
                DataGridViewPayment.Columns[3].HeaderText = "consultation Id";
            }
            else
            {
                MessageBox.Show("List est Vide");
            }
            foreach (DataGridViewRow row in DataGridViewConsult.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                     prices = Convert.ToDecimal(row.Cells["Price"].Value.ToString());
                    
                }
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Rests = decimal.Parse(amount.Text) - prices;
            Rest.Text = Rests.ToString();
            try
            {
                crud.insert_payment(float.Parse(amount.Text), int.Parse(id_c.Text));
                MessageBox.Show("Le paiement a été ajouté avec succès!!!");

                DataTable message = crud.GetTempTableMessages();

                string lastMessage = message.Rows[0]["MessageText"].ToString();

                MessageBox.Show(lastMessage);


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
                MessageBox.Show("Le paiement a été mis à jour avec succès!!!");

                DataTable message = crud.GetTempTableMessages();

                string lastMessage = message.Rows[0]["MessageText"].ToString();

                MessageBox.Show(lastMessage);

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
                if (MessageBox.Show("Êtes-vous sûr(e) de vouloir supprimer ce paiement ?", "Supprimé", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    crud.delete_payment(int.Parse(id_p.Text));
                    MessageBox.Show("supprimé avec succès !!!");
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
            Close();
        }

        private void DataGridPayment_Click(object sender, EventArgs e)
        {
            if (DataGridViewPayment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_p.Text = DataGridViewPayment.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void DataGridViewConsult_Click(object sender, EventArgs e)
        {
            if (DataGridViewConsult.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_c.Text = DataGridViewConsult.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
