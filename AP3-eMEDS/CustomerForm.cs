using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_eMEDS
{
    public partial class CustomerForm : Form
    {
        private Customer _customer;
        private UserController _userController = new UserController();

        public CustomerForm()
        {
            InitializeComponent();
        }

        // function to test if no errors in the form 
        private bool ValideForm(Customer customer)
        {
            // valid email ?
            var match = Regex.Match(customer.Email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
            Console.WriteLine(match.Success);
            if (!match.Success)
            {
                return false;
            }

            Console.WriteLine(customer.ValidCustomer);
            
            // check if empty values
            return customer.ValidCustomer;

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            _customer = new Customer(this.emailTxt.Text,
                                     this.passwordTxt.Text,
                                     this.addressTxt.Text,
                                     this.nameTxt.Text,
                                     this.siretTxt.Text,
                                     Status.Waiting
                                     );

            if (_userController.UniqueEmail(this.emailTxt.Text))
            {
                MessageBox.Show("Attention cet email existe déjà !");
                return;
            }

            if (!ValideForm(_customer))
            {
                MessageBox.Show("Certaines informations ne sont pas bonnes, vérifiez bien vos informations.");
                return;
            }


            int result = _userController.AddCustomer(_customer);
            if (result == 0)
            {
                MessageBox.Show("Votre demande n'a pas pu être prise en compte");
            }
            else if (result == 1)
            {
                MessageBox.Show("Votre demande a été prise en compte, elle sera traité sous peu.");
                this.Close();
            }
        }
    }
}
