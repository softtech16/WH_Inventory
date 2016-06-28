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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            this.Hide();
            product.ShowDialog();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.ShowDialog();
        }

        private void btnstockin_Click(object sender, EventArgs e)
        {
            StockIn stockin = new StockIn();
            this.Hide();
            stockin.ShowDialog();
        }

        private void btnstockout_Click(object sender, EventArgs e)
        {
            StockOut stockout = new StockOut();
            this.Hide();
            stockout.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.ShowDialog();
        }
    }
}
