using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using System.Drawing.Imaging;
using System.Threading;

namespace AlibataBackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet bp;
        Bitmap drawerBitmap;
        int totalEpochs = 2000;
        char[] allCharaters = new char[3] { 'A', 'E', 'O' };
        byte[,,] allBinaryImages = new byte[3, 30, 256];
        byte[] inputImage = new byte[256];
        bool paintFlag = false;
        byte brushWidth = 25;

        public Form1()
        {
            InitializeComponent();
            drawerBitmap = new Bitmap(drawer.Width, drawer.Height);
            drawer.Image = drawerBitmap;
            legend.Image = (Bitmap)Image.FromFile(@"legend.jpg");
            bp = new NeuralNet(256, 4, 4);
        }

        private void train_Click(object sender, EventArgs e)
        {
            train.Visible = false;
            trainProgressBar.Value = 0;

            getImagesAndStoreBinaryData();
            beginTraining();

            MessageBox.Show("Finished training.");
            train.Visible = true;
        }

        private void beginTraining()
        {
            decimal totalPercent;
            for (int x=0; x<totalEpochs; x++)
            {
                for (int i=0; i<allBinaryImages.GetLength(0); i++)
                {
                    for (int j=0; j<allBinaryImages.GetLength(1); j++)
                    {
                        for (int k=0; k<allBinaryImages.GetLength(2); k++)
                        {
                            bp.setInputs(k, (double)allBinaryImages[i, j, k]);
                        }
                        if (i==0) //for A is 0000
                        {
                            bp.setDesiredOutput(0, (double)0);
                            bp.setDesiredOutput(1, (double)0);
                            bp.setDesiredOutput(2, (double)0);
                            bp.setDesiredOutput(3, (double)1);
                        }
                        else if (i == 1) //for E is 0001
                        {
                            bp.setDesiredOutput(0, (double)0);
                            bp.setDesiredOutput(1, (double)0);
                            bp.setDesiredOutput(2, (double)1);
                            bp.setDesiredOutput(3, (double)0);
                        }
                        else if (i == 2) //for O is 0010
                        {
                            bp.setDesiredOutput(0, (double)0);
                            bp.setDesiredOutput(1, (double)0);
                            bp.setDesiredOutput(2, (double)1);
                            bp.setDesiredOutput(3, (double)1);
                        }
                        bp.learn();
                    }
                }
                Application.DoEvents();
                totalPercent = (decimal)((decimal)(x+1) / (decimal)totalEpochs * (decimal)100);
                trainProgressBar.Value = (int)totalPercent;
                //MessageBox.Show("Val: " + x + " and " + totalEpochs + "\ndiv: "+ totalPercent);
            }
        }

        private void getImagesAndStoreBinaryData()
        {
            Bitmap tempImage;
            int tempImageCounter;
            string tempStr;

            for (int i=0; i<allCharaters.Length; i++)
            {
                for (int x=0; x<10; x++)
                {
                    //tempImage = (Bitmap)Image.FromFile(@"AlibataTrainingSet/" + allCharaters[i] + x + " (32x32) (8x8).jpg");
                    tempImage = (Bitmap)Image.FromFile(@"AlibataTrainingSetNew/" + allCharaters[i] + x + " (16x16).jpg");
                    tempImageCounter = 0;
                    tempStr = "";
                    for (int y = 0; y < tempImage.Width; y++)
                    {
                        for (int z = 0; z < tempImage.Height; z++)
                        {
                            allBinaryImages[i, x, tempImageCounter] = 0; //simulate black pixel
                            if (tempImage.GetPixel(y, z).R > 200 && tempImage.GetPixel(y, z).G > 200 && tempImage.GetPixel(y, z).B > 200)
                            {
                                allBinaryImages[i, x, tempImageCounter] = 1; //simulate white pixel
                            }
                            tempStr += allBinaryImages[i, x, tempImageCounter] + " ";
                            tempImageCounter++;
                        }
                        tempStr += "\n";
                    }
                    //MessageBox.Show(tempStr);
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            Bitmap tempImage = drawerBitmap;
            Bitmap resizedImage = resizeImage(ref tempImage, 16, 16);
            //resizedImage.Save("temp.bmp", ImageFormat.Bmp);
            //drawer.Image = resizedImage;
            int tempImageCounter = 0;
            string tempStr = "";
            Color tempColor;

            for (int x=0; x<resizedImage.Width; x++)
            {
                for (int y=0; y<resizedImage.Height; y++)
                {
                    tempColor = resizedImage.GetPixel(x, y);
                    //MessageBox.Show("At (" + x + "," + y + ")\nRGB (" + tempColor.R + "," + tempColor.G + "," + tempColor.B + ")");
                    inputImage[tempImageCounter] = 0;
                    if (tempColor.R > 200 && tempColor.G > 200 && tempColor.B > 200)
                    {
                        inputImage[tempImageCounter] = 1;
                    }
                    tempStr += inputImage[tempImageCounter] + " ";
                    tempImageCounter++;
                }
                tempStr += "\n";
            }
            //MessageBox.Show(tempStr);

            for (int x=0; x<inputImage.Length; x++)
            {
                bp.setInputs(x, inputImage[x]);
            }
            bp.run();
            resultLabel.Text = Math.Round(bp.getOuputData(0), 4) + " " + Math.Round(bp.getOuputData(1), 4) + " " + Math.Round(bp.getOuputData(2), 4) + " " + Math.Round(bp.getOuputData(3), 4);
            if ( Math.Round(bp.getOuputData(0)) == 0 && Math.Round(bp.getOuputData(1)) == 0 && Math.Round(bp.getOuputData(2)) == 0 && Math.Round(bp.getOuputData(3)) == 1)
            {
                resultPicBox.Image = (Bitmap)Image.FromFile(@"A.bmp");
            }
            else if (Math.Round(bp.getOuputData(0)) == 0 && Math.Round(bp.getOuputData(1)) == 0 && Math.Round(bp.getOuputData(2)) == 1 && Math.Round(bp.getOuputData(3)) == 0)
            {
                resultPicBox.Image = (Bitmap)Image.FromFile(@"E.bmp");
            }
            else if (Math.Round(bp.getOuputData(0)) == 0 && Math.Round(bp.getOuputData(1)) == 0 && Math.Round(bp.getOuputData(2)) == 1 && Math.Round(bp.getOuputData(3)) == 1)
            {
                resultPicBox.Image = (Bitmap)Image.FromFile(@"O.bmp");
            }
        }

        public Bitmap resizeImage(ref Bitmap source, int width, int height)
        {
            Bitmap result = new Bitmap(width, height); //initalize the image
            Color pixel;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    pixel = source.GetPixel(x * source.Width / width, y * source.Height / height);
                    result.SetPixel(x, y, pixel);
                }
            }
            return result;
        }

        private void drawer_MouseDown(object sender, MouseEventArgs e)
        {
            paintFlag = true;
        }

        private void drawer_MouseUp(object sender, MouseEventArgs e)
        {
            paintFlag = false;
        }

        private void drawer_MouseMove(object sender, MouseEventArgs e)
        {
            if (paintFlag)
            {
                Graphics g;
                g = Graphics.FromImage(drawerBitmap);
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                this.Cursor = new Cursor(Cursor.Current.Handle);
                using (Graphics gl = Graphics.FromImage(drawerBitmap))
                {
                    gl.FillEllipse(myBrush, e.X, e.Y, brushWidth, brushWidth);
                }
                drawer.Image = drawerBitmap;
                drawer.DrawToBitmap(drawerBitmap, new Rectangle(0, 0, drawer.Width, drawer.Height));
            }
        }

        private void clearDrawing_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(drawerBitmap);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            this.Cursor = new Cursor(Cursor.Current.Handle);
            g.FillRectangle(myBrush, 0, 0, drawer.Width, drawer.Height);
            drawer.Image = drawerBitmap;
            g.Dispose();
        }
    }
}
