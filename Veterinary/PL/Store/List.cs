using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Store
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
        public static string pn;
        public static string qts;
        public static string price;

        private void List_Load(object sender, EventArgs e)
        {
            dt = crud.list_products();
            if (dt.Rows.Count > 0)
            {
                DGVanimal.DataSource = dt;

                //Datagridview Header 
                DGVanimal.Columns[0].HeaderText = "Identification";
                DGVanimal.Columns[1].HeaderText = "Product Name";
                DGVanimal.Columns[2].HeaderText = "Quantity in Stock";
                DGVanimal.Columns[3].HeaderText = "Price";
            }
            else
            {
                MessageBox.Show("List est Vide");
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            PL.Store.Add add = new PL.Store.Add();
            add.Show();
            Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVanimal.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne ");
            }
            else
            {
                id = DGVanimal.CurrentRow.Cells[0].Value.ToString();
                pn = DGVanimal.CurrentRow.Cells[1].Value.ToString();
                qts = DGVanimal.CurrentRow.Cells[2].Value.ToString();
                price = DGVanimal.CurrentRow.Cells[3].Value.ToString();

                PL.Store.Update update = new PL.Store.Update();
                update.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVanimal.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne ");
            }
            else
            {
                id = DGVanimal.CurrentRow.Cells[0].Value.ToString();
                pn = DGVanimal.CurrentRow.Cells[1].Value.ToString();
                price = DGVanimal.CurrentRow.Cells[3].Value.ToString();

                PL.Store.Delete delete = new PL.Store.Delete();
                delete.Show();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_products();
            if (dt.Rows.Count > 0)
            {
                DGVanimal.DataSource = dt;

                //Datagridview Header 
                DGVanimal.Columns[0].HeaderText = "Identification";
                DGVanimal.Columns[1].HeaderText = "Product Name";
                DGVanimal.Columns[2].HeaderText = "Quantity in Stock";
                DGVanimal.Columns[3].HeaderText = "Price";
            }
            else
            {
                MessageBox.Show("List est Vide");
            }
        }

        private void search_TextChange(object sender, EventArgs e)
        {
            try
            {
                dt = crud.search_product(search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVanimal.DataSource = dt;
        }
    }
}
