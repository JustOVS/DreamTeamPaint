using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DreamTeamPaint
{
    public static class Painter
    {
        public static Bitmap pointer;
        public static bool drawStartFinishFlag = false;

        public static int prevX;
        public static int prevY;



        public static void draw(MouseEventArgs e, PictureBox pictureBox)
        {
            
            if (drawStartFinishFlag == true && e.X < pictureBox.Width - 1 && e.Y < pictureBox.Height - 1 && e.X > 0 && e.Y > 0)
            {
                while ((prevX != e.X || prevY != e.Y) && drawStartFinishFlag == true && e.X < pictureBox.Width - 1 && e.Y < pictureBox.Height - 1 && e.X > 0 && e.Y > 0)
                {
                    
                    if (prevX < e.X && prevY > e.Y) //1   
                    {
                        pointer.SetPixel(prevX + 1, prevY - 1, Color.Red);
                        pictureBox.Image = pointer;
                        prevX++;
                        prevY--;
                    }

                    if (prevX > e.X && prevY < e.Y)//2
                    {
                        pointer.SetPixel(prevX - 1, prevY + 1, Color.Red);
                        pictureBox.Image = pointer;
                        prevX--;
                        prevY++;
                    }

                    if (prevX == e.X && prevY < e.Y) //3
                    {
                        pointer.SetPixel(prevX, prevY + 1, Color.Red);
                        pictureBox.Image = pointer;
                        prevY++;

                    }

                    if (prevX < e.X && prevY == e.Y) //4
                    {
                        pointer.SetPixel(prevX + 1, prevY, Color.Red);
                        pictureBox.Image = pointer;
                        prevX += 1;
                    }

                    if (prevX > e.X && prevY > e.Y) //5
                    {
                        pointer.SetPixel(prevX - 1, prevY - 1, Color.Red);
                        pictureBox.Image = pointer;
                        prevX -= 1;
                        prevY -= 1;
                    }

                    if (prevX < e.X && prevY < e.Y) //6
                    {
                        pointer.SetPixel(prevX + 1, prevY + 1, Color.Red);
                        pictureBox.Image = pointer;
                        prevX += 1;
                        prevY += 1;
                    }

                    if (prevX == e.X && prevY > e.Y) //7
                    {
                        pointer.SetPixel(prevX, prevY - 1, Color.Red);
                        pictureBox.Image = pointer;
                        prevY -= 1;
                    }

                    if (prevX > e.X && prevY == e.Y) //8
                    {
                        pointer.SetPixel(prevX - 1, prevY, Color.Red);
                        pictureBox.Image = pointer;
                        prevX -= 1;
                    }
                }
                prevX = e.X;
                prevY = e.Y;
            }
            else if (e.X == pictureBox.Width  || e.Y == pictureBox.Height || e.X == 0 || e.Y == 0)
            {
                prevX = e.X;
                prevY = e.Y;
            }
            else { }
        }
    }
}

