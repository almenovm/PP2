using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student //creating new class with parameters
    {
        public string name; //first string parametere
        public string ID; //second
        public int year; //third

        public Student(string name, string ID, int year)
        {
            this.name = name;
            this.ID = ID;
            this.year = year;
        }
        public void Print() //new function for displaying on console three parameters
        {
            Console.WriteLine(name + " " + ID + " " + year);
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Student st1 = new Student("Madiyar", "18BD110159", 2018); //creating variable in new type of data called "Student"
            while (st1.year < 2022) //loop which adding 1 year before reaching 2022
            {
                st1.year++;//adding 1 year every cycle turn
                st1.Print();//displaying st1 all parameters
            }
            Console.ReadKey();


            
        }
    }
}