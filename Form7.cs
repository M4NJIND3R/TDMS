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
    public partial class DeleteForm : Form
    {
        

       
        
        public DeleteForm()
        {
            InitializeComponent();
        }

        public void search_Click(object sender, EventArgs e)
        {
            //searching for database entry based on email

            
            

            //fill out additional info
            try
            {

                MySqlConnection con = new MySqlConnection();
                con.Open();
                string searchQuery = "SELECT * FROM dataBaseName WHERE Email=" + int.Parse(emailBox.Text);
                MySqlCommand cmd = new MySqlCommand(searchQuery, con);
                MySqlDataReader dataRead;
                dataRead = cmd.ExecuteReader();

                if (dataRead.Read())
                {
                    phNumTextBox.Text = dataRead.GetString("PhoneNumber");
                }
                else
                {
                    phNumTextBox.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error");
            }
        }
        //removing the selected user from the database, using their email
        public void unsbscribe_Click(object sender, EventArgs e)
        {
            try
            {
                //removing selected user from the database
                MySqlConnection con = new MySqlConnection();
                con.Open();
                string deleteQuery = "DELETE FROM customer.DataBaseName WHERE Email='" + this.emailBox.Text + "';";

                con.Open();

                MySqlCommand cmd = new MySqlCommand(deleteQuery, con);
                MySqlDataReader dataRead;
                dataRead = cmd.ExecuteReader();

                var reply = MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo);

                if (reply.ToString().ToLower().Equals("yes"))
                {
                    MessageBox.Show("Unsbscribed successfully!");
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

        public void cancel_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
    }
    
}
