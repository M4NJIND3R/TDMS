using System;
using System.Windows.Forms;
using System.Data.SqlClient;

/****************************
 * Author:  Neh Rakeshkumar
 * Student number: 200458205
 * 
 ***************************/

namespace TDMS
{
    public partial class UpdateForm : Form
    {
        
        public UpdateForm()
        {
            InitializeComponent();
        }

        public void submit_click(Object Sender, EventArgs e)
        {
            try
            {
                //connecting user to the database 
                string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
                SqlConnection con = new SqlConnection(conString);

                //collecting entered user info

                Customer upCust = new Customer(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text,
                                                   strAdd1TextBox.Text, strAdd2TextBox.Text, cityTextBox.Text,
                                                   provinceTextBox.Text, Convert.ToInt32(countryCodeTextBox.Text),
                                                   Convert.ToInt32(phoneTextBox.Text));

                //adding update query to change info of selected user
                string updateQuery = "UPDATE cust set"  +
                                       "firstname = '" + upCust.getFirstName() + "', lastname='" + upCust.getLastName()
                                         + "',phoneNumber='" + upCust.getPhoneNumber()
                                        + "',streetAdd1='" + upCust.getStreetAdd1() + "',countrycode='" + upCust.getCountryCode() +
                                        "',city='" + upCust.getCity() + "',province='" + upCust.getProvince()
                                        + "',streetAdd2='" + upCust.getStreetAdd2() + " where email=;" + upCust.getEmail();
                con.Open();

                SqlCommand cmd = new SqlCommand(updateQuery, con);
                SqlDataReader dataRead;
                dataRead = cmd.ExecuteReader();

                //confirming changes to entry and submitting if confirmed, otherwise will ask for reselection

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
                MessageBox.Show("error:" + ex.Message);
            }
            finally
            {
                this.Hide();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
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
