using System;

namespace Lab1_var7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Задание 1 
            double alpha = 1.2;
            double t, r, c, u0, u;

            Console.WriteLine("Ввести емкость конденсатора в мФарад:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ввести сопротивление резистора в МОм:");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ввести напряжение на конденсаторе в кВ:");
            u0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ввести время в с:");
            t = Convert.ToDouble(Console.ReadLine());

            c = c * Math.Pow(10, -6);
            r= r * Math.Pow(10, 6);
            u = u0 / (Math.Pow(2, t / (alpha * c * r)));

            Console.WriteLine("Напряжение на конденсаторе равно "+u+" кВ.");
            //Console.ReadKey();



            //Задание 2
            string First, Second, Conc;
            //Ввод с клавиатуры и чтение исходных строк с отбрасыванием  лишних пробелов в начале и конце
            Console.WriteLine("Вести первую строку:");
            First =Console.ReadLine().Trim(' ');

            Console.WriteLine("Вести вторую строку:");
            Second = Console.ReadLine().Trim(' ');

            Conc = String.Concat(First, ' ', Second);
            Console.WriteLine("Конкатинация исходных строк:"+Conc);

            string FinalString=String.Concat(Conc.Substring(0, 2), ' ', Conc.Substring(Conc.Length-2));        
            Console.WriteLine("Строка, полученная путем взятия 2-х символов из начала и конца предыдущей строки:"+FinalString);
            
            Console.ReadKey();
        }
    }
}
