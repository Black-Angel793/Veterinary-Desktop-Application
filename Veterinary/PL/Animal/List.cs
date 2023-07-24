using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Veterinary.PL.Owner;
using Image = System.Drawing.Image;

namespace Veterinary.PL.Animal
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
        public static string AN;
        public static string Species;
        public static string Breed;
        public static string BD;
        public static string Sex;
        public static string color;
        public static string weight;
        public static string MC;
        public static string VS;
        public static string owner;
        public static string pic;

        private void List_Load(object sender, EventArgs e)
        {
            
            dt = crud.list_animals();
            if (dt.Rows.Count > 0)
            {
                DGVanimal.DataSource = dt;
                //Datagridview Header 
                DGVanimal.Columns[0].HeaderText = "Identification";
                DGVanimal.Columns[1].HeaderText = "Animal Name";
                DGVanimal.Columns[2].HeaderText = "Species";
                DGVanimal.Columns[3].HeaderText = "Breed";
                DGVanimal.Columns[4].HeaderText = "BirthDate";
                DGVanimal.Columns[5].HeaderText = "Sex";
                DGVanimal.Columns[6].HeaderText = "Color";
                DGVanimal.Columns[7].HeaderText = "Weight";
                DGVanimal.Columns[8].HeaderText = "Medical Condition";
                DGVanimal.Columns[9].HeaderText = "Vaccination Status";
                DGVanimal.Columns[11].HeaderText = "Owner";
            }
            else
            {
                MessageBox.Show("List is Empty...");
            }


            //Add a new Byte[] Column.
            dt.Columns.Add("Image", Type.GetType("System.Byte[]"));

            // Load the images from the file paths and store them in the DataTable
            foreach (DataRow row in dt.Rows)
            {
                string imagePath = row["PetPicture"].ToString();
                if (File.Exists(imagePath))
                {
                    using (Image image = Image.FromFile(imagePath))
                    {
                        row["Image"] = File.ReadAllBytes(row["PetPicture"].ToString());
                    }
                }
            }

            // Bind the DataTable to the DataGridView
            DGVanimal.DataSource = dt;

            // Set the image column to display images
            DataGridViewImageColumn imageColumne = (DataGridViewImageColumn)DGVanimal.Columns["Image"];
            imageColumne.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVanimal.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row ");
            }
            else
            {
                id = DGVanimal.CurrentRow.Cells[0].Value.ToString();
                AN = DGVanimal.CurrentRow.Cells[1].Value.ToString();
                Species = DGVanimal.CurrentRow.Cells[2].Value.ToString();
                Breed = DGVanimal.CurrentRow.Cells[3].Value.ToString();
                BD = DGVanimal.CurrentRow.Cells[4].Value.ToString();
                Sex = DGVanimal.CurrentRow.Cells[5].Value.ToString();
                color = DGVanimal.CurrentRow.Cells[6].Value.ToString();
                weight = DGVanimal.CurrentRow.Cells[7].Value.ToString();
                MC = DGVanimal.CurrentRow.Cells[8].Value.ToString();
                VS = DGVanimal.CurrentRow.Cells[9].Value.ToString();
                pic = DGVanimal.CurrentRow.Cells[10].Value.ToString();
                owner = DGVanimal.CurrentRow.Cells[11].Value.ToString();


                PL.Animal.Update u = new PL.Animal.Update();
                u.Show();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVanimal.SelectedRows.Count > 1)
            {
                MessageBox.Show("Pleas Select one row !!");
            }
            else
            {
                id = DGVanimal.CurrentRow.Cells[0].Value.ToString();
                AN = DGVanimal.CurrentRow.Cells[1].Value.ToString();
                Breed = DGVanimal.CurrentRow.Cells[3].Value.ToString();

                PL.Animal.Delete u = new PL.Animal.Delete();
                u.Show();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dt = crud.list_animals();
            if (dt.Rows.Count > 0)
            {
                DGVanimal.DataSource = dt;
            }
            else
            {
                MessageBox.Show("List is Empty ...");
            }
        }

        private void search_TextChange(object sender, EventArgs e)
        {
            try
            {
                dt = crud.search_animal(search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVanimal.DataSource = dt;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            PL.Animal.Add add = new PL.Animal.Add();
            add.Show();
            Close();
        }
    }
}