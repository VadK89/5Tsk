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
            // Вывод массива 
            for (int i=0; i < n; i++)
            {
                for (int j=0; j < n; j++)
                {
                    Console.Write("{0,4}", mas[i, j]);

                }
                Console.WriteLine();
            }
            //For magic square         
            int[] sum = new int[n];//массив для вычисления сумм
            int d1 = 0;
            int d2 = 0;            
            //подсчет сумм
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum[i] += mas[i, j];// сумма элементов строки
                    sum[j] += mas[i, j];//сумма элементов столбца
                    if (i==j)
                    {
                        d1 += mas[i, j];//сумма элементов главной диагонали
                    }
                    if (i+j==n-1)
                    {
                        d2 += mas[i, j]; // сумма элементов побочной диагонали
                    }                    
                }               
            }
            //проверка на магичность
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Суммма элементов {0} строки составляет {1}", i, sum[i]);
                    Console.WriteLine("Суммма элементов {0} столбца составляет {1}", j, sum[j]);
                    Console.WriteLine("Суммма элементов диагонали составляет {0}", d1);
                    Console.WriteLine("Суммма элементов диагонали составляет {0}", d2);
                    if (sum[i] == sum[j] && sum[j] == d1 && d1 == d2 && d2 != 0)
                    {
                        Console.WriteLine("Магический квадрат");
                    }
                    else
                    {
                        Console.WriteLine("квадрат не магический");
                    }
                }
            }
            Console.ReadKey();
        }
            

        
    }
}
