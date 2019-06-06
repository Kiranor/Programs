using System;
namespace Lab3_Var2
{
        class Base
        {
            public double W { get; set; }
            public double L { get; set; }
            public double H { get; set; }

            //Конструктор с присвоением 0 значений
            public Base()
            {
                Console.WriteLine("Вызван конструктор объекта родительского класса....");
                W=L=H = 0;
            }

            //Метод для ввода данных
            public void InputValue()
            {
                Console.WriteLine("Вызван метод ввода значений свойств экземляра класса....");
                Console.Write("Ввести W:");
                W = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ввести L:");
                L = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ввести H:");
                H = Convert.ToDouble(Console.ReadLine());
            }

            public void PropertiesSumm()
            {
                Console.WriteLine("Вызван метод суммы значений свойств объекта....");
                double Sum = W + L + H;
                Console.WriteLine("Сумма свойств класса равна:"+Sum);
            }

            public void WriteProperties()
            {
                Console.WriteLine("Вызван метод вывода свойств объекта на экран...");
                Console.WriteLine("Значение W:" + W + "\n" +
                                  "Значение L:" + L + "\n" +
                                  "Значение H:" + H);
            }


        }
}

