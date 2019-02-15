using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\ASUS\Desktop\PP2\Week 2\Task 4\1.txt");//записывает данные в 1.txt
            writer.Write("Nurlan");//данные которые записывает
            writer.Close();// закрывает файл
            File.Copy(@"C:\Users\ASUS\Desktop\PP2\Week 2\Task 4\1.txt", @"C:\Users\ASUS\Desktop\PP2\Week 2\Task 4\2.txt");// копирование папки и создание 2.txt 
            File.Delete(@"C:\Users\ASUS\Desktop\PP2\Week 2\Task 4\1.txt");//удаление первого текстовика
        }
    }
}
