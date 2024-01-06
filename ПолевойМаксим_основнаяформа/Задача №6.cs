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
    public partial class Задача__6 : Form
    {
        public Задача__6()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if((textBox1.Text.Trim() == "") ||(textBox2.Text.Trim() == "") ||(textBox3.Text.Trim() == "") ||(textBox4.Text.Trim() == ""))
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToDouble(textBox4.Text.Trim()) <= 0) MessageBox.Show("Шаг не может быть отрицательным или равным 0!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        double x0 = Convert.ToDouble(textBox1.Text);
                        double xn = Convert.ToDouble(textBox2.Text);
                        double y0 = Convert.ToDouble(textBox3.Text);
                        double h = Convert.ToDouble(textBox4.Text);
                        double f=0;
                        double hf=0;
                        listView1.Items.Clear();
                        ListViewItem ListV = new ListViewItem(new string[] { x0.ToString(), y0.ToString(), f.ToString(), hf.ToString() });
                        eche(xn, x0, y0 , f, hf, h, ListV, listView1);
                    }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }    
        static void F(ref double f, double y0,double x0)
        {
            f = (Math.Pow(y0, 2) + 5 * x0) / (2 * x0 * y0);
        }
        static void eche(double xn, double x0, double y0, double f, double hf, double h, ListViewItem ListV, ListView ListView1)
        {
            do
            {
                F(ref f, y0, x0);
                hf = h * f;
                y0 = y0 + hf;
                ListV = new ListViewItem(new string[] { x0.ToString(), y0.ToString(), f.ToString(), hf.ToString() });
                ListView1.Items.Add(ListV);
                x0 += h;
            }
            while (x0 < xn+h);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            listView1.Items.Clear();

        }
    }
}
