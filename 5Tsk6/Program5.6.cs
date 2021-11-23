using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Tsk6
{
    class Program
    {
        static void Main(string[] args)        
        {
            /*6. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. 
             * Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
             * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.*/
            //Ввод числа N
            Console.WriteLine("Введите число N для задания размера массива");
            int n = Convert.ToInt32(Console.ReadLine());
            //Задаем массив
            int[,] mas = new int[n, n];
            for (int i=0 ; i < n; i++)
            {
                for (int j=0; j < n; j++)
                {
                    Console.WriteLine("Введите число {0} строки {1} столбца",i+1, j+1);
                    mas[i, j] = Convert.ToInt32(Console.ReadLine()); 
                }
                Console.WriteLine();  
            }
            //переменные и массив для подсчета сумм
            int[] sum = new int[n];//массив для вычисления сумм
            int[] summ = new int[n];//массив для вычисления сумм
            int d1 = 0;
            int d2 = 0;
            int l = 0;
            int k = 0;
            // Вывод массива 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", mas[i, j]);
                    /*/sum[i] = 0;            
                    sum[j] = 0;*/
                    sum[i] += mas[i, j];//сумма элементов строки
                    summ[j] += mas[j, i];//сумма элементов столбца
                    l = sum[i];
                    k = summ[j];
                    if (i == j)
                    {
                        d1 += mas[i, j];//сумма элементов главной диагонали
                    }
                    if (i + j == n - 1)
                    {
                        d2 += mas[i, j]; // сумма элементов побочной диагонали
                    }
                }
                Console.WriteLine();

            }
            //проверка на магичность
               
            if (l ==k && k == d1 && d1 == d2 && d2 != 0)
            {
                Console.WriteLine("Магический квадрат");
            }
            else
            {
                Console.WriteLine("квадрат не магический");
            }
            Console.ReadKey();
            
        }
            

        
    }
}
