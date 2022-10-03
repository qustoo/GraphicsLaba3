using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab_3
{

    public partial class Form1 : Form
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private SolidBrush Sb_op(SolidBrush sb1, SolidBrush sb2, string operation)
        {
            SolidBrush sb_new = new SolidBrush(Color.Black);
            switch (operation)
            {
                case "-":
                    sb_new = new SolidBrush(Color.FromArgb(Math.Max(sb1.Color.R - sb2.Color.R, 0),
                        Math.Max(sb1.Color.G - sb2.Color.G, 0), Math.Max(sb1.Color.B - sb2.Color.B, 0)));
                    break;
                case "+":
                    sb_new = new SolidBrush(Color.FromArgb(Math.Min(sb1.Color.R + sb2.Color.R, 255),
                        Math.Min(sb1.Color.G + sb2.Color.G, 255), Math.Min(sb1.Color.B + sb2.Color.B, 255)));
                    break;
            }
            
            return sb_new;
        }

        private SolidBrush Sb_op_mult(SolidBrush sb1, float w)
        {
            return new SolidBrush(Color.FromArgb((int)(sb1.Color.R * w), (int)(sb1.Color.G * w), (int)(sb1.Color.B * w)));
        }

        private Rectangle TriangleBoundingBox(Point a, Point b, Point c)
        {
            Point top_left = new Point(Math.Min(Math.Min(a.X, b.X), c.X), Math.Min(Math.Min(a.Y, b.Y), c.Y));
            Point bottom_right = new Point(Math.Max(Math.Max(a.X, b.X), c.X), Math.Max(Math.Max(a.Y, b.Y), c.Y));
            Rectangle r = new Rectangle();
            r.X = top_left.X;
            r.Y = top_left.Y;
            r.Width = bottom_right.X - top_left.X;
            r.Height = bottom_right.Y - top_left.Y;

            return r;
        }
        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();
            rgb1.Text = "R: " + col1.Color.R + " G: " + col1.Color.G + " B: " + col1.Color.B;
            rgb2.Text = "R: " + col2.Color.R + " G: " + col2.Color.G + " B: " + col2.Color.B;
            rgb3.Text = "R: " + col3.Color.R + " G: " + col3.Color.G + " B: " + col3.Color.B;
        }

        Point p1;
        Point p2;
        Point p3;

        bool getv1 = false;
        bool getv2 = false;
        bool getv3 = false;

        Graphics gp;
        Pen pen = new Pen(Brushes.Black, 1);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (getv1)
            {
                p1 = new Point(e.X, e.Y);
                coord1.Text = "X: " + p1.X + ", Y:" + p1.Y;
            }

            if (getv2)
            {
                p2 = new Point(e.X, e.Y);
                coord2.Text = "X: " + p2.X + ", Y:" + p2.Y;
                gp.DrawLine(pen, p1, p2);
            }

            if (getv3)
            {
                p3 = new Point(e.X, e.Y);
                coord3.Text = "X: " + p3.X + ", Y:" + p3.Y;
                gp.DrawLine(pen, p2, p3);
                gp.DrawLine(pen, p3, p1);
            }

            panel1.Cursor = Cursors.Default;
            getv1 = false;
            getv2 = false;
            getv3 = false;
        }

        private void select_1_Click(object sender, EventArgs e)
        {
            getv1 = true;
            panel1.Cursor = Cursors.Cross;
        }

        private void select_2_Click(object sender, EventArgs e)
        {
            getv2 = true;
            panel1.Cursor = Cursors.Cross;
        }

        private void select_3_Click(object sender, EventArgs e)
        {
            getv3 = true;
            panel1.Cursor = Cursors.Cross;
        }

        SolidBrush col1 = new SolidBrush(Color.Green);
        SolidBrush col2 = new SolidBrush(Color.Red);
        SolidBrush col3 = new SolidBrush(Color.Blue);

        private void button1_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                col1 = new SolidBrush(MyDialog.Color);
                rgb1.Text = "R: " + MyDialog.Color.R + " G: " + MyDialog.Color.G + " B: " + MyDialog.Color.B;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                col2 = new SolidBrush(MyDialog.Color);
                rgb2.Text = "R: " + MyDialog.Color.R + " G: " + MyDialog.Color.G + " B: " + MyDialog.Color.B;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                col3 = new SolidBrush(MyDialog.Color);
                rgb3.Text = "R: " + MyDialog.Color.R + " G: " + MyDialog.Color.G + " B: " + MyDialog.Color.B;
            }
        }

        
        private void FillGradient_Click(object sender, EventArgs e)
        {
            if (p1.Y == p2.Y && p1.Y == p3.Y) return;

            //храним старое значение точки р1, на вектор которой сдвигаем треугольник
            Point old_p1 = new Point(p1.X, p1.Y);

            //сдвигаем треугольник в начало координат
            p2 = new Point(p2.X - p1.X, p2.Y - p1.Y);
            p3 = new Point(p3.X - p1.X, p3.Y - p1.Y);
            p1 = new Point(0, 0);

            if (p3.Y == 0)
            {
                Swap(ref p3, ref p2);
                Swap(ref col3, ref col2);
            }

            SolidBrush delta_col12 = Sb_op(col2, col1, "-");
            SolidBrush delta_col13 = Sb_op(col3, col1, "-");


            Rectangle rectangle = TriangleBoundingBox(p1, p2, p3);
            Bitmap image = new Bitmap(rectangle.Width, rectangle.Height);

            for (int y = rectangle.Top; y < rectangle.Bottom; y++)
            {
                for (int x = rectangle.Left; x < rectangle.Right; x++)
                {
                    //коэффициент-множитель для одной стороны треугольника
                    float w1 = (float)(y * p3.X - x * p3.Y) / (float)(p2.Y * p3.X - p2.X * p3.Y);

                    //если он в пределах единицы, точка может находиться  пределах треугольника
                    if (w1 >= 0 && w1 <= 1)
                    {
                        //коэффициент для второй стороны
                        float w2 = (float)(y - (w1 * p2.Y)) / (float)p3.Y;

                        //если сумма коэффициентов в пределах единицы - точка в треугольнике
                        if (w2 >= 0 && (w1 + w2) <= 1)
                        {
                            //вычислить цвет точки, сложив "цветовые вектора"
                            Color res_color = Sb_op(Sb_op(col1, Sb_op_mult(delta_col12, w1), "+"), Sb_op_mult(delta_col13, w2), "+").Color;

                            //установить точку
                            image.SetPixel(x, y, res_color);
                        }

                    }
                }
            }
            gp.Clear(panel1.BackColor);
            gp.DrawImage(image, old_p1);
        }
    }
}
