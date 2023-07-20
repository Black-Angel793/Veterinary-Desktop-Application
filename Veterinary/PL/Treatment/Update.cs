using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;

namespace Veterinary.PL.Treatment
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        ML.CRUD updt = new ML.CRUD();
        DataTable dtc = new DataTable();
        private void Update_Load(object sender, EventArgs e)
        {
            dtc = updt.list_consultations();
            if (dtc.Rows.Count > 0)
            {
                DataGridViewConsult.DataSource = dtc;
            }
            else
            {
                MessageBox.Show("list vide");
            }

            id.Text = List.id;
            SDate.Text = List.SD;
            EDate.Text = List.ED;
            Inst.Text = List.Ins;
            Notes.Text = List.notes;
            id_c.Text = List.consultation;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_treatment(int.Parse(id.Text), SDate.Text, EDate.Text,Inst.Text, Notes.Text, int.Parse(id_c.Text));

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
            Form1 home = new Form1();
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
