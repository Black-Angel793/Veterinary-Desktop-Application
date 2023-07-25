using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Surgery
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        ML.CRUD updt = new ML.CRUD();

        private void Update_Load(object sender, EventArgs e)
        {
            id.Text = List.id;
            SDate.Text = List.DS;
            SN.Text = List.PS;
            AT.Text = List.AT;
            notes.Text = List.notes;
            id_c.Text = List.consult;
        }
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_surgery(int.Parse(id.Text), SDate.Text,SN.Text,AT.Text,notes.Text, int.Parse(id_c.Text));

                MessageBox.Show("Information Updated successfully !!!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            PL.Surgery.List home = new PL.Surgery.List();
            home.Show();
            Close();    
        }

        private void DataGridViewconsult_Click(object sender, EventArgs e)
        {
            if (DataGridViewconsult.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_c.Text = DataGridViewconsult.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
