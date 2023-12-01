using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int h, m, s; //часы, минуты, секунды

        private void button1_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(textBox1.Text); //заносим написанные пользователем числа в переменные
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            timer1.Start(); // запускаем таймер
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1; //каждую секунду счетчик таймера секунд уменьшается на 1
            if (s == -1) //если кончается минута, а секундная переменная становится меньше единицы, значит минута уменьшается на единицу, а секундный счетчик начинает с 59
            {
                m = m - 1;
                s = 59;
            }
            if (m==-1) //то же самое для часов
            {
                h = h - 1;
                m = 59;
            }

            if (h==0 && m==0 && s==0) // если часы, минуты и секунды в таймере будут равны нулю, значит время, указанное пользователе вышло
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
            }

            label1.Text = Convert.ToString(h); //выводим таймер на экран, чтобы пользователь наглядно видел, сколько время осталось.
            label3.Text = Convert.ToString(m);
            label5.Text = Convert.ToString(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // при нажатии пользователем на кнопку "Стоп" таймер останавливается
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // при нажатии пользователем на кнопку "Сброс" таймер останавливается, а текст в label'ах "сбрасывается" до нуля.
            label1.Text = "0";
            label3.Text = "0";
            label5.Text = "0";
        }
    }
}
