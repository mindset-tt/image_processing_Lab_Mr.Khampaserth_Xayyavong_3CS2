using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Week4
{
    public partial class Image_HistogramBoxx : Form
    {
        public Image_HistogramBoxx()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> oriImage;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;

        private void Image_HistogramBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(OpenFile.FileName);
                R = oriImage[2];
                G = oriImage[1];
                B = oriImage[0];
                imageBox1.Image = R;
                imageBox2.Image = G;
                imageBox3.Image = B;
            }
            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();
            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oriImage == null)
            {
                MessageBox.Show("Please Select an Image to process");
                return;
            }
            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();
            histogramBox1.GenerateHistograms(R, 256);
            histogramBox2.GenerateHistograms(G, 256);
            histogramBox3.GenerateHistograms(B, 256);
            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();
        }
    }
}
