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
    public partial class Задача__1 : Form
    {
        public Задача__1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0; 
            double s = 0;
            textBox1.Clear();
            try 
            {
                if ((textBox2.Text.Trim()=="")||(textBox3.Text.Trim() == "") ||(textBox4.Text.Trim() == ""))
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    a = Convert.ToInt32(textBox2.Text.Trim());
                    b = Convert.ToInt32(textBox3.Text.Trim());
                    c = Convert.ToInt32(textBox4.Text.Trim());
                    if ((a<=0)||(b<=0)||(c<0)||(c>180))
                        MessageBox.Show("Невозможное значение переменной(-ых)", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        s = 0.5 * a * b * Math.Sin(c);
                        textBox1.Text += "S = 0.5 * "+a+" * "+b+" * sin("+c+")"+"\r\n";
                        textBox1.Text += "S = "+ Math.Round(s,3);
                    }
                }
            }
            catch(System.Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
