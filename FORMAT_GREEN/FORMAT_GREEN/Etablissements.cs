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
    public partial class Etablissements : Form
    {
        public Etablissements()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\warel\Documents\Format_grenn.mdf;Integrated Security=True;Connect Timeout=30");


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Etablissements_Load(object sender, EventArgs e)
        {
            pop();
        }

        private void pop()
        {
            Con.Open();
            string query = "select * from EtablissementDb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            tv.DataSource = dt.Tables[0];
            Con.Close();
        }

        private void aj_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Nom.Text == "" || Representé.Text == "" || Adresse.Text == "")
            {
                MessageBox.Show("tout les champs ne sont pas saisis");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EtablissementDb values('" + Id.Text + "','" + Nom.Text + "','" + Adresse.Text + "','" + Type.SelectedItem.ToString() + "','" + Representé.Text + "')";
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

        private void tv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = tv.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = tv.SelectedRows[0].Cells[1].Value.ToString();
            Adresse.Text = tv.SelectedRows[0].Cells[2].Value.ToString();
            Type.Text = tv.SelectedRows[0].Cells[3].Value.ToString();
            Representé.Text = tv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
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
                    string query = "delete from EtablissementDb where Id='" + Id.Text + "';";
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Nom.Text == "" || Representé.Text == "" || Adresse.Text == "")
            {
                MessageBox.Show("tout les champs ne sont pas saisis");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EtablissementDb set Nom='" + Nom.Text + "',Adresse='" + Adresse.Text + "',Type='" + Type.SelectedItem.ToString() + "',Representé='" + Representé.Text + "' where Id='" + Id.Text + "';";
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
