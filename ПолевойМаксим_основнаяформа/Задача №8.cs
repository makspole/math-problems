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
    public partial class Задача__8 : Form
    {
        public Задача__8()
        {
            InitializeComponent();
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            try
            {
                if((textBox1.Text.Trim() == "")||(textBox2.Text.Trim() == ""))
                {
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Class1 MClass;
                    MClass = new Class1();
                    MClass.A = Convert.ToDouble(textBox1.Text);
                    MClass.B = Convert.ToDouble(textBox2.Text);
                    textBox4.Text += "Решение: " + MClass.Calc();
                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
            }
        }    
        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            try
            {
                if ((textBox1.Text.Trim() == "") || (textBox2.Text.Trim() == "")|| (textBox3.Text.Trim() == ""))
                {
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Classd Class;
                    Class = new Classd();
                    Class.A = Convert.ToDouble(textBox1.Text);
                    Class.B = Convert.ToDouble(textBox2.Text);
                    Class.C = Convert.ToDouble(textBox3.Text);
                    textBox5.Text += "Решение: " + Class.Calc2();
                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
