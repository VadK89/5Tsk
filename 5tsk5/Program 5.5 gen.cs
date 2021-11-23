using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tsk5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод числа N
            Console.WriteLine("введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            //Задаем массив
            int[,] mas= new int[n, n];
            //Вывод массива в требуемой форме
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = 1-(i + j) % 2;
                    Console.Write("{0,2}", mas[i, j]);                    
                }
                Console.WriteLine();
            }            
            Console.ReadKey();
        }
    }
}
