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
    public partial class NewCustForm : Form
    {

        MySqlConnection con = new MySqlConnection();

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

                //collecting data entered from user and entering it into database
                Customer newCust = new Customer(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text,
                                                   strAdd1TextBox.Text, strAdd2TextBox.Text, cityTextBox.Text,
                                                   provinceTextBox.Text,Convert.ToInt32(countryCodeTextBox.Text),
                                                   Convert.ToInt32(phoneTextBox.Text));
                
                string insertQuery = "INSERT INTO dataBaseName(" +
                                        "FirstName,LastName," +
                                        "Email,PhoneNumber," +
                                        "StreetAddress1," +
                                        "countrycode,City," +
                                        "Province,StreetAddress2" +
                                        ")VALUES('" +
                                        newCust.getFirstName() + "','" + newCust.getLastName() + 
                                        "','" + newCust.getEmail() + "','" + newCust.getPhoneNumber() 
                                        + "','" + newCust.getStreetAdd1() + "','" + newCust.getCountryCode() +
                                        "','" + newCust.getCity() + "','" + newCust.getProvince() 
                                        + "','" + newCust.getStreetAdd2() + ")";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(insertQuery, con);
                MySqlDataReader readData;
                readData = cmd.ExecuteReader();


                PlanForm planForm = new PlanForm();
                planForm.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
         
    }
}
