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
    public partial class Задача__4 : Form
    {
        public Задача__4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int m, n;
            try
            {
                if ((textBox2.Text.Trim()=="")||(textBox3.Text.Trim() == ""))
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if ((Convert.ToInt32(textBox2.Text.Trim()) == 0) || (Convert.ToInt32(textBox3.Text.Trim()) == 0)) MessageBox.Show("Количество строк и столбцов должно быть больше 0!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m = Convert.ToInt32(textBox2.Text.Trim());
                    n = Convert.ToInt32(textBox3.Text.Trim());
                    int[,] x = new int[m, n];
                    massiv(ref x, m, n, ref textBox1);
                    chet(ref x, m, n, ref textBox1);
                    textBox2.Clear();
                    textBox3.Clear();

                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();
            }
        }
        static void massiv(ref int[,] x, int m, int n, ref TextBox textBox1)
        {
            int a = -5;
            int b = 3;
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x[i, j] = rnd.Next(a, b + 1);
                    textBox1.Text += x[i, j] + "\t";
                }
                textBox1.Text += "\r\n";
            }
        }
        static void chet(ref int[,] x, int m, int n, ref TextBox textBox1)
        {
            int k = 0;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (x[i, j] == 0)
                    {
                        k++;
                        break;
                    }
                }
            }
            textBox1.Text+="\nКоличество столбцов с нулевым(-и) элементом(-ами): "+k;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
