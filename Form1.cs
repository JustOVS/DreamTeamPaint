using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamTeamPaint
{
    public partial class Form1 : Form
    {

        Color PixelColor;

        public Form1()
        {
            InitializeComponent();
        }


        Bitmap q;
        Bitmap q1;
        int X;
        int Y;

        private void Form1_Load_1(object sender, EventArgs e)
        {
           q = new Bitmap(pictureBox1.Width, pictureBox1.Height);
           q1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
           checkBox1.Checked = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)

        {
            int X1 = e.X;
            int Y1 = e.Y;

            //if ((e.X > pictureBox1.Width) || (e.Y > pictureBox1.Height) || (e.X < 0) || (e.Y < 0))
            //{
            //    radioButton1.Checked = true;
            //    X = e.X;
            //    Y = e.Y;
            //}
            //else
            //{
            //    radioButton1.Checked = false;
            //    
            //}

            if (checkBox1.Checked == true && e.X < pictureBox1.Width && e.Y < pictureBox1.Height && e.X > 0 && e.Y > 0/* && radioButton1.Checked == false*/)

            {
                q1.SetPixel(X1, Y1, Color.Red);
                pictureBox1.Image = q1;

                while ((X != X1 || Y != Y1) /*&& (radioButton1.Checked == false)*/)
                {
                    if (X < X1 && Y > Y1) //1   
                    {
                        q1.SetPixel(X + 1, Y - 1, Color.Red);
                        pictureBox1.Image = q1;
                        X = X + 1;
                        Y = Y - 1;
                    }

                    if (X > X1 && Y < Y1)//2
                    {
                        q1.SetPixel(X - 1, Y + 1, Color.Red);
                        pictureBox1.Image = q1;
                        X = X - 1;
                        Y = Y + 1;
                    }

                    if (X == X1 && Y <= Y1) //3
                    {
                        q1.SetPixel(X, Y + 1, Color.Red);
                        pictureBox1.Image = q1;
                        Y = Y + 1;

                    }

                    if (X < X1 && Y == Y1) //4
                    {
                        q1.SetPixel(X + 1, Y, Color.Red);
                        pictureBox1.Image = q1;
                        X = X + 1;
                    }

                    if (X > X1 && Y > Y1) //5
                    {
                        q1.SetPixel(X - 1, Y - 1, Color.Red);
                        pictureBox1.Image = q1;
                        X = X - 1;
                        Y = Y - 1;
                    }

                    if (X < X1 && Y < Y1) //6
                    {
                        q1.SetPixel(X + 1, Y + 1, Color.Red);
                        pictureBox1.Image = q1;
                        X = X + 1;
                        Y = Y + 1;
                    }

                    if (X == X1 && Y > Y1) //7
                    {
                        q1.SetPixel(X, Y - 1, Color.Red);
                        pictureBox1.Image = q1;
                        Y = Y - 1;
                    }

                    if (X > X1 && Y == Y1) //8
                    {
                        q1.SetPixel(X - 1, Y, Color.Red);
                        pictureBox1.Image = q1;
                        X = X - 1;
                    }
                }
                X = X1;
                Y = Y1;
            }
        }

       

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = true;
            radioButton1.Checked = false;
            X = e.X;
            Y = e.Y;
        }
    }   
}


