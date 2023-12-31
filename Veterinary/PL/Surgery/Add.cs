﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;

namespace Veterinary.PL.Surgery
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dt1 = new DataTable();

        private void Add_Load(object sender, EventArgs e)
        {
            id_c.Text = PL.Consultation.List.id;

            dt1 = crud.list_consultations();
            if (dt1.Rows.Count > 0)
            {
                DataGridViewconsult.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("list est vide");
            }
        }

        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                crud.insert_surgery(SDate.Text, SN.Text,AT.Text,notes.Text,int.Parse(id_c.Text));

                MessageBox.Show("L'intervention chirurgicale a été ajoutée avec succès. !!");

                PL.Surgery.List list = new PL.Surgery.List();
                list.Show();
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
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_c.Text = DataGridViewconsult.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
