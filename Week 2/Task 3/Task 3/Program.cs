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
        static void indents(int step)// создание функции для отступов при показе папок
        {
            for (int i = 0; i < step; i++)
                Console.Write("  ");
        }
        static void Floor(DirectoryInfo directory, int step)// класс DIRECTORYINFO для создания, удления, перемещения и других функций с каталогом.
        {

            FileInfo[] files = directory.GetFiles();// сохраняем информации о файлах в папке
            DirectoryInfo[] directories = directory.GetDirectories();// сохраняем информацию о папке в папке
            foreach (FileInfo file in files)
            {
                indents(step);// отправляем уровень этажа в фукнцию для отступа 
                Console.WriteLine(file.Name);//вывод названия файла
            }
            foreach (DirectoryInfo dir in directories)
            {
                indents(step);// отправляем уровень этажа в фукнцию для отступа 
                Console.WriteLine(dir.Name);//вывод названия файла
                Floor(dir, step + 1);// обращается к функции, увеличивая уровень
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Asus\Desktop\PP2");// сохраняем информацию о папке
            Floor(directory, 0);// 
            Console.ReadKey();
        }
    }
}

