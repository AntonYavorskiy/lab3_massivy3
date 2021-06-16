using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_mas3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 3. Массивы 3:Вывести индекс последнего максимального элемента.");
            int v = 33;
            Console.WriteLine("                      Порядковый номер по списку группы: 33");
            Console.WriteLine("                                " + ((v % 10) + 1) + " Вариант");

            Console.Write("Введите количество элементов:");
            var len = int.Parse(Console.ReadLine());

            var array = new int[len];
            int max = -1;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i+" Элемент = ");
                array[i] = int.Parse(Console.ReadLine());
            }

    
            
           
            for (int i = 0; i < array.Length; i++)

                if (max <= array[i])
                {
                    max = array[i];
                    index = i;
                }
            Console.WriteLine("Индекс последнего максимального элемента "+ "("+max+ "): " + + index);




            Console.ReadKey();
        }
    }
}
