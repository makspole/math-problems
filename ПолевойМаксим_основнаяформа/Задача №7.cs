using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПолевойМаксим_основнаяформа
{
    public partial class Задача__7 : Form
    {
        public Задача__7()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button2.Visible = true;
            try
            {
                double a = -10;
                double b = 10;
                double Eps = 0.001;
                double f1=0, f2=0, E = 0;
                double c = (a + b) / 2;
                di(Eps, a, b, c, ref f1, ref f2, ref E, textBox1);
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        static double func(double p)
        {
            double f = 6.24 * Math.Pow(p, 3)+10.4*Math.Pow(p,2)+0.9*p+1.5;
            return (f);
        }
        static void di(double Eps, double a, double b, double c, ref double f1, ref double f2, ref double E, TextBox text)
        {
            while (true)
            {
                f1 = func(a);
                c = (a + b) / 2;
                if ((b - a) < 2 * Eps)
                {
                    E = c;
                    text.Text = E.ToString();
                    break;
                }
                f2 = func(b);
                if (f2 == 0)
                {
                    E = c;
                    text.Text = E.ToString();
                    break;
                }
                if ((f1 * f2) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Задача__7_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button2.Visible = false;
        }
    }
}
