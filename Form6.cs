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
    public partial class UpdateForm : Form
    {
        MySqlConnection con = new MySqlConnection();
        public UpdateForm()
        {
            InitializeComponent();
        }

        public void submit_click(Object Sender, EventArgs e)
        {

            try
            {
                //adding update query
                string updateQuery = "UPDATE customer.DataBaseName SET FirstName='" + this.firstNameTextBox.Text + "',LastName='" + this.lastNameTextBox.Text + "',Email='" + this.emailTextBox.Text + "',PhoneNumber='" + this.phoneTextBox.Text + "',StreetAddress1='" + this.strAdd1TextBox.Text + "',StreetAddress2='" + this.strAdd2TextBox.Text + "',City='" + this.cityTextBox.Text + "',province='" + this.provinceTextBox.Text + "' WHERE Email='" + this.emailTextBox.Text + "';";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                MySqlDataReader dataRead;
                dataRead = cmd.ExecuteReader();

                //confirming changes to entry

                var reply = MessageBox.Show("Are you sure you want to continue?", "", MessageBoxButtons.YesNo);
                if (reply.ToString().ToLower().Equals("yes"))
                {
                    MessageBox.Show("Customer has been updated");
                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please reselect");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        public void cancel_click(Object Sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }


    }
}
