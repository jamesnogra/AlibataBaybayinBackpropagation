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

namespace AlibataBackPropagation
{
    public partial class Form1 : Form
    {
        Bitmap drawerBitmap;
        bool paintFlag = false;
        byte brushWidth = 20;

        public Form1()
        {
            InitializeComponent();
            drawerBitmap = new Bitmap(drawer.Width, drawer.Height);
            drawer.Image = drawerBitmap;
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
                Pen myPen = new Pen(Color.Black);
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                this.Cursor = new Cursor(Cursor.Current.Handle);
                g.FillEllipse(myBrush, e.X, e.Y, brushWidth, brushWidth);
                drawer.Image = drawerBitmap;
                g.Dispose();
            }
        }

        private void clearDrawing_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(drawerBitmap);
            Pen myPen = new Pen(Color.Black);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            this.Cursor = new Cursor(Cursor.Current.Handle);
            g.FillRectangle(myBrush, 0, 0, drawer.Width, drawer.Height);
            drawer.Image = drawerBitmap;
            g.Dispose();
        }
    }
}
