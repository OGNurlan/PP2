using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static bool Pol(string a)//creating a function
        {
            for(int i= 0; i< a.Length/2; i++)
            {
                if (a[i] != a[a.Length - 1 - i]) return false;//condition for determining polinom
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\Asus\Desktop\PP2\Week 2\Task 1\1.txt");
            string k = r.ReadToEnd();
            if (Pol(k) == true)
                Console.WriteLine("Yes"); 
            else Console.WriteLine("No");

        }
    }
}
