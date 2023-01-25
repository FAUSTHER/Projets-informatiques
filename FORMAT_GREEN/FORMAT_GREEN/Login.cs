using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMAT_GREEN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CONNEXION_Click(object sender, EventArgs e)
        {
            if (Idn.Text == "" || Mdp.Text == "")
            {
                MessageBox.Show("entrer un id et un mot de passe");
            }
            else if (Idn.Text == "Admin" && Mdp.Text == "123")
            {
                this.Hide();
                MENU home = new MENU();
                home.Show();
            }
            else
            {
                MessageBox.Show("ERREUR REESSAYER SVP");
            }
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
