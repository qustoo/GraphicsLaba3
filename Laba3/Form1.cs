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
            //выключаем алгоритмы,чтобы пользователь сам выбрал
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            btm = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            pen = new Pen(color, thinkness);
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
                if(xStart < 1 && yStart < 1)
                {
                    xStart = x0;
                    yStart = y0;
                }
                else
                {
                    xEnd = x0;
                    yEnd = y0;
                    BresenhamAlgorithm(xStart, yStart, xEnd, yEnd);
                }
                
            }
            if(this.flag_wu)
            {
                if (xStart < 1 && yStart < 1)
                {
                    xStart = x0;
                    yStart = y0;
                }
                else
                {
                    xEnd = x0;
                    yEnd = y0;
                    WuAlgorithm(xStart, yStart, xEnd, yEnd);
                }
            }
        }

        // choose current color
        private void ChoseColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog clrDiag = new ColorDialog();
            clrDiag.AllowFullOpen = false;
            clrDiag.ShowHelp = false;
            if(clrDiag.ShowDialog() == DialogResult.OK)
            {
                this.color = clrDiag.Color;
                
            }
        }

        // brezenhame
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.flag_brezenhame = true;
            this.flag_wu = false;
        }

        // wu
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.flag_wu = true;
            this.flag_brezenhame = false; 
        }

        // swap elems in algorithm
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

        // clear canvas
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(btm);
            g.Clear(this.pictureBox1.BackColor);
            this.pictureBox1.Image = btm;
            pictureBox1.Refresh();
            g.Dispose();
        }

        // border around picturebox
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {          
            ControlPaint.DrawBorder(e.Graphics, this.pictureBox1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void BresenhamAlgorithm(int x0,int y0,int x1,int y1)
        {
            Graphics g = Graphics.FromImage(btm);
            Brush brh = new SolidBrush(this.color);
            var dx = x1 - x0; // проекция на ось
            var dy = y1 - y0; // проекция на ось
            if((x0 > x1 && Math.Abs(dx) > Math.Abs(dy)) || (Math.Abs(dx) <= Math.Abs(dy) && y1 < y0))
            {
                // Если линия растёт не слева направо, а наоборт, то меняем начало и конец отрезка местами
                Swap(ref x0, ref x1); // передача по ссылке
                Swap(ref y0, ref y1);
            }
            dx = x1 - x0;
            dy = y1 - y0;
            int step = 1; // направление роста
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
                for(int xi = x0+1; xi<x1; xi++)
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
                var xi = x0;
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
        private void DrawPointWu(Brush brush, int x, int y, float c)
        {
            int alpha = (int)(c * 255);
            if (alpha > 255) alpha = 255;
            if (alpha < 0) alpha = 0;
            Color cl = Color.FromArgb(alpha, color);
            this.btm.SetPixel(x, y, cl);
        }

        private void WuAlgorithm(int x0,int y0,int x1,int y1)
        {
            Brush brush = new SolidBrush(color);

            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }

            DrawPointWu(brush, steep ? y0 : x0, steep ? x0 : y0, 1);
            DrawPointWu(brush, steep ? y1 : x1, steep ? x1 : y1, 1);
            float dx = x1 - x0;
            float dy = y1 - y0;
            float gradient = dy / dx;
            float y = y0 + gradient;
            for (var x = x0 + 1; x <= x1 - 1; x++)
            {
                DrawPointWu(brush, steep ? (int)y : x, steep ? x : (int)y, 1 - (y - (int)y));
                DrawPointWu(brush, steep ? (int)y + 1 : x, steep ? x : (int)y + 1, y - (int)y);
                y += gradient;
            }

            pen.Dispose();
            pictureBox1.Image = btm;
            pictureBox1.Invalidate();
            xStart = 0;
            yStart = 0;
        }
    }
}
