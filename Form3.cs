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
    public partial class DatabaseForm : Form
    {

        public DatabaseForm()
        {
            InitializeComponent();
        }
        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            try {
                MySqlConnection con = new MySqlConnection();
                MySqlDataAdapter adatpterData = new MySqlDataAdapter("SELECT * FROM DataBaseName", con);
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

            
        }
       

        public void Home_click(Object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }

        
    }
}
