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
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;

namespace WindowsFormsApp1.Week7
{
    public partial class EmguCV_detect_border : Form
    {
        int thr1, thr2, kSobel, kLapalcian;
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> imgCanny;
        Image<Gray, float> imgSobel;
        Image<Gray, float> imgLaplacian;
        public EmguCV_detect_border()
        {
            InitializeComponent();

        }

        private void EmguCV_detect_border_Load(object sender, EventArgs e)
        {
            thr1 = int.Parse(textBox1.Text);
            thr2 = int.Parse(textBox2.Text);
            kSobel = int.Parse(textBox3.Text);
            kLapalcian = int.Parse(textBox4.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = imgInput.ToBitmap();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Processed Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files (*.png)|*.png|BMP files (*.bmp)|*.bmp";

       if (saveImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveImage.FileName);
                MessageBox.Show("Saving Complete");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgCanny = imgInput.Canny(thr1, thr2);
            pictureBox2.Image = imgCanny.ToBitmap();
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

            imgSobel = imgGray.Sobel(1, 1, kSobel);
            pictureBox2.Image = imgSobel.ToBitmap();

        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            imgLaplacian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

            imgLaplacian = imgGray.Laplace(kLapalcian);
            pictureBox2.Image = imgLaplacian.ToBitmap();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Not null");
                return;
            }
            else
            {
                if (imgInput == null)
                {
                    return;
                }
                imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
                imgCanny = imgInput.Canny(int.Parse(textBox1.Text.ToString()), int.Parse(textBox2.Text.ToString()));
                pictureBox2.Image = imgCanny.ToBitmap();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Not null");
                return;
            }
            else
            {
                if (imgInput == null)
                {
                    return;
                }
                imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
                imgCanny = imgInput.Canny(int.Parse(textBox1.Text.ToString()), int.Parse(textBox2.Text.ToString()));
                pictureBox2.Image = imgCanny.ToBitmap();
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Not null");
                return;
            }
            else
            {
                if (imgInput == null)
                {
                    return;
                }
                Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

                imgSobel = imgGray.Sobel(1, 1, int.Parse(textBox3.Text.ToString()));
                pictureBox2.Image = imgSobel.ToBitmap();
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Not null");
                return;
            }
            else
            {
                if (imgInput == null)
                {
                    return;
                }
                Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                imgLaplacian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

                imgLaplacian = imgGray.Laplace(int.Parse(textBox4.Text.ToString()));
                pictureBox2.Image = imgLaplacian.ToBitmap();
            }
        }
    }
}

