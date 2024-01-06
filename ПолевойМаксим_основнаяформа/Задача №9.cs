using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ПолевойМаксим_основнаяформа
{
    public partial class Задача__9 : Form
    {
        public Задача__9()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Вы ничего не ввели", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else                   
                {
                    if (Regex.IsMatch(textBox1.Text.Trim(), "^[a-zA-Z0-9 ,.!?^;]*$"))
                    {
                        textBox2.Clear();
                        double proc = 0;
                        char[] em = new char[textBox1.Text.Trim().Length];
                        propis(ref em, ref textBox1, ref textBox2);
                        schet(ref proc, em, ref textBox1, ref textBox2);
                    }
                    else MessageBox.Show("Текст не на английском языке", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Clear();
            }
        }
        public void propis(ref char[] em, ref TextBox textBox1, ref TextBox textBox2)
        {
            int flag = 0;
            textBox2.Text += "Прописные буквы в тексте: ";
            em = new char[textBox1.Text.Trim().Length];
            if (textBox1.Text.Trim().Any(Char.IsUpper))
                flag = 1;
            if (flag == 0)
                textBox2.Text += "отсутсвуют";
            else
            {
                for (int i = 0; i < em.Length; i++)
                {
                    em[i] = textBox1.Text.Trim()[i];
                    if (Regex.IsMatch(Convert.ToString(em[i]), "^[A-Z]*$"))
                        textBox2.Text += em[i] + " ";
                }
            }
        }
        public void schet(ref double proc, char[] em, ref TextBox textBox1, ref TextBox textBox2)
        {

            int k = 0;
            int kem = 0;
            em = new char[textBox1.Text.Trim().Length];
            for (int i = 0; i < em.Length; i++)
            {
                em[i] = textBox1.Text.Trim()[i];
                if (Regex.IsMatch(Convert.ToString(em[i]), "^[a-zA-Z0-9]*$")) kem++;
                if (Regex.IsMatch(Convert.ToString(em[i]), "^[A-Z]*$")) k++;                    
            }
            proc = k * 100/kem;
            textBox2.Text +="\r\n"+"Процентное содержание прописных букв равно:"+proc+ "%" + "\r\n";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
                

        
    
