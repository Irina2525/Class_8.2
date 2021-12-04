using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string path = "D:/BIM обучение/Урок №8/Class_8.2/Log.txt";  // строковая переменая где хранится путь
                using (StreamWriter sw = new StreamWriter(path, false)) // создаем экземпляр класса (путь+логическая переменная false- данные перезаписываются)
                {
                    int[] array = new int[10];
                    Random random = new Random();
                    
                    for (int i = 1; i < 10; i++)
                    {
                        array[i] = random.Next(0, 10);      // Next заполнит случайными числами 
                        sw.WriteLine(array[i]);  
                        Console.Write("{0}; ", array[i]);
                    }
                }
                int sum = 0;
                string[] lines = File.ReadAllLines(path);    // возвращает строки файла в виде массива string
                foreach (string s in lines)    // переменная s последовательно принимает значения из масива lines

                {
                    sum += Convert.ToInt32(s);  // += накапливаем сумму переменных s
                }
                Console.WriteLine();
                Console.WriteLine("Сумма = {0}", sum);
                Console.ReadKey();

            }
        }
    }
}





