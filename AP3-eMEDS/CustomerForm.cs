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
        private List<string> fieldsError = new List<string>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        // function to test if no errors in the form 
        private bool ValideForm(Customer customer)
        {

            // valid siret ?
            var validSiret = Regex.Match(customer.Siret, "^\\d{14}$");
            if (!validSiret.Success)
            {
                // add error
                helperTextSiret.Text = "Votre siret doit contenir 14 chiffres";
                this.fieldsError.Add("siret");
            } else
            {
                // remove error
                helperTextSiret.Text = "";
                this.fieldsError.RemoveAt(this.fieldsError.IndexOf("siret"));
            }

            // valid email ?
            var match = Regex.Match(customer.Email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
            if (!match.Success)
            {
                // add error
                helperTextEmail.Text = "Vérifier que votre email soit valide";
                this.fieldsError.Add("email");
            } else
            {
                // remove error
                helperTextEmail.Text = "";
                this.fieldsError.RemoveAt(this.fieldsError.IndexOf("email"));
            }

            // valid password ? 
            var validPass = Regex.Match(customer.Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$");
            if (!validPass.Success)
            {
                // add error
                helperTextPass.Text = "Votre mot de passe doit contenir au minimum 8 caractères, 1 majuscule, 1 minuscule, 1 chiffre et un caractère spécial";
                this.fieldsError.Add("password");
            } else
            {
                // remove error
                helperTextPass.Text = "";
                this.fieldsError.RemoveAt(this.fieldsError.IndexOf("password"));
            }
            
            // check if empty values
            return this.fieldsError.Count == 0 && customer.ValidCustomer;

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
