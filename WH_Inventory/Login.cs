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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string loginConnection = "datasource=localhost;port=3306;username=root;password=090807";
                MySqlConnection loginConn = new MySqlConnection(loginConnection);
                MySqlCommand LoginCommand = new MySqlCommand("select * from wh_inventory.user where username='" + this.tbxuser.Text + "' and password='" + this.tbxpass.Text + "';", loginConn);
                MySqlDataReader loginReader;
                loginConn.Open();
                loginReader = LoginCommand.ExecuteReader();
                int count = 0;
                while (loginReader.Read())
                {
                    count = count + 1;

                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successfull. Welcome! ");
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                    MessageBox.Show("Access Denied");
                loginConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
