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
    public partial class localisation : Form
    {
        public localisation()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\warel\Documents\Format_grenn.mdf;Integrated Security=True;Connect Timeout=30");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cherche_Click(object sender, EventArgs e)
        {
            string rue = Rue.Text;
            string ville = Ville.Text;
            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("http://google.com/maps?q="); 

                if (rue != string.Empty)
                {
                    queryadress.Append(rue + "," + "+");
                }
                if (ville != string.Empty)
                {
                    queryadress.Append(ville + "," + "+");
                }

                Map.Navigate(queryadress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erreur");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pop()
        {
            Con.Open();
            string query = "select * from EspaceDb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            tv.DataSource = dt.Tables[0];
            Con.Close();
        }

        private void aj_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Nom.Text == "" ||  Adresse.Text == "")
            {
                MessageBox.Show("tout les champs ne sont pas saisis");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EspaceDb values ('" + Id.Text + "','" + Nom.Text + "','" + Adresse.Text + "')";
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
                MessageBox.Show("ajouter le id de l'endroit");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EspaceDb where Id='" + Id.Text + "';";
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

       
        private void tv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = tv.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = tv.SelectedRows[0].Cells[1].Value.ToString();
            Adresse.Text = tv.SelectedRows[0].Cells[2].Value.ToString();
         
        }

        private void Map_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void localisation_Load_1(object sender, EventArgs e)
        {
            pop();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
