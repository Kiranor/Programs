using System;
namespace Lab3_Var2
{
    class Paral:Base
    {
        public double S { get; private set; }
        public double D { get; private set; }
        public double V { get; private set; }


        public Paral() 
        {
            Console.WriteLine("Вызван конструктор объекта дочернего класса...");
            S = D = V = 0; 
        }


        public void Diag()
        {
            Console.WriteLine("Вызван метод расчета диагонали...");
            D = Math.Sqrt(Math.Pow(W, 2) + Math.Pow(L, 2) + Math.Pow(H, 2));
            Console.WriteLine("Диагональ равна:" + D);
        }

        public void Square()
        {
            Console.WriteLine("Вызван метод расчета площади поверхности...");
            S = 2 * (W * H + W * L + L * H);
            Console.WriteLine("Площадь поверхности равна:" + S);
        }

        public void Volume()
        {
            Console.WriteLine("Вызван метод расчета объема...");
            V = W * L * H;
            Console.WriteLine("Объем равен:" + V);

        }

    }
}
