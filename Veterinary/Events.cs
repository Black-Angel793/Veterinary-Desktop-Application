using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary
{
    public partial class Events : UserControl
    {
        public Events()
        {
            InitializeComponent();
        }
        public DataRow EventRow { get; set; }



        public void PopulateFromRow(DataRow row)
        {
            reason.Text = row["Reason"].ToString();
            cname.Text = row["F_Name"].ToString();

            EventRow = row;

            this.Refresh();
        }

        private void starttime_Click(object sender, EventArgs e)
        {

        }
    }
}
