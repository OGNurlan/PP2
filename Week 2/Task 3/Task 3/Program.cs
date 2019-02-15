using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void spaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }
        static void Task3(DirectoryInfo directory, int level)
        {

            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (FileInfo file in files)
            {
                spaces(level);
                Console.WriteLine(file.Name);
            }
            foreach (DirectoryInfo dir in directories)
            {
                spaces(level);
                Console.WriteLine(dir.Name);
                Task3(dir, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Asus\Desktop\PP2");
            Task3(directory, 0);
            Console.ReadKey();
        }
    }
}

