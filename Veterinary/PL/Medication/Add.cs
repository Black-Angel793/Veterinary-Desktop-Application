﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinary.PL.Medication
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Confirme_Click(object sender, EventArgs e)
        {
            try
            {
                ML.CRUD crud = new ML.CRUD();

                crud.insert_medication(MN.Text, des.Text, dosage.Text);

                MessageBox.Show("Le médicament a été ajouté avec succès !!");

                PL.Medication.List list = new PL.Medication.List();
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
            PL.Medication.List form1 = new PL.Medication.List();
            form1.Show();
            Close();
        }
    }
}
