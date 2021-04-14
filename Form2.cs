using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDMS
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        public void logout_click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        public void viewCustomerDatabase_click(object sender, EventArgs e)
        {
            DatabaseForm databaseForm = new DatabaseForm();
            databaseForm.Show();
            this.Close();
        }

        public void newCustomer_click(object sender, EventArgs e)
        {
            NewCustForm newCust = new NewCustForm();
            newCust.Show();
            this.Close();
        }

        public void updateBtn_click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm();
            update.Show();
            this.Close();
        }

        public void deleteBtn_click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            delete.Show();
            this.Close();
        }

       
    }
}
