using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Veterinary.ML;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Image = System.Drawing.Image;

namespace Veterinary.PL.Animal
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dt_owner = new DataTable();
        private void Add_Load(object sender, EventArgs e)
        {
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;

            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            // Display the names in the CheckedListBox
            dt_owner = crud.OwnersName();
            owner.DataSource = dt_owner;
            owner.DisplayMember = "OwnerName";
            owner.ValueMember = "Id_Owner";

        }
        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                string location = ConfigurationManager.AppSettings["ImageLocation"];

                if (!Directory.Exists(location))
                {
                    Directory.CreateDirectory(location);
                }

                string path = Path.Combine(location, AN.Text + ".jpg");
                
                crud.insert_animal(AN.Text, Species.Text,breed.Text,DateTime.Parse(Birthdate.Text),sex.Text, color.Text,float.Parse(weight.Text), MC.Text,VS.Text,path,(int)owner.SelectedValue);

                Image a = image.Image;
                a.Save(path);

                MessageBox.Show("Animal Added Successfully !!");

                PL.Animal.List list = new PL.Animal.List();
                list.Show();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void importbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Select Image";
            d.Filter = "(*.jpg;*.png;*.jpeg) | *.jpg;*.png;*.jpeg";
            PictureBox p = sender as PictureBox;
            DialogResult dr = new DialogResult();
            dr = d.ShowDialog();
            if (dr == DialogResult.OK)
            {
                image.Image = Image.FromFile(d.FileName);
            }
        }

        private void Species_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the current items in the breed dropbox
            breed.Items.Clear();

            // Get the selected species
            string selectedSpecies = Species.SelectedItem.ToString();

            // Populate the breed dropbox based on the selected species
            switch (selectedSpecies)
            {
                case "Cat":
                    breed.Items.AddRange(new string[] { "Siamese", "Maine Coon", "Persian", "Bengal", "British Shorthair", "Russian Blue", "Other" });
                    break;
                case "Dog":
                    breed.Items.AddRange(new string[] { "Labrador Retriever", "German Shepherd", "Golden Retriever", "Bulldog", "Rottweiler", "Siberian Husky", "Other" });
                    break;
                case "Bird":
                    breed.Items.AddRange(new string[] { "Parakeet", "Cockatiel", "Canary", "Chicken", "Duck", "Other" });
                    break;
                case "Sheep":
                    breed.Items.AddRange(new string[] { "Merino", "Suffolk", "Shropshire","Other" });
                    break;
                case "Horse":
                    breed.Items.AddRange(new string[] { "Arabian", "Friesian", "Andalusian", "American Paint Horse", "Thoroughbred", "Other" });
                    break;
                case "Rabbit":
                    breed.Items.AddRange(new string[] { "Holland Lop", "Netherland Dwarf", "Mini Rex", "Other" });
                    break;
                case "Hamster":
                    breed.Items.AddRange(new string[] { "Hamster", "Guinea Pig", "Golden Hamster", "Other" });
                    break;
                default:
                    // Handle any other species or empty selection if needed
                    break;
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Close();
        }
    }
}
