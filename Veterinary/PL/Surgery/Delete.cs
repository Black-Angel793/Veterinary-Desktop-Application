﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.PL.Surgery
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            id.Text = List.id;
            SN.Text = List.PS;
            consult.Text = List.consult;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            ML.CRUD del = new ML.CRUD();
            try
            {
                del.delete_surgery(int.Parse(id.Text));
                MessageBox.Show("supprimé avec succès !!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
