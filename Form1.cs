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
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Painter.draw(e, pictureBox1);
            //Painter.x1 = e.X;
            //Painter.y1 = e.Y;


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Painter.drawStartFinishFlag = true;
            Painter.prevX = e.X;
            Painter.prevY = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Painter.pointer = new Bitmap(pictureBox1.Width, pictureBox1.Height);


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Painter.drawStartFinishFlag = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

            
        }
    }
}
