using System;
using System.Windows.Forms;
using System.Data.SqlClient;

/******************************
 * 
 * Author: Jon Penman
 * Student number: 200224186
 * 
 ****************************/

namespace TDMS
{
    public partial class NewCustForm : Form
    {

        
        public NewCustForm()
        {
            InitializeComponent();
        }

        public void cancel_click(Object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }

        public void next_click(Object sender, EventArgs e)
        {
            try
            {
                //calling info for database connection
                string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
                SqlConnection con = new SqlConnection(conString);

                //collecting data entered from user and entering it into database
                Customer newCust = new Customer(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text,
                                                   strAdd1TextBox.Text, strAdd2TextBox.Text, cityTextBox.Text,
                                                   provinceTextBox.Text,Convert.ToInt32(countryCodeTextBox.Text),
                                                   Convert.ToInt32(phoneTextBox.Text));
                
                string insertQuery = "INSERT INTO cust(" +
                                        "firstname,lastname," +
                                        "email,phoneNumber," +
                                        "streetAddress1," +
                                        "countrycode,city," +
                                        "province,streetAddress2" +
                                        ")VALUES('" +
                                        newCust.getFirstName() + "','" + newCust.getLastName() + 
                                        "','" + newCust.getEmail() + "','" + newCust.getPhoneNumber() 
                                        + "','" + newCust.getStreetAdd1() + "','" + newCust.getCountryCode() +
                                        "','" + newCust.getCity() + "','" + newCust.getProvince() 
                                        + "','" + newCust.getStreetAdd2() + ")";
                con.Open();

                //establishing connection for implementation of new user
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlDataReader readData;
                readData = cmd.ExecuteReader();


                PlanForm planForm = new PlanForm();
                planForm.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            finally
            {
                this.Hide();
                PlanForm planForm = new PlanForm();
                planForm.Show();
            }
        }
         
    }
}
