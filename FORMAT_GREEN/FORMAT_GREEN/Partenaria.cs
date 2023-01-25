using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FORMAT_GREEN
{
    public partial class Partenaria : Form
    {
        public Partenaria()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\warel\Documents\Format_grenn.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*,text", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        rapport.Text = await sr.ReadToEndAsync();
                    }
                }
            }
        }

        private async void ecrire_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.text", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(rapport.Text);
                        MessageBox.Show("informations enregistrées.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void aj_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Nom_p.Text == "" || Adresse_P.Text == "" || Reduction.Text == "")
            {
                MessageBox.Show("tout les champs ne sont pas saisis");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PartenariaDb values('" + Id.Text + "','" + Nom_p.Text + "','" + Adresse_P.Text + "','" + Reduction.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("informations ajouter avec succes ");
                    Con.Close();
                    pop();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Nom_p.Text == "" || Reduction.Text == "" || Adresse_P.Text == "")
            {
                MessageBox.Show("tout les champs ne sont pas saisis");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PartenariadB set Nom_p='" + Nom_p.Text + "',Adresse_P='" + Adresse_P.Text + "',Reduction='" + Reduction.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("données modifiées ");
                    Con.Close();
                    pop();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (Id.Text == "")
            {
                MessageBox.Show("ajouter le di du membre");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PartenariaDb where Id='" + Id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussi");
                    Con.Close();
                    pop();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void pop()
        {
            Con.Open();
            string query = "select * from MembreDb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            tv.DataSource = dt.Tables[0];
            Con.Close();
        }

        private void pop2()
        {
            Con.Open();
            string query = "select * from PartenariaDb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            tv2.DataSource = dt.Tables[0];
            Con.Close();
        }

        private void Partenaria_Load(object sender, EventArgs e)
        {
            pop();
            pop2();
        }

        private void tv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = tv2.SelectedRows[0].Cells[0].Value.ToString();
            Nom_p.Text = tv2.SelectedRows[0].Cells[1].Value.ToString();
            Adresse_P.Text = tv2.SelectedRows[0].Cells[2].Value.ToString();
            Reduction.Text = tv2.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
