using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Var7
{
    public partial class Form1 : Form
    {
        int count;
        int[] rArr;

        /*
        
        Блуждающая сортировка/сортировка по частям
        Рекурсивный алгоритм сортировки.
        Алгоритм сортировки заключается в следующем:
        1) Если элемент в конце меньше, чем элемент в начале, то они меняются местами.
        2)Если есть 3 или более элементов, то: рекурсивно вызвается функция сортировки для первых 2/3 массива,        
        для последних 2/3 массива и снова для первых 2/3.
        3)Иначе return.

        */
        static void stoogesort(int[] a, int start, int end)
        {
            if (start >= end) return;

            if (a[start] > a[end])
            {
                int t = a[start];
                a[start] = a[end];
                a[end] = t;
            }

            if (end - start + 1 >2)
            {
                int t = (end - start + 1) / 3;
                stoogesort(a, start, end - t);
                stoogesort(a, start + t, end);
                stoogesort(a, start, end - t);
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            count = Convert.ToInt32(textBox1.Text);
            rArr = new int[count];
            Random R = new Random();

            //Вывод исходного массива на экран
            for(int i = 0; i < count; i++)
            {
                rArr[i] = R.Next(10);
                textBox2.Text += rArr[i] + "\r\n";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            //Сортировка и вывод массива на экран
            stoogesort(rArr, 0, count - 1);

            foreach (var i in rArr)
            {
                textBox3.Text += i + "\r\n";
            }
            MessageBox.Show("Массив отсортирован.");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
