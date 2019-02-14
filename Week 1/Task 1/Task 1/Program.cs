using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1a
{
    class Program
    {
        static public bool Prime(int p)
        {
            if (p == 1) return false;// hghgh

            for (int i = 2; i < p; i++)
            {
                if (p % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int count = 0;
            int p = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[p];

            for (int i = 0; i < p; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < p; i++)
            {
                if (Prime(arr[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            for (int i = 0; i < p; i++)
            {
                if (Prime(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}
