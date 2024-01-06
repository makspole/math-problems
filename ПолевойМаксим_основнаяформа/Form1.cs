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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void задача1ОсновныеОперацииЯзыкаПрограммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Задача__1 f = new Задача__1();
            f.Show();
        }

        private void задача2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Задача__2 f = new Задача__2();
            f.Show();
        }

        private void задача2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Задача__3 f = new Задача__3();
            f.Show();
        }

        private void задача2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Задача__4 f = new Задача__4();
            f.Show();
        }

        private void задача2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Задача__5 f = new Задача__5();
            f.Show();
        }

        private void задача2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Задача__6 f = new Задача__6();
            f.Show();
        }

        private void задача2ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Задача__7 f = new Задача__7();
            f.Show();
        }

        private void задача2ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Задача__8 f = new Задача__8();
            f.Show();
        }

        private void задача2ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Задача__9 f = new Задача__9();
            f.Show();
        }

        private void задача2ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Задача__10 f = new Задача__10();
            f.Show();
        }

        private void справкаОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.Show();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Авторизация f = new Авторизация();
            f.ShowDialog();
        }
    }
}
