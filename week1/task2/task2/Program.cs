using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;
        public string ID;
        public int year;

        public Student(string name, string ID, int year)
        {
            this.name = name;
            this.ID = ID;
            this.year = year;
        }
        public void Print()
        {
            Console.WriteLine(name + " " + ID + " " + year);
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Student st1 = new Student("Madiyar", "18BD110159", 2018);
            while (st1.year < 2022)
            {
                st1.year++;
                st1.Print();
            }
            Console.ReadKey();


            
        }
    }
}