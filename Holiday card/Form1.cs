using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen bluePen = new Pen(Color.Blue, 10);
            Pen whitePen = new Pen(Color.White, 132);
            Pen darkGreenPen = new Pen(Color.DarkGreen, 100);
            SolidBrush darkGreenBrush = new SolidBrush(Color.DarkGreen);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            g.Clear(Color.White);
            g.FillRectangle(darkGreenBrush, 60, 80, 250, 350);
            g.DrawLine(whitePen, 150, 0, 0, 550);
            g.DrawLine(whitePen, 220, 0, 400, 550);
            g.FillEllipse(redBrush, 180, 180, 10, 10);
            g.FillEllipse(yellowBrush, 195, 200, 10, 10);
            g.FillEllipse(redBrush, 175, 220, 10, 10);
            g.FillEllipse(redBrush, 210, 240, 10, 10);
            g.FillEllipse(yellowBrush, 170, 260, 10, 10);
            g.FillEllipse(yellowBrush, 205, 280, 10, 10);
            g.FillEllipse(redBrush, 165, 300, 10, 10);
            g.FillEllipse(yellowBrush, 230, 320, 10, 10);
            g.FillEllipse(redBrush, 170, 340, 10, 10);
            g.FillEllipse(yellowBrush, 210, 360, 10, 10);
            g.FillEllipse(redBrush, 250, 380, 10, 10);
            g.FillEllipse(yellowBrush, 190, 400, 10, 10);
            g.FillEllipse(redBrush, 255, 415, 10, 10);
            g.FillEllipse(yellowBrush, 155, 410, 10, 10);
            g.FillRectangle(darkGreenBrush, 185, 425, 25, 50);
            g.DrawString("Merry Christmas", drawFont, redBrush, 100, 75);
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen bluePen = new Pen(Color.Blue, 10);
            Pen lightBluePen = new Pen(Color.LightBlue, 5);
            Pen whitePen = new Pen(Color.White, 132);
            Pen darkGreenPen = new Pen(Color.DarkGreen, 100);
            SolidBrush darkGreenBrush = new SolidBrush(Color.DarkGreen);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            g.Clear(Color.White);
            g.DrawString("Have A Happy Holidays!", drawFont, redBrush, 75, 90);

            int i = 1;

            while (1 <= 1)
            {
                i++;


                g.Clear(Color.White);

                g.DrawString("Have A Happy Holidays!", drawFont, redBrush, 75, 90);

                g.DrawLine(lightBluePen, 40, 10 + 1 * i, 40, 70 + 1 * i);
                g.DrawLine(lightBluePen, 10, 40 + 1 * i, 70, 40 + 1 * i);
                g.DrawLine(lightBluePen, 20, 20 + 1 * i, 60, 60 + 1 * i);
                g.DrawLine(lightBluePen, 60, 20 + 1 * i, 20, 60 + 1 * i);

                g.DrawLine(lightBluePen, 120, 30 + 1 * i, 120, 90 + 1 * i);
                g.DrawLine(lightBluePen, 90, 60 + 1 * i, 150, 60 + 1 * i);
                g.DrawLine(lightBluePen, 100, 40 + 1 * i, 140, 80 + 1 * i);
                g.DrawLine(lightBluePen, 140, 40 + 1 * i, 100, 80 + 1 * i);

                g.DrawLine(lightBluePen, 200, 10 + 1 * i, 200, 70 + 1 * i);
                g.DrawLine(lightBluePen, 170, 40 + 1 * i, 230, 40 + 1 * i);
                g.DrawLine(lightBluePen, 180, 20 + 1 * i, 220, 60 + 1 * i);
                g.DrawLine(lightBluePen, 220, 20 + 1 * i, 180, 60 + 1 * i);

                g.DrawLine(lightBluePen, 280, 30 + 1 * i, 280, 90 + 1 * i);
                g.DrawLine(lightBluePen, 250, 60 + 1 * i, 310, 60 + 1 * i);
                g.DrawLine(lightBluePen, 260, 40 + 1 * i, 300, 80 + 1 * i);
                g.DrawLine(lightBluePen, 300, 40 + 1 * i, 260, 80 + 1 * i);

                g.DrawLine(lightBluePen, 360, 10 + 1 * i, 360, 70 + 1 * i);
                g.DrawLine(lightBluePen, 330, 40 + 1 * i, 390, 40 + 1 * i);
                g.DrawLine(lightBluePen, 340, 20 + 1 * i, 380, 60 + 1 * i);
                g.DrawLine(lightBluePen, 380, 20 + 1 * i, 340, 60 + 1 * i);


                g.FillEllipse(darkGreenBrush, 147, 213, 124, 124);
                g.FillEllipse(whiteBrush, 185, 250, 50, 50);
           


            }

        

            g.FillEllipse(darkGreenBrush, 147, 213, 124, 124);
            g.FillEllipse(whiteBrush, 185, 250, 50, 50);



        }
    }
}
