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
                crud.update_animal(int.Parse(id.Text), AN.Text, Species.Text,breed.Text, DateTime.Parse(Birthdate.Text), sex.Text, color.Text, float.Parse(weight.Text), MC.Text,
                    VS.Text, path, (int)owner.SelectedValue);

                Image a = picture.Image;

                if (a == null)
                {
                    path = null;
                }
                else
                {
                    try
                    {
                        a.Save(path);
                    }
                    catch
                    {
                        path = null;
                    }
                } 
                MessageBox.Show("Les informations ont été mises à jour avec succès !!!");
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
                    breed.Items.AddRange(new string[] { "Siamois", "Maine Coon", "Persan", "Bengal", "British Shorthair", "Bleu Russe", "Autre" });
                    break;
                case "Dog":
                    breed.Items.AddRange(new string[] { "Labrador Retriever", "Berger Allemand", "Golden Retriever", "Bulldog", "Rottweiler", "Husky Siberien", "Autre" });
                    break;
                case "Bird":
                    breed.Items.AddRange(new string[] { "Perruche", "Calopsitte", "Canari", "Poulet", "Canard", "perroquet", "Autre" });
                    break;
                case "Sheep":
                    breed.Items.AddRange(new string[] { "Ouled Djellal", "D'men", "El Hamra", "Srandi", "Tazegrawet", "Autre" });
                    break;
                case "Horse":
                    breed.Items.AddRange(new string[] { "Arabe", "Frison", "Andalou", "American Paint Horse", "Autre" });
                    break;
                case "Rabbit":
                    breed.Items.AddRange(new string[] { "Bélier Hollandais", "Nain des Pays-Bas", "Mini-Rex", "Autre" });
                    break;
                case "Hamster":
                    breed.Items.AddRange(new string[] { "Hamster", "Hamster doré", "Cochon d'Inde", "Autre" });
                    break;
                default:
                    // Handle any other species or empty selection if needed
                    break;
            }
        }
    }
}
