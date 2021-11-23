using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tsk4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем массив 
            const int k = 10;
            const int n = -50;
            const int m = 50;
            int s=0;
            int[] array = new int[k];
            Random random = new Random();
            //Выводим массив
            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(n, m);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            // Поиск нечетных положительных чисел на четных местах
            for (int i = 0; i < k; i+=2)
            {
                if (array[i]>0)
                {
                    if (array[i] % 2 != 0)
                    {
                        s ++;
                    }                  
                }            
            }
            // Вывод реультатов
            Console.WriteLine("Количество нечетных положительных чисел массива стоящих на четных позициях {0}",s);
            Console.ReadKey();
        }
    }
}
