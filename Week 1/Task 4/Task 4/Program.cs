using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];// создание двойного массива
            for(int i = 0; i < n; i++)
            {
                for (int j=0; j <= i; j++)//создание цикла 
                {
                    Console.Write("[*]");// вывод в форме звездочек
                }
                Console.WriteLine();
            }
        }
    }
}
