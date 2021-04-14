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
    public partial class PlanForm : Form
    {
        MySqlConnection con = new MySqlConnection();
        public PlanForm()
        {
            InitializeComponent();
        }

        public void back_click(Object Sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }

        public void submit_click(object sender, EventArgs e)
        {
            try {
                string radioButtons = "";


                con.Open();
                if (radioButton1.Checked)
                {

                    radioButtons = "INSERT INTO DataBaseName(plan)VALUES ('Basic')";

                }
                if (radioButton2.Checked)
                {

                    radioButtons = "INSERT INTO DataBaseName(plan)VALUES ('Standard')";

                }
                if (radioButton3.Checked)
                {
                    radioButtons = "INSERT INTO DataBaseName(plan)VALUES ('Premium')";
                }
                MySqlCommand cmd = new MySqlCommand(radioButtons, con);


                cmd.ExecuteNonQuery();
                con.Close();



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
                MessageBox.Show("error");
            }

        }
    }
}
