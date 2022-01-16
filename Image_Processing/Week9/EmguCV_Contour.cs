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
using Emgu.CV.Util;
using Emgu.CV.CvEnum;


namespace WindowsFormsApp1.Week9
{
    public partial class EmguCV_Contour : Form
    {
        public EmguCV_Contour()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> inputImage;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = inputImage.ToBitmap();
            }

        }

        private void findContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> outputImage;
            outputImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(
new Gray(150), new Gray(255));
            VectorOfVectorOfPoint contour = new VectorOfVectorOfPoint();
            Mat heir = new Mat();

            CvInvoke.FindContours(outputImage, contour, heir, RetrType.External, ChainApproxMethod.ChainApproxSimple);
            Dictionary<int, double> dict = new Dictionary<int, double>();
            if (contour.Size > 0)
            {
                for (int i = 0; i < contour.Size; i++)
                {
                    double area = CvInvoke.ContourArea(contour[i]);
                    dict.Add(i, area);
                }
                //ກຳນົດຈຳນວນ contour ທີ່ຕ້ອງການແຕ້ມ
                var item = dict.OrderByDescending(v => v.Value).Take(3);
                foreach (var it in item)
                {
                    int key = int.Parse(it.Key.ToString());
                    //ໃຊ້ແຕ້ມຮູບສີ່ແຈສາກໃສ່ວັດຖຸທີ່ກວດພົບ
                    Rectangle rect = CvInvoke.BoundingRectangle(contour[key]);
                    CvInvoke.Rectangle(inputImage, rect, new MCvScalar(255, 0, 0), 3);
                    //ໃຊ້ແຕ່ໍ້ມ Contour ທົ່ວໄປ
                    //CvInvoke.DrawContours(inputImage, contour,key, 
                    //new MCvScalar(255, 0, 0), 2);
                }
                Find_Contour.Image = inputImage.ToBitmap();

            }
        }
            private void shapeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (inputImage == null)
            {
                return;
            }
            int countTriangle = 0;
            var temp = inputImage.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(200), new Gray(255));
            VectorOfVectorOfPoint contour = new VectorOfVectorOfPoint();
            Mat m = new Mat();
            CvInvoke.FindContours(temp, contour, m, RetrType.External, ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < contour.Size; i++)
            {
                double perimeter = CvInvoke.ArcLength(contour[i], true);
                VectorOfPoint approx = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(contour[i], approx, 0.04 * perimeter, true);
                CvInvoke.DrawContours(inputImage, contour, i, new MCvScalar(100, 255, 255), 2);
                Shape_Detection.Image = inputImage.ToBitmap();

                //Moments center of the shape
                var moments = CvInvoke.Moments(contour[i]);
                int x = (int)(moments.M10 / moments.M00);
                int y = (int)(moments.M01 / moments.M00);

                //ກວດຈຳນວນເມັດ
                if (approx.Size == 3)
                {
                    CvInvoke.PutText(inputImage, "Triangle", new Point(x, y),
                        FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                    countTriangle++;
                }
                if (approx.Size == 4)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contour[i]);
                    double ar = rect.Width / rect.Height;
                    if (ar == 1)
                    {
                        CvInvoke.PutText(inputImage, "Square", new Point(x, y),
                           FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                    }
                    else
                    {
                        CvInvoke.PutText(inputImage, "Rectangle", new Point(x, y),
                           FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                    }
                }
                if (approx.Size == 6)
                {
                    CvInvoke.PutText(inputImage, "Hexagon", new Point(x, y),
                       FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                }
            }
            MessageBox.Show("Number of triangle:" + countTriangle + "\nNumber of Objects:" + contour.Size);

        }

        private void sortingContourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> outputImage;
            outputImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
            VectorOfVectorOfPoint contour = new VectorOfVectorOfPoint();
            Mat heir = new Mat();

            CvInvoke.FindContours(outputImage, contour, heir, RetrType.External, ChainApproxMethod.ChainApproxSimple);
            Dictionary<int, double> dict = new Dictionary<int, double>();
            if (contour.Size > 0)
            {
                for (int i = 0; i < contour.Size; i++)
                {
                    double area = CvInvoke.ContourArea(contour[i]);
                    dict.Add(i, area);
                }
                //ກຳນົດຈຳນວນ contour ທີ່ຕ້ອງການແຕ້ມ
                var item = dict.OrderByDescending(v => v.Value).Take(3);
                foreach (var it in item)
                {
                    int key = int.Parse(it.Key.ToString());
                    //ໃຊ້ແຕ້ມຮູບສີ່ແຈສາກໃສ່ວັດຖຸທີ່ກວດພົບ
                    Rectangle rect = CvInvoke.BoundingRectangle(contour[key]);
                    CvInvoke.Rectangle(inputImage, rect, new MCvScalar(255, 0, 0), 3);
                    //ໃຊ້ແຕ່ໍ້ມ Contour ທົ່ວໄປ
                    //CvInvoke.DrawContours(inputImage, contour,key,new MCvScalar(255, 0, 0), 2);
                }
                Sorting_Contour.Image = inputImage.ToBitmap();
            }

        }
    }
}
