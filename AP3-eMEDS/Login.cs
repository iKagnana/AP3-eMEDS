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
    public partial class Login : Form
    {

        private UserController userController = new UserController();
        public Login(string cat)
        {
            InitializeComponent();
            this.labelCat.Text = cat;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.emailTxt.Text) || String.IsNullOrEmpty(this.passwordTxt.Text))
            {
                MessageBox.Show("Certaines informations ne sont pas bonnes, vérifiez bien vos informations.");
                return;
            }

            User user = new User(this.emailTxt.Text, this.passwordTxt.Text);

            string result = userController.Login(user);
            switch (result)
            {
                case "LoggedIn":
                    MessageBox.Show("Vous êtes connecté !");
                    break;
                case "Waiting status":
                    MessageBox.Show("Votre inscription est toujours en attente.");
                    break;
                case "Invalid status":
                    MessageBox.Show("Votre compte a été refusé par nos services.");
                    break;
                case "Invalid user authentification":
                    MessageBox.Show("Vos identifiants sont invalides.");
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
