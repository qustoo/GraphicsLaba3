using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        private Bitmap btm; // bitmap
        private bool flag_brezenhame = false; // Bresenham's algorithm
        private bool flag_wu = false; // Wu algorith
        private int oldColor; // old color to draw
        private int x0, y0; //started coordinats
        private int xStart, yStart, xEnd, yEnd;
        private bool mouseLeft = false; // clicked mouse left
        private Color color = Color.Black;
        private Pen pen;
        private int thinkness = 1;
        public Form1()
        {
            InitializeComponent();
            btm = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            pen = new Pen(color, thinkness);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseLeft = true;
            }
            x0 = Convert.ToInt32(e.X); // to int
            y0 = Convert.ToInt32(e.Y); // to int
            oldColor = this.btm.GetPixel(x0, y0).ToArgb();
            // MessageBox.Show($"x is {Convert.ToInt32(e.X)}, y is {Convert.ToInt32(e.Y)}");
            if(this.flag_brezenhame)
            {
                BresenhamAlgorithm(x0, y0, 150, 150);
            }
            if(this.flag_wu)
            {

            }
        }

        private void ChoseColorButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.flag_brezenhame = true;
            this.flag_wu = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.flag_brezenhame = false;
            this.flag_wu = true;
        }
        private void Swap<T>(ref T val1, ref T val2)
        {
            T val3 = val1;
            val1 = val2;
            val2 = val3;
        }
        private void DrawPoint(Brush brh, int x0, int y0, Graphics g)
        {
            g.FillRectangle(brh, x0, y0, 1, 1);
        }
        private void BresenhamAlgorithm(int x0,int y0,int x1,int y1)
        {
            Graphics g = Graphics.FromImage(btm);
            Brush brh = createBrush(this.color);
            var dx = x1 - x0;
            var dy = y1 - y0;
            if((x0 > x1 && Math.Abs(dx) > Math.Abs(dy)) || (Math.Abs(dx) <= Math.Abs(dy) && y1 < y0))
            {
                Swap(ref x0, ref x1); // передача по ссылке
                Swap(ref y0, ref y1);
            }
            dx = x1 - x0;
            dy = y1 - y0;
            int step = 1; // шаг
            DrawPoint(brh, x0, y0, g);
            if(Math.Abs(dx) > Math.Abs(dy))
            {
                if(dy < 0)
                {
                    step -= 1;
                    dy *= 1;
                }
                var di = 2 * dy - dx;
                var d1 = 2 * dy;
                var d2 = 2 * (dy - dx);
                var yi = y0;
                for(int xi = x1+1; xi<x1; xi++)
                {
                    if(di > 0)
                    {
                        yi += step;
                        di += d2;
                    }
                    else
                    {
                        di += d1;
                    }
                    DrawPoint(brh, xi, yi, g);
                }
            }
            else
            {
                if (dx < 0)
                {
                    step *= -1;
                    dx *= -1;
                }
                var di = 2 * dx - dy;
                var d1 = 2 * dx;
                var d2 = 2 * (dx - dy);
                var xi = x1;
                for (int yi = y0 + 1; yi < y1; yi++)
                {
                    if (di > 0)
                    {
                        xi += step;
                        di += d2;
                    }
                    else
                        di += d1;
                    DrawPoint(brh, xi, yi, g);
                }
            }
            pen.Dispose();
            g.Dispose();
            pictureBox1.Image = this.btm;
            pictureBox1.Invalidate();
            xStart = 0;
            yStart = 0;
            
        }

        private Brush createBrush(Color clr)
        {
            if(clr == Color.Red)
            {
                return Brushes.Red;
            }
            if(clr == Color.Blue)
            {
                return Brushes.Blue;
            }
            if(clr == Color.Gray)
            {
                return Brushes.Gray;
            }
            return Brushes.Black;
        }
    }
}
