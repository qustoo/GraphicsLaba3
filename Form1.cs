﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1_wf
{
    public partial class Form1 : Form
    {
        bool draw_mode = false;
        bool fill_mode = false;
        bool border_mode = false;
        Color borderColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            pictureBox.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (dlg.ShowDialog() == DialogResult.Cancel){
                return;
            }

            else{
                pictureBox.Image = new Bitmap(dlg.FileName);
            }
        }






        private void draw_button_Click(object sender, EventArgs e){
            draw_mode = !draw_mode;
            fill_mode = false;
            border_mode = false;
            fill_button.BackColor = SystemColors.Control;
            border_button.BackColor = SystemColors.Control;

            if (draw_mode){
                draw_button.BackColor = Color.DodgerBlue;
            }
            else{
                draw_button.BackColor = SystemColors.Control;
            }
        }


        private void fill_button_Click(object sender, EventArgs e){
            fill_mode = !fill_mode;
            draw_mode = false;
            border_mode = false;
            draw_button.BackColor = SystemColors.Control;
            border_button.BackColor = SystemColors.Control;

            if (fill_mode){
                fill_button.BackColor = Color.DodgerBlue;
            }
            else{
                fill_button.BackColor = SystemColors.Control;
            }
        }

        private void border_button_Click(object sender, EventArgs e){
            border_mode = !border_mode;
            draw_mode = false;
            fill_mode = false;
            draw_button.BackColor = SystemColors.Control;
            fill_button.BackColor = SystemColors.Control;

            if (border_mode){
                border_button.BackColor = Color.DodgerBlue;
            }
            else{
                border_button.BackColor = SystemColors.Control;
            }
        }









        Point draw_p;
        private void pictureBox_MouseDown(object sender, MouseEventArgs e){
            draw_p = e.Location;

            if (fill_mode){
                fill_algorithm(draw_p, Color.Red);
            }

            if (border_mode){
                border_algorithm(draw_p);
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e){
            if (draw_mode && e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox.Image);
                //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(new Pen(borderColor, 1), draw_p, e.Location);
                draw_p = e.Location;
                pictureBox.Invalidate();
            }
        }













        private void fill_algorithm(Point p, Color fill_color){
            Bitmap bitmap = (Bitmap)pictureBox.Image;
            Graphics g = Graphics.FromImage(bitmap);

            g.FillRectangle(new TextureBrush(bitmap), new Rectangle(5, 5, 5, 5));

            if (bitmap.GetPixel(p.X, p.Y).ToArgb() == borderColor.ToArgb() || bitmap.GetPixel(p.X, p.Y).ToArgb() == fill_color.ToArgb()){
                return;
            }

            while (bitmap.GetPixel(p.X - 1, p.Y).ToArgb() != borderColor.ToArgb()) {
                p.X -= 1;
            }
            Point start = p;


            while (bitmap.GetPixel(p.X + 1, p.Y).ToArgb() != borderColor.ToArgb()){
                p.X += 1;
            }
            Point end = p;

            g.DrawLine(new Pen(new SolidBrush(fill_color), 1), start, end);
            pictureBox.Invalidate();

            while (start.X != end.X){
                fill_algorithm(new Point(start.X, start.Y + 1), fill_color);
                fill_algorithm(new Point(start.X, start.Y - 1), fill_color);

                start.X += 1;
            }            
        }






        private void border_algorithm(Point p){
            Bitmap bitmap = (Bitmap)pictureBox.Image;
            Graphics g = Graphics.FromImage(bitmap);
            List<Point> points = new List<Point>();

            while (bitmap.GetPixel(p.X, p.Y).ToArgb() != borderColor.ToArgb()){
                p.X += 1;
            }

            border_algorithm_REC(p, bitmap, ref points);
            
            for(int i = 0; i < points.Count(); i++){
                g.DrawRectangle(new Pen(Brushes.Red, 1), new Rectangle(points[i], new Size(1, 1)));
            }
            pictureBox.Invalidate();
        }

        public void border_algorithm_REC(Point p, Bitmap bitmap, ref List<Point> points){
            if (!points.Contains(p)){
                points.Add(p);

                if (bitmap.GetPixel(p.X + 1, p.Y).ToArgb() == borderColor.ToArgb()){
                    border_algorithm_REC(new Point(p.X + 1, p.Y), bitmap, ref points);
                }
                if (bitmap.GetPixel(p.X + 1, p.Y - 1).ToArgb() == borderColor.ToArgb()){
                    border_algorithm_REC(new Point(p.X + 1, p.Y - 1), bitmap, ref points);
                }
                if (bitmap.GetPixel(p.X, p.Y - 1).ToArgb() == borderColor.ToArgb()){
                    border_algorithm_REC(new Point(p.X, p.Y - 1), bitmap, ref points);
                }
                if (bitmap.GetPixel(p.X - 1, p.Y - 1).ToArgb() == borderColor.ToArgb()){
                    border_algorithm_REC(new Point(p.X - 1, p.Y - 1), bitmap, ref points);
                }
                if (bitmap.GetPixel(p.X - 1, p.Y).ToArgb() == borderColor.ToArgb()){
                    border_algorithm_REC(new Point(p.X - 1, p.Y), bitmap, ref points);
                }
                if (bitmap.GetPixel(p.X - 1, p.Y + 1).ToArgb() == borderColor.ToArgb())
                {
                    border_algorithm_REC(new Point(p.X - 1, p.Y + 1), bitmap, ref points);
                }
                if (bitmap.GetPixel(p.X, p.Y + 1).ToArgb() == borderColor.ToArgb())
                {
                    border_algorithm_REC(new Point(p.X, p.Y + 1), bitmap, ref points);
                }
                if (bitmap.GetPixel(p.X + 1, p.Y + 1).ToArgb() == borderColor.ToArgb())
                {
                    border_algorithm_REC(new Point(p.X + 1, p.Y + 1), bitmap, ref points);
                }
            }
        }

        
    }

      
    }