using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TDMS
{
    public partial class PlanForm : Form
    {
        
        public PlanForm()
        {
            InitializeComponent();
        }

        public void back_click(Object Sender, EventArgs e)
        {
            string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
            SqlConnection con = new SqlConnection(conString);
            string query = "delete from cust where email =  (select email from cust order by time_stamp desc limit 1);";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
        //connecting user to the database
        public void submit_click(object sender, EventArgs e)
        {
            try {
                string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
                SqlConnection con = new SqlConnection(conString);

                string radioButtons = "";

                //user selects which plan they want to subsribe to and entering the choice into the database
                con.Open();
                if (radioButton1.Checked)
                {

                    radioButtons = "update cust set plan = '" + ConnectionPlan.getPlanByName(radioButton1.Text) + "' where email = (select email from cust order by time_stamp desc limit 1);";

                }
                if (radioButton2.Checked)
                {

                    radioButtons = "update cust set plan = '" + ConnectionPlan.getPlanByName(radioButton2.Text) + "' where email = (select email from cust order by time_stamp desc limit 1);";

                }
                if (radioButton3.Checked)
                {
                    radioButtons = "update cust set plan = '"+ConnectionPlan.getPlanByName(radioButton3.Text)+"' where email = (select email from cust order by time_stamp desc limit 1);";
                }
                SqlCommand cmd = new SqlCommand(radioButtons, con);


                cmd.ExecuteNonQuery();
                con.Close();


                //ask user to confirm the selection they made
                var answer = MessageBox.Show("Are you sure the filled in Information is Accurate and you have selected desired plan ?", "", MessageBoxButtons.YesNo);
                if (answer.ToString().ToLower().Equals("yes"))
                {
                    MessageBox.Show("Customer Added Successfully");
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
    }
}
