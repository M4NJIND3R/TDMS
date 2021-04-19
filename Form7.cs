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
    public partial class DeleteForm : Form
    {
        
        public DeleteForm()
        {
            InitializeComponent();
        }

        public void search_Click(object sender, EventArgs e)
        {
                                                     
            try
            {
                string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                //will search for entry match in the database based on email the user entered
                string searchQuery = "SELECT * FROM cust WHERE Email=" + int.Parse(emailBox.Text);
                SqlCommand cmd = new SqlCommand(searchQuery, con);
                SqlDataReader dataRead;
                dataRead = cmd.ExecuteReader();
                
            }
            catch(Exception ex)
            {
                //will show the rest of the user info if confirmed
                MessageBox.Show("error:" + ex.Message);
                delete.Visible = true;
                firstNameLabel.Visible = true;
                lastNameLabel.Visible = true;
                emailLabel.Visible = true;
                phoneLabel.Visible = true;
                streetAdd1Label.Visible = true;
            }
        }
        //removing the selected user from the database, using their email
        public void unsbscribe_Click(object sender, EventArgs e)
        {
            try
            {
                //removing selected user from the database
                string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string deleteQuery = "DELETE FROM cust WHERE email='" + this.emailBox.Text + "';";

                con.Open();

                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                SqlDataReader dataRead;
                dataRead = cmd.ExecuteReader();

                //ask to confirm the removal if this account
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
                    //will ask for reselection if no was chosen
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

        public void cancel_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
    }
    
}
