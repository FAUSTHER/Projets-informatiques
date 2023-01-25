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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using BasselTech_CamCapture;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;


namespace FORMAT_GREEN
{
    public partial class Scan : Form
    {
        Camera cam;
        Timer T;
        BackgroundWorker Worker;
        Bitmap CapImage;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        public Scan()
        {
            InitializeComponent();

            T = new Timer();
           //cam = new Camera(pictureBox1);
            Worker = new BackgroundWorker();

            Worker.DoWork += Worker_DoWork;
            T.Tick += T_Tick;
            T.Interval = 1;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            CapImage = cam.GetBitmap();
            if (CapImage != null && !Worker.IsBusy)
                Worker.RunWorkerAsync();
        }


        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            QRCodeDecoder Decoder = new QRCodeDecoder();

            try
            {
                MessageBox.Show(Decoder.decode(new QRCodeBitmapImage(CapImage)));
            }
            catch (Exception)
            {

            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\warel\Documents\Format_grenn.mdf;Integrated Security=True;Connect Timeout=30");


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void Scan_Load(object sender, EventArgs e)
        {
            pop();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                Came.Items.Add(filterInfo.Name);
            Came.SelectedIndex = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                cam.Start();
                T.Start();
               // b2.Enabled = true;
              //  b1.Enabled = false;
            }
            catch (Exception ex)
            {
                cam.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            T.Stop();   
            cam.Stop();
           // b2.Enabled = false;
          //  b1.Enabled = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[Came.SelectedIndex].MonikerString);
            captureDevice.NewFrame += captureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }


        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Ecran.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Scan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ecran.Image != null)
            {
                BarcodeReader barcodReader = new BarcodeReader();
                Result result = barcodReader.Decode((Bitmap)Ecran.Image);
                if (result != null)
                {
                    QRcode.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void Came_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.text", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(QRcode.Text);
                        MessageBox.Show("informations enregistrées.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*,text", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        QRcode.Text = await sr.ReadToEndAsync();
                    }
                }
            }
        }

        private void BASE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            captureDevice.Stop();

        }

        private void Ecran_Click(object sender, EventArgs e)
        {

        }
    }
}
