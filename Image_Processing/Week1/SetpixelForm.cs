using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetpixelForm : Form
    {
        public SetpixelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap srcBitmap = new Bitmap(pictureBox1.Image);
            for (int x = 10; x < 430; x++)
            {
                srcBitmap.SetPixel(x, 30, Color.Red);
            }

            pictureBox1.Image = srcBitmap;
        }
    }
}
