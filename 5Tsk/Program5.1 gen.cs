using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Tsk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем массив
            int[] array = new int[7];
            int s=0;
            int ar =0;
            // Ввод элементов массива и вычисление его среднего арифметического
            
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите элемент массива и нажмите Enter");
                int a = Convert.ToInt32(Console.ReadLine());
                s += a;
                ar = s / 7;
            }
            Console.WriteLine("Среднее арифметическое округленное {0}",ar);
            Console.ReadKey();
        }
    }
}
