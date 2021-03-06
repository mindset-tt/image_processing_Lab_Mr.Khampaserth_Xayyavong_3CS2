using System;
using System.Windows.Forms;
using WindowsFormsApp1.Week3;
using WindowsFormsApp1.Week4;
using WindowsFormsApp1.Week5;
using WindowsFormsApp1.Week6;
using WindowsFormsApp1.Week7;
using WindowsFormsApp1.Week8;
using WindowsFormsApp1.Week9;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SetpixelForm());
            Application.Run(new GetPixel());
            Application.Run(new Get_Setpixel());
            Application.Run(new GrayCV());
            Application.Run(new GrayScale_Black_and_White_and_Invert());
            Application.Run(new Emgu_Begining());
            Application.Run(new Image_Histogram_select());
            Application.Run(new Image_HistogramBoxx());
            Application.Run(new Image_Processing_to_Black_and_White());
            Application.Run(new Image_Processing_to_Black_And_White_ComboBox());
            Application.Run(new EmguCV_Real_time());
            Application.Run(new EmguCV_detect_border());
            Application.Run(new EmguCV_Morphology());
            Application.Run(new EmguCV_Morphology_Value_set());
            Application.Run(new EmguCV_Morphology_Scroll_Bar());
            Application.Run(new EmguCV_Contour());
        }
    }
}
