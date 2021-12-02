using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Week6
{
    public partial class EmguCV_Real_time : Form
    {
        VideoCapture capture;
        Mat frame;
        bool play;
        Image<Gray, byte> grayVDO, binaryVDO;

        public EmguCV_Real_time()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                btnPlay.Visible = true; btnPause.Visible = true;
                btnStop.Visible = true; btnGray.Visible = false;
                btnBinary.Visible = false; btnCapture.Visible = false;
                btnSave.Visible = false;

                Application.Idle -= ProcessFrame1;
                Application.Idle -= ProcessFrame2;
                Application.Idle -= ProcessFram3;
                imgBoxVDO.Image = null;

                OpenFileDialog opf = new OpenFileDialog();
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    capture = new VideoCapture(opf.FileName);
                    Mat matrix = new Mat();
                    capture.Read(matrix);
                    imgBoxVDO.Image = matrix;
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                btnPlay.Visible = false; btnPause.Visible = false;
                btnStop.Visible = false; btnGray.Visible = true;
                btnBinary.Visible = true; btnCapture.Visible = true;
                btnSave.Visible = true;

                capture = new VideoCapture(0);
                frame = new Mat();

                Application.Idle += ProcessFrame1;
            }

        }

        private void ProcessFrame1(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Read(frame);
                imgBoxVDO.Image = frame.ToImage<Bgr, byte>();
            }
        }

        private void ProcessFrame2(object sender, EventArgs e)
        {
            frame = capture.QueryFrame();
            grayVDO = frame.ToImage<Gray, byte>();
            binaryVDO = grayVDO.ThresholdBinary(new Gray(150), new Gray(255));
            imgBoxVDO.Image = binaryVDO;
        }

        private void ProcessFram3(object sender, EventArgs e)
        {
            frame = capture.QueryFrame();
            grayVDO = frame.ToImage<Gray, byte>();
            imgBoxVDO.Image = grayVDO;
        }

        private void EmguCV_Real_time_Load(object sender, EventArgs e)
        {
            btnGray.Visible = false;
            btnBinary.Visible = false;
            btnPlay.Visible = false;
            btnPause.Visible = false;
            btnStop.Visible = false;
            btnCapture.Visible = false;
            btnSave.Visible = false;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            imageBox1.Image = imgBoxVDO.Image;
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (!frame.IsEmpty)
            {
                Application.Idle += ProcessFrame2;
            }
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            play = true;
            if (capture == null)
            {
                return;
            }
            else
            {
                while (play == true)
                {
                    Mat matrix = new Mat();
                    capture.Read(matrix);

                    if (!matrix.IsEmpty)
                    {
                        imgBoxVDO.Image = matrix.ToImage<Bgr, byte>();
                        double fps = capture.GetCaptureProperty(CapProp.Fps);
                        await Task.Delay(1000 / Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            play = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Gray Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|Bitmap files(*.bmp)|*.bmp|All files (*.*)|*.*";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                imageBox1.Image.Save(saveImage.FileName);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (!frame.IsEmpty)
            {
                Application.Idle += ProcessFram3;
            }
        }
    }
}
