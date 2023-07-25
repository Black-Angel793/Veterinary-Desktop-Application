using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Veterinary.PL.Surgery
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        ML.CRUD crud = new ML.CRUD();
        DataTable dt = new DataTable();

        public static string id;
        public static string DS;
        public static string PS;
        public static string AT;
        public static string notes;
        public static string consult;

        private void List_Load(object sender, EventArgs e)
        {
            dt = crud.list_surgeries();
            if (dt.Rows.Count > 0)
            {
                DGVsurgery.DataSource = dt;
                //Datagridview Header 
                DGVsurgery.Columns[0].HeaderText = "Identification";
                DGVsurgery.Columns[1].HeaderText = "Surgery Date";
                DGVsurgery.Columns[2].HeaderText = "Surgery Procedure";
                DGVsurgery.Columns[3].HeaderText = "Anesthesia Type";
                DGVsurgery.Columns[4].HeaderText = "Notes";
                DGVsurgery.Columns[5].HeaderText = "Consultation ID";
            }
            else
            {
                MessageBox.Show("List Empty...");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVsurgery.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please Select one row !!");
            }
            else
            {
                id = DGVsurgery.CurrentRow.Cells[0].Value.ToString();
                DS = DGVsurgery.CurrentRow.Cells[1].Value.ToString();
                PS = DGVsurgery.CurrentRow.Cells[2].Value.ToString();
                AT = DGVsurgery.CurrentRow.Cells[3].Value.ToString();
                notes = DGVsurgery.CurrentRow.Cells[4].Value.ToString();
                consult = DGVsurgery.CurrentRow.Cells[5].Value.ToString();

                PL.Surgery.Update u = new PL.Surgery.Update();
                u.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVsurgery.SelectedRows.Count > 1)
            {
                MessageBox.Show("Pleas Select one row !!");
            }
            else
            {
                id = DGVsurgery.CurrentRow.Cells[0].Value.ToString();
                DS = DGVsurgery.CurrentRow.Cells[1].Value.ToString();
                PS = DGVsurgery.CurrentRow.Cells[3].Value.ToString();

                PL.Surgery.Delete u = new PL.Surgery.Delete();
                u.Show();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            Close();
        }

        private void search_TextChange(object sender, EventArgs e)
        {
            try
            {
                dt = crud.search_surgery(search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVsurgery.DataSource = dt;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_surgeries();
            if (dt.Rows.Count > 0)
            {
                DGVsurgery.DataSource = dt;
            }
            else
            {
                MessageBox.Show("List is Empty ...");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            PL.Surgery.Add add = new PL.Surgery.Add();
            add.Show();
            Close();
        }
    }
}
