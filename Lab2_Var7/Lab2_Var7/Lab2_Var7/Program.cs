using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2_Var7
{
    class MainClass
    {
        public static void Main(string[] argument)
        {
            //Cчитывание из файла всех строк, разбиение на предложения по символам пунктуации и запись в массив 
            char[] Separators = {'.','!','?' };
            string[] Sentences = File.ReadAllText("C:\\Users\\Николай\\Desktop\\Read.txt",
                Encoding.Default).Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            string[] ToWriteSentences = new string[Sentences.Length];
            int k = 0;

            //Пробегаем по всем предложениям и по всем символам в них.
            for (int i = 0; i < Sentences.Length; i++)
            {
                int count = 1;

                for (int j = 0; j < Sentences[i].Length; j++)
                {
                    char h = Sentences[i][j];
                    //Console.Write(Sentences[i][j]);
                    if (Char.IsPunctuation(h)) count++;
                }

                if (count > 3)
                {
                    Console.WriteLine(Sentences[i] + '.' + "Количество знаков препинания:"+count);

                    ToWriteSentences[k] = Sentences[i]+'.';
                    k++;
                }
            }

            //Вывод массива строк, полученных в цикле, в отдельный файл.
            File.WriteAllLines("C:\\Users\\Николай\\Desktop\\Write.txt", ToWriteSentences);
        }

    }
}
