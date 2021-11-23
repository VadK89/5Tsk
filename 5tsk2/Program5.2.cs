using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.
            //Задаем массив 
            const int n = 15;
            const int m = 50;
            int s = 0;
            int[] array = new int[n];
            Random random = new Random();
            //Выводим массив
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, m);
                Console.Write("{0} ", array[i]);
            }
            //поиск максимального и минимального значений
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }            
            }
            foreach (int b in array)
            {
                if (b < min)
                {
                    min = b;
                }
            }
            s = max + min;
            //Вывод суммы макс. и мин. значений

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
