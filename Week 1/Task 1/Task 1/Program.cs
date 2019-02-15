using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1a
{
    class Program
    {
        static public bool Prime(int p)// создание функции 
        {
            if (p == 1) return false;

            for (int i = 2; i < p; i++)//создание цикла для данной функции
            {
                if (p % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int count = 0;// создание счетчика
            int p = Convert.ToInt32(Console.ReadLine());//перевод значений из стринга в инт
            int[] arr = new int[p];

            for (int i = 0; i < p; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < p; i++)
            {
                if (Prime(arr[i]))//обращение к функции
                {
                    count++;
                }
            }
            Console.WriteLine(count);//вывод счетчика через энтер
            for (int i = 0; i < p; i++)
            {
                if (Prime(arr[i]))
                {
                    Console.Write(arr[i] + " ");//вывод значений прайм чисел
                }
            }

        }
    }
}
