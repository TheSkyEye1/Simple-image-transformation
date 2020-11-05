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
using Emgu.CV.Util;
using Emgu.CV.Structure;

namespace lab3
{
    public partial class Form1 : Form
    {
        Filter_c fil = new Filter_c();
        private Image<Bgr, byte> sourceImage;
        PointF[] pts = new PointF[4];
        int pcounter = 0;
        Point rotatep;
        int[] values = new int[6] { 180, 90, 60, 45, 36, 30 };
        int k1 = 1;
        int k2 = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            sourceImage = fil.loadfunction(sourceImage);
            if (sourceImage != null)
            {
                IMG1.Image = sourceImage;
                IMG2.Image = sourceImage;
            }
        }

        private void resizeb_Click(object sender, EventArgs e)
        {
            double k1 = Convert.ToDouble(tracki.Value) / 10;
            double k2 = Convert.ToDouble(trackj.Value) / 10;
            IMG2.Image = fil.resizeimage(sourceImage, k1, k2);
        }

        private void rtb_ValueChanged(object sender, EventArgs e)
        {
            lb1.Text = Convert.ToString(Convert.ToDouble(tracki.Value) / 10);
        }

        private void IMG1_MouseClick(object sender, MouseEventArgs e)
        {
            var sourcecopy = sourceImage.Copy();

            int x = (int)(e.Location.X / IMG1.ZoomScale);
            int y = (int)(e.Location.Y / IMG1.ZoomScale);

            rotatep = new Point(x, y);
            pts[pcounter] = new PointF(x,y);
            pcounter++;
            if(pcounter >= 4)
            {
                pcounter = 0;
            }

            Point center = new Point(x, y);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Blue).MCvScalar;

            for (int i = 0; i < 4; i++)
            {
                CvInvoke.Circle(sourcecopy, new Point((int)(pts[i].X), (int)(pts[i].Y)), radius, color, thickness);
            }

            IMG1.Image = sourcecopy;
        }

        private void homobut_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.homograph(sourceImage, pts);
        }

        private void rotbut_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.rotate(sourceImage, rotatep, Math.PI/rotbar.Value);
        }

        private void rotbar_ValueChanged(object sender, EventArgs e)
        {
            lb2.Text = Convert.ToString(values[rotbar.Value-1]);
        }

        private void but1_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.flip(sourceImage, k1, k2);
        }

        private void b1_CheckedChanged(object sender, EventArgs e)
        {
            k1 = 1;
            k2 = 1;
        }

        private void b2_CheckedChanged(object sender, EventArgs e)
        {
            k1 = -1;
            k2 = 1;
        }

        private void b3_CheckedChanged(object sender, EventArgs e)
        {
            k1 = 1;
            k2 = -1;
        }

        private void b4_CheckedChanged(object sender, EventArgs e)
        {
            k1 = -1;
            k2 = -1;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lb3.Text = Convert.ToString(Convert.ToDouble(trackj.Value) / 10);
        }
    }
}
