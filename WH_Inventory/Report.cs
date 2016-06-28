using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WH_Inventory
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            this.Hide();
            export.ShowDialog();
        }
    }
}
