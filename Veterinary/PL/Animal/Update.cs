using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Veterinary.ML;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Veterinary.PL.Animal
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dt = new DataTable();
        DataTable dt_owner = new DataTable();

        private void Update_Load(object sender, EventArgs e)
        {
            id.Text = List.id;
            AN.Text = List.AN;
            Species.Text = List.Species;
            breed.Text = List.Breed;
            Birthdate.Text = List.BD;
            sex.Text = List.Sex;
            color.Text = List.color;
            weight.Text = List.weight;
            MC.Text = List.MC;
            VS.Text = List.VS;

            // Load the image and display it in the PictureBox
            string imagePath = List.pic;
            if (File.Exists(imagePath))
            {
                using (Image image = Image.FromFile(imagePath))
                {
                    picture.Image = new Bitmap(image);
                }
            }

            // Display the names in the CheckedListBox
            dt_owner = crud.OwnersName();
            owner.DataSource = dt_owner;
            owner.DisplayMember = "OwnerName";
            owner.ValueMember = "Id_Owner";

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string location = ConfigurationManager.AppSettings["ImageLocation"];

            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }
            string path = Path.Combine(location, AN.Text + ".jpg");
            try
            {
                crud.update_animal(int.Parse(id.Text), AN.Text, Species.Text,
                    breed.Text, DateTime.Parse(Birthdate.Text), sex.Text, color.Text, float.Parse(weight.Text), MC.Text,
                    VS.Text, path, (int)owner.SelectedValue);
                Image a = picture.Image;
                a.Save(path);
                MessageBox.Show("Information Updated successfully !!!");
                this.Close();
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
                picture.Image = Image.FromFile(d.FileName);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            PL.Animal.List home = new PL.Animal.List();
            home.Show();
            this.Close();
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
                    breed.Items.AddRange(new string[] { "Merino", "Suffolk", "Shropshire", "Other" });
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
    }
}
