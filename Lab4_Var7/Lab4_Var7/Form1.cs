using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Var7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

    public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            try
            {
                Pen pen = new Pen(Color.Black, Convert.ToInt32(textBox4.Text));  

                //Создание списка индивидуальных кистей для закрашивания прямоугольников
                Brush[] brushes = new Brush[4];
                brushes[0] = new SolidBrush(Color.Gray);
                brushes[1] = new SolidBrush(Color.LightGray);
                brushes[2] = new SolidBrush(Color.White);
                brushes[3] = new SolidBrush(Color.FromArgb(Convert.ToInt32(textBox1.Text),
                                                           Convert.ToInt32(textBox2.Text),
                                                           Convert.ToInt32(textBox3.Text)));       
                Size size = new Size(500, 200);

                Point point = new Point(50, 20);

                Rectangle[] rectangles = new Rectangle[4];
                
                //Генерация вложенных прямоугольников

                for (int i = 0; i < 4; i++)
                {
                    rectangles[i] = new Rectangle(point, size);
                    rectangles[i].Offset(i*20, i*20);
                    size.Width -=  40;
                    size.Height -= 40;
                }

                //Внутренний прямоугольник с закругленными краями
                {
                    //Левый верхник угол
                    graph.DrawArc(pen, rectangles[1].X, rectangles[1].Y, 100, 100, 180, 90);
                    //Правый верхний угол
                    graph.DrawArc(pen, rectangles[1].X + rectangles[1].Width - 100, rectangles[1].Y, 100, 100, 270, 90);
                    //Правый нижний угол
                    graph.DrawArc(pen, rectangles[1].X + rectangles[1].Width - 100, rectangles[1].Y + rectangles[1].Height - 100, 100, 100, 0, 90);
                    //Левый нижник угол
                    graph.DrawArc(pen, rectangles[1].X, rectangles[1].Y + rectangles[1].Height - 100, 100, 100, 90, 90);
                    //Верхняя линия
                    graph.DrawLine(pen, rectangles[1].X + 50, rectangles[1].Y, rectangles[1].X + rectangles[1].Width - 50, rectangles[1].Y);
                    //Нижняя линия
                    graph.DrawLine(pen, rectangles[1].X + 50, rectangles[1].Y + rectangles[1].Height, rectangles[1].X + rectangles[1].Width - 50, rectangles[1].Y + rectangles[1].Height);
                    //Левая линия
                    graph.DrawLine(pen, rectangles[1].X, rectangles[1].Y + 50, rectangles[1].X, rectangles[1].Y + rectangles[1].Height - 50);
                    //Правая линия
                    graph.DrawLine(pen, rectangles[1].X + rectangles[1].Width, rectangles[1].Y + 50, rectangles[1].X + rectangles[1].Width, rectangles[1].Y + rectangles[1].Height - 50);
                }
                
                 //Внешний прямоугольник
                 graph.DrawRectangle(pen,rectangles[0]);
                 //Внутренний овал
                 graph.DrawEllipse(pen, rectangles[2]);
                 graph.FillEllipse(brushes[2], rectangles[2]);
                 //Внутренний овал с выбранным пользователем цветом
                 graph.DrawEllipse(pen, rectangles[3]);
                 graph.FillEllipse(brushes[3], rectangles[3]);
                 
                pictureBox1.Image = bmp;
            }
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
