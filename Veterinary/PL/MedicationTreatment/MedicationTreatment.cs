using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;

namespace Veterinary.PL.MedicationTreatment
{
    public partial class MedicationTreatment : Form
    {
        public MedicationTreatment()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dtt = new DataTable();
        DataTable dtr = new DataTable();
        
        DataTable medTable = new DataTable();
        DataTable dtGridData = new DataTable();

        string medIds = string.Empty;

        private int selectedmedId;

        private void MedicationTreatment_Load(object sender, EventArgs e)
        {
            id_t.Text = PL.Treatment.List.id;

            medTable.Columns.Add("Medication ID", typeof(int));
            medTable.Columns.Add("Medication Name", typeof(string));
            medTable.Columns.Add("Description", typeof(string));
            medTable.Columns.Add("Dosage Form", typeof(string));


            // Set the DataTable as the data source for the DataGridView
            DataGridViewMedications.DataSource = medTable;

            DataTable dtm = new DataTable();
            dtm = crud.list_medications();
            foreach (DataRow dr in dtm.Rows)
            {
                string medicationId = $"{dr["Id_Medication"].ToString()}";
                string medicationName = $"{dr["NameMed"].ToString()}";

                string productInfo = $"{medicationId}: {medicationName} ";
                medications.Items.Add(productInfo);
            }


            dtt = crud.list_treatments();
            if (dtt.Rows.Count > 0)
            {
                DataGridViewTreatments.DataSource = dtt;

                //Datagridview Header 
                DataGridViewTreatments.Columns[0].HeaderText = "Identification";
                DataGridViewTreatments.Columns[1].HeaderText = "Start Date";
                DataGridViewTreatments.Columns[2].HeaderText = "End Date";
                DataGridViewTreatments.Columns[3].HeaderText = "Instructions";
                DataGridViewTreatments.Columns[4].HeaderText = "Notes";
                DataGridViewTreatments.Columns[5].HeaderText = "Client Identification";
            }
            else
            {
                MessageBox.Show("List est Vide ");
            }

            dtr = crud.list_medictreatment();
            if (dtr.Rows.Count > 0)
            {
                DataGridViewResult.DataSource = dtr;

                //Datagridview Header 
                DataGridViewResult.Columns[1].HeaderText = "Treatment ID";
                DataGridViewResult.Columns[0].HeaderText = "Medication ID";
            }
            else
            {
                MessageBox.Show("List est Vide ");
            }
        }

        HashSet<string> selectedMedications = new HashSet<string>();

        private void medications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (medications.SelectedIndex != -1)
            {
                string selectedMedInfo = medications.SelectedItem.ToString();
                string[] medInfoParts = selectedMedInfo.Split(':');

                string selectedMedId = medInfoParts[0].Trim();
                DataTable dtSelectedMed;
                int medId;

                if (int.TryParse(selectedMedId, out medId))
                {
                    dtSelectedMed = crud.GetMedByID(selectedMedId);

                    // Add the selected client ID to the HashSet
                    selectedMedications.Add(selectedMedId);

                }
                else
                {
                    // Client already selected, display a message or perform other actions
                    MessageBox.Show("Ce médicament existe déjà");
                }
                DataGridViewMedications.SelectAll();
            }
        }

        private void addmedbtn_Click(object sender, EventArgs e)
        {
            // Retrieve the selected product, quantity, and cost
            string medName = medications.Text;
            int medId;

            if (DataGridViewMedications.SelectedRows.Count > 0 && DataGridViewMedications.SelectedRows[0].Cells["Medication ID"].Value != null)
            {
                // Get ID from selected row
                medId = (int)DataGridViewMedications.SelectedRows[0].Cells["Medication ID"].Value;

                DataColumn idColumn = medTable.Columns["Medication ID"];
                medTable.PrimaryKey = new DataColumn[] { idColumn };
                DataRow row = medTable.Rows.Find(medId);

                if (row != null)
                {
                    int currid = row.Field<int>("Medication ID");
                    currid = medId;
                    row["Medication ID"] = currid;

                    string currname = row.Field<string>("Medication Name");
                    currname = medName;
                    row["Medication Name"] = currname;
                }
            }
            else
            {
                medId = Convert.ToInt32(medications.SelectedIndex) + 1;

                medTable.Rows.Add(medId, medName);
            }

            // Refresh grid
            DataGridViewMedications.DataSource = medTable;
            DataGridViewMedications.Update();
            DataGridViewMedications.Refresh();

            // Clear the input fields for the next entry
            medications.SelectedIndex = -1;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewMedications.Rows)
            {
                if (row.Cells["Medication ID"].Value != null)
                {
                    string productId = row.Cells["Medication ID"].Value.ToString();

                    medIds += productId + ",";
                }
            }

            // Remove the trailing comma
            if (!string.IsNullOrEmpty(medIds))
            {
                medIds = medIds.TrimEnd(',');

                try
                {
                    crud.insert_medictreatment(medIds, int.Parse(id_t.Text));

                    MessageBox.Show("Insertion complétée");

                    dtr = crud.list_medictreatment();

                    DataGridViewResult.DataSource = dtr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DataGridViewResult.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridViewMedications.Rows)
                {
                    if (row.Cells["Medication ID"].Value != null)
                    {
                        string medId = row.Cells["Medication ID"].Value.ToString();

                        medIds += medId + ",";

                    }
                }
                // Remove the trailing comma
                if (!string.IsNullOrEmpty(medIds))
                {
                    medIds = medIds.TrimEnd(',');

                    try
                    {
                        crud.update_medictreatment(medIds,int.Parse(id_t.Text));

                        MessageBox.Show("Les informations ont été mises à jour avec succès !!! ");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    dtr = crud.list_medictreatment();

                    DataGridViewResult.DataSource = dtr;
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Êtes-vous sûr(e) de vouloir supprimer cette opération ?", "Supprimé", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    crud.delete_medictreatment(int.Parse(id_t.Text));
                    MessageBox.Show("supprimé avec succès !!!");
                    dtr = crud.list_medictreatment();
                    DataGridViewResult.DataSource = dtr;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void DataGridViewResult_Click(object sender, EventArgs e)
        {
            if (DataGridViewResult.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_m.Text = DataGridViewResult.CurrentRow.Cells[1].Value.ToString();
                id_t.Text = DataGridViewTreatments.CurrentRow.Cells[0].Value.ToString();

                // Get selected row
                DataGridViewRow selectedRow = DataGridViewResult.SelectedRows[0];

                // Get order id
                int medId = (int)selectedRow.Cells["Id_Medication"].Value;

                // Query details
                DataTable details = crud.GetMedDetails(medId);

                // Populate product table 
                medTable.Clear();
                foreach (DataRow row1 in details.Rows)
                {
                    // Add product data to new row
                    DataRow newRow = medTable.NewRow();
                    newRow["Medication ID"] = row1["Id_Medication"];
                    newRow["Medication Name"] = row1["NameMed"];
                    newRow["Description"] = row1["Description"];
                    newRow["Dosage Form"] = row1["DosageForm"];

                    medTable.Rows.Add(newRow);
                }
            }
        }

        private void DataGridViewMedications_Click(object sender, EventArgs e)
        {
            if (DataGridViewMedications.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                selectedmedId = (int)DataGridViewMedications.CurrentRow.Cells["Medication ID"].Value;
                medications.Text = DataGridViewMedications.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void DataGridViewTreatments_Click(object sender, EventArgs e)
        {
            if (DataGridViewTreatments.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_t.Text = DataGridViewTreatments.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}


/*
 * if (DataGridViewResult.SelectedRows != null && DataGridViewResult.SelectedRows.Count > 0)
            {
                // Get selected row
                DataGridViewRow selectedRow = DataGridViewResult.SelectedRows[0];

                // Get order id
                int medId = (int)selectedRow.Cells["Id_Medication"].Value;

                // Query details
                DataTable details = crud.GetMedDetails(medId);

                // Populate product table 
                medTable.Clear();
                foreach (DataRow row1 in details.Rows)
                {
                    // Add product data to new row
                    DataRow newRow = medTable.NewRow();
                    newRow["Medication ID"] = row1["Id_Medication"];
                    newRow["Medication Name"] = row1["NameMed"];
                    newRow["Description"] = row1["Description"];
                    newRow["Dosage Form"] = row1["DosageForm"];

                    medTable.Rows.Add(newRow);
                }
            }*/