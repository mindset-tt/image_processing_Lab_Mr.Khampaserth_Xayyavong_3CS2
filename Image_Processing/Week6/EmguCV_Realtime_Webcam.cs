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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace WindowsFormsApp1.Week6
{
    public partial class EmguCV_Realtime_Webcam : Form
    {
        public EmguCV_Realtime_Webcam()
        {
            InitializeComponent();
        }
        VideoCapture capture;
        Mat frame;
        bool play;
        Image<Gray, byte> grayVDO, binaryVDO;
        private void button1_Click(object sender, EventArgs e)
        {
            play = true;
            pictureBox1.Image = null;
            Application.Idle += ProcessFrame1;
        }

        private void EmguCV_Realtime_Webcam_Load(object sender, EventArgs e)
        {
            play = false;
            capture = new VideoCapture();
            frame = new Mat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!frame.IsEmpty)
            {
                Application.Idle += ProcessFrame3;
            }
        }

        private void ProcessFrame1(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Read(frame);
                pictureBox1.Image = frame.ToImage<Bgr, byte>().ToBitmap();
            }
        }

        private void ProcessFrame2(object sender, EventArgs e)
        {
            frame = capture.QueryFrame();
            grayVDO = frame.ToImage<Gray, byte>();
            binaryVDO = grayVDO.ThresholdBinary(new Gray(150), new Gray(255));
            pictureBox1.Image = binaryVDO.ToBitmap();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!frame.IsEmpty)
            {
                Application.Idle += ProcessFrame2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Gray Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|Bitmap files(*.bmp)|*.bmp|All files (*.*)|*.*";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveImage.FileName);
            }
        }


        private void ProcessFrame3(object sender, EventArgs e)
        {
            frame = capture.QueryFrame();
            grayVDO = frame.ToImage<Gray, byte>();
           pictureBox1.Image = grayVDO.ToBitmap();
        }
    }
}
