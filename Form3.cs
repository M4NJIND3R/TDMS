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
    public partial class DatabaseForm : Form
    {

        public DatabaseForm()
        {
            InitializeComponent();
        }
        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            try {
                //connect user to the database
                string conString = "Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=\"F: \\UNIVERSITY\\SEMESTER 2\\.NET WITH C#\\PROJECT\testing jon\\TDMS-jon_penman\\Database1.mdf\";";
                SqlConnection con = new SqlConnection(conString);
                //display the database info for the user to view
                SqlDataAdapter adatpterData = new SqlDataAdapter("SELECT * FROM cust", con);
                con.Open();
                DataSet dst = new DataSet();
                adatpterData.Fill(dst, "takes");
                dataGridView1.DataSource = dst.Tables["takes"];
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            finally
            {
                //link back to home
                this.Hide();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }

        }
       

        public void Home_click(Object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
        
            


}
}
