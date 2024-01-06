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
    public partial class Задача__5 : Form
    {
        public Задача__5()
        {
            InitializeComponent();
        }

        private void Задача__5_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                string MyFile1 = "a.txt";
                string MyFile2 = "b.txt";
                string[] B;
                var MyFileA = new System.IO.StreamReader(MyFile1);
                var MyFileB = new System.IO.StreamWriter(MyFile2, false);
                string stroka = Convert.ToString(MyFileA.ReadToEnd());
                textBox1.Text = stroka;
                B = stroka.Split(new char[] { ' ' });
                for (int i = 0; i < B.Length; i++)
                {
                    int[] A = new int[B.Length];
                    A[i] = Convert.ToInt32(B[i]);
                    if (A[i] % 2 == 0) B[i] = Convert.ToString(0);
                    else B[i] = Convert.ToString(-1);
                    MyFileB.Write(B[i] + " \t");
                }
                MyFileB.Close();
                var MyFileC = new System.IO.StreamReader(MyFile2);
                textBox2.Text = MyFileC.ReadToEnd();
                MyFileA.Close();
                MyFileC.Close();
                MessageBox.Show("Файл записан!", "Запись файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
