using System;

namespace Lab3_Var2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Base Base1 = new Base();
            Paral Paral1 = new Paral();
            Console.WriteLine("Изначальные значения свойств объекта:" + 
                               Base1.H +" " + Base1.W + " " + Base1.L);
            Base1.InputValue();
            Base1.PropertiesSumm();
            Base1.WriteProperties();

            Paral1.InputValue();
            Paral1.Diag();
            Paral1.Square();
            Paral1.Volume();
            Console.ReadKey();


        }
    }
}
