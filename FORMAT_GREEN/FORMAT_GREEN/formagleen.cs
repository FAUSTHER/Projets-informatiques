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
    public partial class formagleen : Form
    {
        public formagleen()
        {
            InitializeComponent();
        }

        int stt = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            stt += 1;
            chargement.Value = stt;
            if(chargement.Value == 100)
            {
                chargement.Value = 0;
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void formagleen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
