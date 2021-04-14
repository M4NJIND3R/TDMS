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


namespace TDMS
{
    public partial class LoginForm : Form
    {

        //conecting to customer database

        MySqlConnection con = new MySqlConnection();
        int j;
        public LoginForm()
        {
            InitializeComponent();
        }

        public void login(object sender, EventArgs e)
        {
            try {
                //checking if user info entered in password and username boxes matches an entry in the database

                j = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM login where username= '" + userNameTextBox.Text + "' and password= '" + passTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter dataAdapt = new MySqlDataAdapter(cmd);
                dataAdapt.Fill(dt);
                j = Convert.ToInt32(dt.Rows.Count.ToString());

                //moves to the homepage if correct, prints error message if incorrect

                if (j == 0)
                {
                    invalidUserLabel.Text = "Invalid user or password";
                }
                else
                {
                    this.Hide();
                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error");
            }
        }
    }
    
}
