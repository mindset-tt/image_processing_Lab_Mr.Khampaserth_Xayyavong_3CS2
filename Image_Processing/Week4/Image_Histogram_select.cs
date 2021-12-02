using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace WindowsFormsApp1.Week4
{
    public partial class Image_Histogram_select : Form
    {
        public Image_Histogram_select()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> oriImage;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(OpenFile.FileName);
                imageBox1.Image = oriImage;
                G = oriImage[1];
                B = oriImage[0];
                R = oriImage[2];
                imageBox1.Image = oriImage;
                if (radioButton1.Checked)
                {
                    imageBox2.Image = B;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(B, 256);
                    histogramBox1.Refresh();

                }
                else if (radioButton2.Checked)
                {
                    imageBox2.Image = G;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(G, 256);
                    histogramBox1.Refresh();

                }
                else if (radioButton3.Checked)
                {
                    imageBox2.Image = R;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(R, 256);
                    histogramBox1.Refresh();

                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            B = oriImage[0];
            imageBox2.Image = B;
            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(B, 256);
            histogramBox1.Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            G = oriImage[1];
            imageBox2.Image = G;
            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(G, 256);
            histogramBox1.Refresh();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            R = oriImage[2];
            imageBox2.Image = R;
            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(R, 256);
            histogramBox1.Refresh();

        }
    }
}
