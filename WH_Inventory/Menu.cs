using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WH_Inventory
{
    public partial class Menu : Form
    {
        public Menu(string wid)
        {
            InitializeComponent();
            lblwid.Text = wid;
            try
            {
                //for connection to database
                string menuConnection = "datasource=localhost;port=3306;username=root;password=090807";
                MySqlConnection menuConn = new MySqlConnection(menuConnection);
                //query on database getting data
                MySqlCommand MenuCommand = new MySqlCommand("select * from wh_inventory.user where wid='" + this.lblwid.Text + "';", menuConn);
                //initializing adapter to database
                MySqlDataAdapter menuAdapter = new MySqlDataAdapter();
                //initializing reader
                MySqlDataReader menuReader;
                menuConn.Open();
                //getting data from database to array
                menuAdapter.SelectCommand = MenuCommand;
                DataSet ds = new DataSet();
                menuAdapter.Fill(ds);
                //execute the reader
                menuReader = MenuCommand.ExecuteReader();

                while (menuReader.Read())
                {
                    if (ds.Tables[0].Rows[0]["allowproduct"].ToString() == "True")
                    {
                        btnproduct.Visible = true;
                    }
                    else
                        btnproduct.Visible = false;
                    if (ds.Tables[0].Rows[0]["allowstockin"].ToString() == "True")
                    {
                        btnstockin.Visible = true;
                    }
                    else
                        btnstockin.Visible = false;
                    if (ds.Tables[0].Rows[0]["allowstockout"].ToString() == "True")
                    {
                        btnstockout.Visible = true;
                    }
                    else
                        btnstockout.Visible = false;
                    if (ds.Tables[0].Rows[0]["allowreports"].ToString() == "True")
                    {
                        btnreport.Visible = true;
                    }
                    else
                        btnreport.Visible = false;
                    if (ds.Tables[0].Rows[0]["allowuser"].ToString() == "True")
                    {
                        btnuser.Visible = true;
                    }
                    else
                        btnuser.Visible = false;
                }
                menuConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
