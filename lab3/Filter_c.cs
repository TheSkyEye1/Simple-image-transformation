using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Microsoft.CSharp.RuntimeBinder;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Management.Instrumentation;

namespace lab3
{
    class Filter_c
    {
        public Image<Bgr, byte> loadfunction(Image<Bgr, byte> image)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;*.png";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                image = new Image<Bgr, byte>(fileName).Resize(640, 480, Inter.Linear);
            }
            return image;
        }

        public Image<Bgr, byte> resizeimage(Image<Bgr,byte> image, double k1, double k2)
        {
            Image<Bgr, byte> resizedimage = new Image<Bgr, byte>((int)(image.Width * k1), (int)(image.Height * k2));
            for(int i = 0; i<resizedimage.Width-1; i++)
            {
                for(int j=0; j<resizedimage.Height-1; j++)
                {
                    double I = (i / k1);
                    double J = (j / k2);

                    double baseI = Math.Floor(I);
                    double baseJ = Math.Floor(J);

                    if(baseI >= image.Width-1)
                    {
                        continue;
                    }
                    if(baseJ >= image.Height-1)
                    {
                        continue;
                    }

                    double rI = I - baseI;
                    double rJ = J - baseJ;

                    double irI = 1 - rI;
                    double irJ = 1 - rJ;

                    Bgr c1 = new Bgr();
                    c1.Blue = image.Data[(int)baseJ, (int)baseI, 0] * irI + image.Data[(int)baseJ, (int)(baseI + 1), 0] * rI;
                    c1.Green = image.Data[(int)baseJ, (int)baseI, 1] * irI + image.Data[(int)baseJ, (int)(baseI + 1), 1] * rI;
                    c1.Red = image.Data[(int)baseJ, (int)baseI, 2] * irI + image.Data[(int)baseJ, (int)(baseI + 1), 2] * rI;

                    Bgr c2 = new Bgr();
                    c2.Blue = image.Data[(int)(baseJ + 1), (int)baseI, 0] * irI + image.Data[(int)(baseJ + 1), (int)(baseI + 1), 0] * rI;
                    c2.Green = image.Data[(int)(baseJ + 1), (int)baseI, 1] * irI + image.Data[(int)(baseJ + 1), (int)(baseI + 1), 1] * rI;
                    c2.Red = image.Data[(int)(baseJ + 1), (int)baseI, 2] * irI + image.Data[(int)(baseJ + 1), (int)(baseI + 1), 2] * rI;

                    Bgr c = new Bgr();
                    c.Blue = c1.Blue * irJ + c2.Blue * rJ;
                    c.Green = c1.Green * irJ + c2.Green * rJ;
                    c.Red = c1.Red * irJ + c2.Red * rJ;

                    resizedimage[j, i] = c;
                }
            }
            return resizedimage;
        }

        public Image<Bgr, byte> homograph(Image<Bgr, byte> simage, PointF[] pts)
        {
            var srcPoints = pts;

            var destPoints = new PointF[]
            {
                new PointF(0, 0),
                new PointF(0, simage.Height - 1),
                new PointF(simage.Width - 1, simage.Height - 1),
                new PointF(simage.Width - 1, 0)
            };

            var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);
            var destImage = new Image<Bgr, byte>(simage.Size);
            CvInvoke.WarpPerspective(simage, destImage, homographyMatrix, destImage.Size);
            return destImage;
        }

        public Image<Bgr, byte> rotate(Image<Bgr, byte> image, Point p, double ang)
        {
            Image<Bgr, byte> rotateimage = image.CopyBlank();

            for(int i=0;i<rotateimage.Width-1; i++)
            {
                for(int j=0;j<rotateimage.Height-1;j++)
                {
                    int newI = Convert.ToInt32(Math.Cos(ang) * (j - p.X) - Math.Sin(ang) * (i - p.Y) + p.X);
                    int newJ = Convert.ToInt32(Math.Sin(ang) * (j - p.X) + (Math.Cos(ang)) * (i - p.Y) + p.Y);
                    if (newI <= (rotateimage.Width - 1) && newI >= 0 && newJ <= (rotateimage.Height - 1) && newJ >= 0)
                    {
                        //rotateimage[newJ, newI] = image[j, i];

                        double I = newI;
                        double J = newJ;

                        double baseI = Math.Floor(I);
                        double baseJ = Math.Floor(J);

                        if (baseI >= image.Width - 1)
                        {
                            continue;
                        }
                        if (baseJ >= image.Height - 1)
                        {
                            continue;
                        }

                        double rI = I - baseI;
                        double rJ = J - baseJ;

                        double irI = 1 - rI;
                        double irJ = 1 - rJ;

                        Bgr c1 = new Bgr();
                        c1.Blue = image.Data[(int)baseJ, (int)baseI, 0] * irI + image.Data[(int)baseJ, (int)(baseI + 1), 0] * rI;
                        c1.Green = image.Data[(int)baseJ, (int)baseI, 1] * irI + image.Data[(int)baseJ, (int)(baseI + 1), 1] * rI;
                        c1.Red = image.Data[(int)baseJ, (int)baseI, 2] * irI + image.Data[(int)baseJ, (int)(baseI + 1), 2] * rI;

                        Bgr c2 = new Bgr();
                        c2.Blue = image.Data[(int)(baseJ + 1), (int)baseI, 0] * irI + image.Data[(int)(baseJ + 1), (int)(baseI + 1), 0] * rI;
                        c2.Green = image.Data[(int)(baseJ + 1), (int)baseI, 1] * irI + image.Data[(int)(baseJ + 1), (int)(baseI + 1), 1] * rI;
                        c2.Red = image.Data[(int)(baseJ + 1), (int)baseI, 2] * irI + image.Data[(int)(baseJ + 1), (int)(baseI + 1), 2] * rI;

                        Bgr c = new Bgr();
                        c.Blue = c1.Blue * irJ + c2.Blue * rJ;
                        c.Green = c1.Green * irJ + c2.Green * rJ;
                        c.Red = c1.Red * irJ + c2.Red * rJ;

                        rotateimage[j, i] = c;
                    }
                }
            }
            return rotateimage;
        }

        public Image<Bgr, byte> flip(Image<Bgr,byte> image, int k1, int k2)
        {
            Image<Bgr, byte> flipedimage = image.Copy();
            for(int i=0; i<image.Width-1; i++)
            {
                for(int j=0; j<image.Height-1;j++)
                {
                    int newX = i;
                    int newY = j;
                    if (k1 == -1)
                    {
                        newX = i * k1 + image.Width - 1;
                    }
                    if (k2 == -1)
                    {
                        newY = j * k2 + image.Height - 1;
                    }

                    flipedimage[newY, newX] = image[j, i];
                }
            }
            return flipedimage;
        }
    }
}
