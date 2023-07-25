using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Veterinary.PL.Owner
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
        public static string FN;
        public static string LN;
        public static string S;
        public static string A;
        public static string PH;

        private void List_Load(object sender, EventArgs e)
        {
            dt = crud.list_owner();
            if (dt.Rows.Count > 0)
            {
                DGVOwner.DataSource = dt;
                //Datagridview Header 
                DGVOwner.Columns[0].HeaderText = "Identification";
                DGVOwner.Columns[1].HeaderText = "Prénom";
                DGVOwner.Columns[2].HeaderText = "Nom";
                DGVOwner.Columns[3].HeaderText = "Sexe";
                DGVOwner.Columns[4].HeaderText = "Phone";
                DGVOwner.Columns[5].HeaderText = "Address";
            }
            else
            {
                MessageBox.Show("List Empty...");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVOwner.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please Select one row !!");
            }
            else
            {
                id = DGVOwner.CurrentRow.Cells[0].Value.ToString();
                FN = DGVOwner.CurrentRow.Cells[1].Value.ToString();
                LN = DGVOwner.CurrentRow.Cells[2].Value.ToString();
                S = DGVOwner.CurrentRow.Cells[3].Value.ToString();
                PH = DGVOwner.CurrentRow.Cells[4].Value.ToString();
                A = DGVOwner.CurrentRow.Cells[5].Value.ToString();

                PL.Owner.Update u = new PL.Owner.Update();
                u.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVOwner.SelectedRows.Count > 1)
            {
                MessageBox.Show("Pleas Select one row !!");
            }
            else
            {
                id = DGVOwner.CurrentRow.Cells[0].Value.ToString();
                FN = DGVOwner.CurrentRow.Cells[1].Value.ToString();
                LN = DGVOwner.CurrentRow.Cells[2].Value.ToString();

                PL.Owner.Delete u = new PL.Owner.Delete();
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
                dt = crud.search_owner(search.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVOwner.DataSource = dt;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_owner();
            if (dt.Rows.Count > 0)
            {
                DGVOwner.DataSource = dt;
            }
            else
            {
                MessageBox.Show("List is Empty ...");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            PL.Owner.Add h = new PL.Owner.Add();
            h.Show();
            Close();
        }
    }
}
