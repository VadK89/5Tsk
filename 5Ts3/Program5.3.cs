using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Ts3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Сформировать одномерный массив из 10 случайных чисел в диапазоне[-50; 50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.//Задаем массив 
            const int k = 10;
            const int n = -50;
            const int m = 50;
            int[] array = new int[k];
            Random random = new Random();
            //Выводим массив
            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(n, m);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            //Сортировка и упорядочивание по возрастанию первой половины массива чисел
            for (int i = 0; i < k/2-1; i++)
            {
                for (int j = i+1; j < k/2; j++)
                {
                    if (array [i]>array [j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }

                }
            }
            //Сортировка и упорядочивание по возрастанию первой половины массива чисел
            for (int i = k/2; i < k-1 ; i++)
            {
                for (int j = i; j < k; j++)
                {
                    if (array[i] < array[j])
                    {
                        int y = array[i];
                        array[i] = array[j];
                        array[j] = y;
                    }

                }
            }

            //Выводим массив после сортировки
            for (int i = 0; i < k; i++)
            {
               Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
