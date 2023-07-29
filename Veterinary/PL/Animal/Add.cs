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

                MessageBox.Show("L'animal a été ajouté avec succès !!");

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
                    breed.Items.AddRange(new string[] { "Siamois", "Maine Coon", "Persan", "Bengal", "British Shorthair", "Bleu Russe", "Autre" });
                    break;
                case "Dog":
                    breed.Items.AddRange(new string[] { "Labrador Retriever", "Berger Allemand", "Golden Retriever", "Bulldog", "Rottweiler", "Husky Siberien", "Autre" });
                    break;
                case "Bird":
                    breed.Items.AddRange(new string[] { "Perruche", "Calopsitte", "Canari", "Poulet", "Canard", "perroquet", "Autre" });
                    break;
                case "Sheep":
                    breed.Items.AddRange(new string[] { "Ouled Djellal", "D'men", "El Hamra","Srandi","Tazegrawet","Autre" });
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

        private void Return_Click(object sender, EventArgs e)
        {
            PL.Animal.List home = new PL.Animal.List();
            home.Show();
            Close();
        }
    }
}
