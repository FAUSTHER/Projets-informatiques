using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FORMAT_GREEN
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\warel\Documents\Format_grenn.mdf;Integrated Security=True;Connect Timeout=30");




        private void Nserveur_TextChanged(object sender, EventArgs e)
        {

        }

        private void local_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Chemin.Text = fbd.SelectedPath;
                local.Enabled = true;
            }
        }

        private void Bk_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            String database = Con.Database.ToString();
            try
            {
                if (Chemin.Text == string.Empty)
                {
                    MessageBox.Show("ERREUR REESSAYER CORECTEMENT" +
                        "");
                }
                else
                {

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + Chemin.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, Con);
                    scmd.ExecuteNonQuery();
                    // s.Speak("Backup taken successfully");
                    MessageBox.Show("SAUVEGARDE REUSSI", " successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bk.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Con.Close(); }
        }

        private void Emp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Nchemin.Text = ofd.FileName;
                Emp.Enabled = true;
            }
        }

        private void Recup_Click(object sender, EventArgs e)
        {
            Con.Open();
            String database = Con.Database.ToString();
            try
            {

                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, Con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + Nchemin.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, Con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, Con);
                cmd3.ExecuteNonQuery();
                // s.Speak("Database Restored successfully");
                MessageBox.Show("BASE DE DONNEES RESTOREE ", "successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bk.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Con.Close(); }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

