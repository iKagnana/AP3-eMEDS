using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_eMEDS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createCBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void loginCBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login("Client");
            login.Show();
        }

        private void loginEBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login("Employé");
            login.Show();
        }
    }
}
