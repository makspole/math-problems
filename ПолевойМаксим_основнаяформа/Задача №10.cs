using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПолевойМаксим_основнаяформа
{
    public partial class Задача__10 : Form
    {
        public Задача__10()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics MGraphic;   
            Pen MPen;           
            int i, nW, nH;
            MGraphic = pictureBox1.CreateGraphics();
            nW = pictureBox1.Width;              
            nH = pictureBox1.Height;             
            MGraphic.Clear(Color.White);        
            MPen = new Pen(Color.Blue, 2);
            for (i = 0; i <= nH; i += 50)
            {
                MGraphic.DrawLine(MPen, 0, i, nW, i);
                Thread.Sleep(200);
            }
            for (i = 0; i <= nW; i += 50)
            {
                MGraphic.DrawLine(MPen, i, 0, i, nH);
                Thread.Sleep(200);
            }
            MPen = new Pen(Color.Red, 5);
            MGraphic.DrawLine(MPen, 0, 50, 100, 0);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 100, 0, 450, 0);
            Thread.Sleep(200);
            MGraphic.DrawArc(MPen, 350, 0, 200, 200, 0, -90);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 550, 100, 550, 250);
            Thread.Sleep(200);
            MGraphic.DrawArc(MPen, 450, 250, 200, 200, 180, 90);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 450, 350, 250, 350);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 250, 350, 250, 250);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 250, 250, 175, 250);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 175, 250, 175, 350);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 175, 350, 150, 350);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 150, 350, 150, 250);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 150, 250, 100, 250);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 100, 250, 100, 350);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 100, 350, 50, 350);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 50, 350, 50, 300);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 50, 300, 0, 300);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 0, 300, 0, 275);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 0, 275, 50, 275);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 50, 275, 50, 250);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 50, 250, 0, 250);
            Thread.Sleep(200);
            MGraphic.DrawLine(MPen, 0, 250, 0, 50);
            Thread.Sleep(200);
            MGraphic.DrawEllipse(MPen, 50, 75, 100, 100);
            Thread.Sleep(200);
            MGraphic.DrawEllipse(MPen, 375, 25, 100, 100);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
