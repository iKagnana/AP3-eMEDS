﻿using System;
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

        private MedecinController medecinController = new MedecinController();
        public Login()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.emailTxt.Text) || String.IsNullOrEmpty(this.passwordTxt.Text))
            {
                MessageBox.Show("Certaines informations ne sont pas bonnes, vérifiez bien vos informations.");
                return;
            }

            Medecin medecin = new Medecin(this.emailTxt.Text, this.passwordTxt.Text);

            bool result = medecinController.Login(medecin);
            if (result)
            {
                MessageBox.Show("Connexion réussie.");
                Menu menu = new Menu();
                menu.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Identifiants invalides");
            }
            Console.WriteLine(result);
        }
    }
}
