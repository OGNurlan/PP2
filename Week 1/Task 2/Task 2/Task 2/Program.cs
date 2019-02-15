using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    class Student// Create a class
    {
        string name;// values of class
        string id;
        public int yearofStudy;

        public Student(string n, string i)// Constructor with parameters 
        {
            name = n;
            id = i;
        }

        public void data() // fill the information of student
        {
            Console.WriteLine("Name of student: " + name + "\n" + "ID of student: " + id);//output of name and id
        }

        public int NextYear(int y)// changing the year of study to +1
        {
            yearofStudy = y;
            return yearofStudy + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");
            string sName = Console.ReadLine();// name of student       
            Console.WriteLine("Write ID: ");
            string sId = Console.ReadLine();// id of student    


            Console.WriteLine("Write year of study: ");
            int sYear;
            string num = Console.ReadLine();// assigns  (присваивает) value to the num

            sYear = int.Parse(num);


            Student s = new Student(sName, sId);//Constuctor with parameters 
            s.data();//call the method
            Console.WriteLine("Next Year of study: " + s.NextYear(sYear));
        }
    }
}