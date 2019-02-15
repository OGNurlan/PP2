using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool prime(int n) // function which will check prime number 
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;// if the number will have reminder 0, when it divide to number between 2 and n, it is false 
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader input = new StreamReader(@"C:\Users\ASUS\Desktop\PP2\Week 2\Task 2\input.txt"); // object which will read the text 
            StreamWriter output = new StreamWriter(@"C:\Users\ASUS\Desktop\PP2\Week 2\Task 2\output.txt"); // object which will write to the file 
            string n = input.ReadLine(); // reads to string 
            string[] a = n.Split(' '); // creating an array and split string n // split-divide array on parts
            foreach (string s in a)
            {
                if (prime(int.Parse(s)))
                    output.Write(s + " ");
            }
            input.Close();
            output.Close();
        }
    }
}
