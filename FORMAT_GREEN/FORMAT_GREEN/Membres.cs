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
    public partial class Membres : Form
    {
        public Membres()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\warel\Documents\Format_grenn.mdf;Integrated Security=True;Connect Timeout=30");

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void aj_Click(object sender, EventArgs e)
        {
            if(Id.Text == "" || Nom.Text == "" || Numero.Text == "" || Adresse.Text == "")
            {
                MessageBox.Show("tout les champs ne sont pas saisis");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MembreDb values('"+Id.Text+"','"+Nom.Text+"','"+Adresse.Text+"','"+Statut.SelectedItem.ToString()+"','"+Date_inscription.Value.Date+"','"+Numero.Text+"','"+Validité.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("informations ajouter avec succes ");
                    Con.Close();
                    pop();

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Membres_Load(object sender, EventArgs e)
        {
            pop();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(Id.Text == "")
            {
                MessageBox.Show("ajouter le di du membre");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MembreDb where Id='" + Id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussi");
                    Con.Close();
                    pop();
                }catch(Exception Ex)
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
            Statut.Text = tv.SelectedRows[0].Cells[3].Value.ToString();
            Date_inscription.Text = tv.SelectedRows[0].Cells[4].Value.ToString();
            Numero.Text = tv.SelectedRows[0].Cells[5].Value.ToString();
            Validité.Text = tv.SelectedRows[0].Cells[6].Value.ToString();



        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Nom.Text == "" || Numero.Text == "" || Adresse.Text == "")
            {
                MessageBox.Show("tout les champs ne sont pas saisis");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MembredB set Nom='" + Nom.Text + "',Adresse='" + Adresse.Text + "',Statut='" + Statut.SelectedItem.ToString() + "',Date_inscription='" + Date_inscription.Value.Date + "',Numero='" + Numero.Text + "',Validité='" + Validité.Text + "' where Id='"+Id.Text+"';";
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void BASE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
