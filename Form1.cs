using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TDMS
{
    public partial class LoginForm : Form
    {

                
        public LoginForm()
        {
            InitializeComponent();
        }

        public void login(object sender, EventArgs e)
        {
            try {
                //checking if user info entered in password and username boxes matches an entry in the database
                string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
                string sql = "SELECT * FROM login where username= '" + userNameTextBox.Text + "' and password= '" + passTextBox.Text + "'";
                SqlConnection con = new SqlConnection(conString);
                int j = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                dataAdapt.Fill(dt);
                j = dt.Rows.Count;
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
                
            }//will throw an error if something was incorrect
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
    }
    
}
