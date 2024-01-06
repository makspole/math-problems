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
    public partial class Задача__3 : Form
    {
        public Задача__3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n;           
            int kon = -1;
            int nach = -1;
            int s = 0;
            try
            {
                if (textBox2.Text.Trim() == "")
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(Convert.ToInt32(textBox2.Text.Trim()) == 0) MessageBox.Show("Количество строк должно быть больше 0!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        textBox1.Clear();
                        n = Convert.ToInt32(textBox2.Text.Trim());
                        int[] x = new int[n];
                        massiv(ref x, n, ref textBox1);
                        textBox1.Text += "\r\n";
                        proiz(ref x, n, ref textBox1);
                        textBox1.Text += "\r\n";
                        summa(x, ref kon, ref nach, ref s, n, ref textBox1);
                        textBox1.Text += "\r\n";
                        sort(ref x, n, ref textBox1);
                    }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Clear();
            }
        }
        static void summa(int[] x, ref int kon, ref int nach, ref int s, int n, ref TextBox textBox1)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                if (x[i] == 0)
                {
                    kon = i;
                    break;
                }
            }
            for (int i = 0; i < kon; i++)
            {
                if (x[i] == 0)
                {
                    nach = i;
                    break;
                }
            }
            if ((nach == -1) || (kon == -1))
                textBox1.Text += "\nВ массиве отсутствует минимальное количество нулевых элементов";
            else
            {
                for (int i = nach + 1; i < kon; i++)
                {
                    s += x[i];
                }
                textBox1.Text += "Сумма элементов между " + nach + " и " + kon + " элементами равна: " + s;
            }
        }
        static void massiv(ref int[] x, int n, ref TextBox textBox1)
        {
            textBox1.Text += "Исходный массив:"+"\r\n";
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(-2, 5);
                textBox1.Text += x[i] + " ";
            }
        }
        static void proiz(ref int[] x, int n, ref TextBox textBox1)
        {
            int p = 1;
            for (int i = 0; i < n; i++)
                if ((i % 2 == 0) & (x[i] != 0))
                    p *= x[i];
            textBox1.Text+= "\nПроизведение элементов массива с четными номерами равно: "+p;
        }
        static void sort(ref int[] x, int n, ref TextBox textBox1)
        {
            textBox1.Text += "Измененный массив:" + "\r\n";
            for (int i = 1; i < n; i++)
                for (int j = 0; j < n - 1; j++)
                    if (x[i] > x[j])
                    {
                        int t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
            for (int i = 0; i < n; i++)
            {
                textBox1.Text += x[i]+" ";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {           
            textBox2.Clear();
        }
    }
    
}
