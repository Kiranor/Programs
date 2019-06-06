using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Var7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)        
        {            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


            int count = Convert.ToInt32(textBox1.Text);
            int i = 0;
            int positive = 0;
            int sumEven = 0;
            int countEven = 0;
            int[] rArr = new int[count];
            Random random = new Random();

            //Генерация элементов массива
            while (i<count)
            {
                rArr[i] = random.Next(10);

                //Проверка на положительность
                if (rArr[i] >= 0) { positive++; }

                //Проверка на четность
                if (rArr[i]%2 == 0)
                {
                    sumEven += rArr[i];
                    countEven++;
                }

                //Вывод элементов в textBox
                textBox2.Text += rArr[i] + "\t\n";
                i++;
            }

            //Вывод результатов выисления 
            textBox4.Text += (float) sumEven / countEven;
            textBox3.Text += positive;
            
            MessageBox.Show("Среднее аримфетическое:" + (float) sumEven/countEven);
            MessageBox.Show("Количество положительных элементов:" + positive);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
