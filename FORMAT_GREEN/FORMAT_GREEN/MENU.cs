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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Membres mb = new Membres();
            mb.Show();
            this.Hide();    
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Membres mb = new Membres();
            mb.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            localisation loc = new localisation();
            loc.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            localisation loc = new localisation();
            loc.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Partenaria pat = new Partenaria();
            pat.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Partenaria pat = new Partenaria();
            pat.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Etablissements et = new Etablissements();
            et.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Etablissements et = new Etablissements();
            et.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Scan sc = new Scan();
            sc.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Scan sc = new Scan();
            sc.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Backup bk = new Backup();
            bk.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Backup bk = new Backup();
            bk.Show();
            this.Hide();
        }
    }
}
