﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// создание переменной n и перевод егов 32 битную систему
            int[] a = new int [n] ;
            for(int i=0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine(a[i]+" " + a[i]);// вывод I-Того значения + пробел + I-того значения
            }
        }
    }
}
