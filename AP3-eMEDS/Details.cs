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
    public partial class Details : Form
    {
        public Details(string name, string description)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            this.textBox2.Text = description;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // TODO: change fields
        }
    }
}
