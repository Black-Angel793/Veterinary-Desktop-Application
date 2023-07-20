using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Veterinary.PL.Consultation
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        ML.CRUD updt = new ML.CRUD();
        DataTable dt = new DataTable();

        private void Update_Load(object sender, EventArgs e)
        {
            id.Text = List.id;
            ConDate.Text = List.CD;
            ConTime.Text = List.CT;
            observation.Text = List.Obser;
            diagnosis.Text = List.Diagn;
            id_a.Text = List.animal;
            conType.Text = List.conType;
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                updt.update_consultation(int.Parse(id.Text), ConDate.Text, ConTime.Text, observation.Text, diagnosis.Text, int.Parse(id_a.Text),int.Parse(conType.Text));

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

        private void DataGridViewAnimal_Click(object sender, EventArgs e)
        {
            if (DataGridViewAnimal.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select one row");
            }
            else
            {
                id_a.Text = DataGridViewAnimal.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
