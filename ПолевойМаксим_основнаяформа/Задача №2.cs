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
    public partial class Задача__2 : Form
    {
        public Задача__2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = 0, x2 = 0;
            string res="";
            try
            {
                if ((textBox1.Text.Trim() == "") || (textBox2.Text.Trim() == ""))
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {                   
                    x1 = Convert.ToInt32(textBox1.Text.Trim());
                    x2 = Convert.ToInt32(textBox2.Text.Trim());
                    srav(x1, x2, ref res);
                    textBox3.Text = res;
                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void srav (int x1, int x2, ref string res)
        {
            if (x1 > x2)
                res = ">";
            else if (x1 < x2)
                res = "<";
            else res = "=";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
