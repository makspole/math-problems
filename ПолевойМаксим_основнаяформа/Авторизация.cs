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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if ((textBox1.Text.Trim() == "") || (textBox2.Text.Trim() == ""))
                    MessageBox.Show("Все поля обязательны для заполнения!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if ((textBox1.Text.Trim() != "user")||(textBox2.Text.Trim() != "12345"))
                    MessageBox.Show("Неправильный логин или пароль!", "ОШИБКА ВВОДА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Авторизация прошла успешно", "АВТОРИЗАЦИЯ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Попробуйте ещё раз.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
            }
        }

    }
}
