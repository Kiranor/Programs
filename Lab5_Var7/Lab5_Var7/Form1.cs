using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Var7
{
    
    public partial class Form1 : Form

    {
        int count ;
        int i = 0;
        List<string> vs = new List<string>();
        bool IsOrdered = true;
        string response = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            int count = Convert.ToInt32(textBox2.Text);
            dialog.Title = "Выбрыть файл с массивом.";
            dialog.Filter = "txt file (*.txt)|*.txt|all files (*.*)|*.*";
            textBox1.Clear();
            textBox3.Clear();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = String.Join("\r\n", File.ReadAllLines(dialog.FileName));

                StreamReader reader = new StreamReader(dialog.FileName, Encoding.Default);

                //Считывание заданного пользователем количества элементов из файла
                while (i < count)
                {
                    vs.Add((reader.ReadLine()));
                    textBox3.Text += vs[i] + "\r\n";
                    i++;
                }

                //Проверка на возрастание считанного массива
                for (int j = 0; j < vs.Count - 1; j++)
                {
                    if (Convert.ToInt32(vs[j]) <= Convert.ToInt32(vs[j + 1]))
                    {
                        IsOrdered = false;
                        break;
                    }
                }
                //Вывод в элемент textBox4 сообщения о состоянии массива
                if (IsOrdered)  response = "Числовой массив упорядочен по убыванию."; 
                else  response = "Числовой массив не упорядочен по убыванию."; 

                textBox4.Text = response;  
            }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Сохранение результат вычисления в выбранный файл.";
            saveFile.Filter = "txt file (*.txt)|*.txt|all files (*.*)|*.*";

            //Открытие окна выбора файла для сохраниения в него результатов работы программы
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFile.FileName, vs);
                MessageBox.Show("Файл сохранен.","Сохранение...");
            } 
        }
    }
}
