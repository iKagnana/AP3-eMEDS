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
    public partial class ChangePwForm : Form
    {
        private readonly MedecinController controller = new MedecinController();
        private int idMedecin;
        public ChangePwForm(int id)
        {
            InitializeComponent();
            this.idMedecin = id;
        }

        private void changePwBtn_Click(object sender, EventArgs e)
        {
            RequestStatus status = controller.UpdateMedecinPassword(this.pwTxt.Text, idMedecin);
            if (status.success)
            {
                MessageBox.Show("Le mot de passe a bien été modifié");
                this.Close();
            } else
            {
                MessageBox.Show("Il y a eu une erreur dans la modification du mot de passe");
            }
        }
    }
}
