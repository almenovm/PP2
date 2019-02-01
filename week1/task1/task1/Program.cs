using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Prime(int x)
            {
                int crt = 0; //counter of deviders
                for (int i = 1; i <= x; i++) // loop for counting deviders
                { if (x % i == 0) crt++; } //

                if (crt == 2) //if number of deviders equal to then researching number is prime
                    return true; 
                return false; //if number of dividers is more or less then 2 then the researching nubmer is not prime
            }




            int n = int.Parse(Console.ReadLine()); //input of "n" variable which is the lenght of array of integers
            int[] arr = new int[n]; //creating array of integers with length equal to "n"
            string[] arrstr = Console.ReadLine().Split(); //creating second array of strings
            for (int i = 0; i < n; i++) //loop for rewriting values from array of strings to array of integers
            {
                int x = int.Parse(arrstr[i]); //here by Parse we change the type of data from string to integer and assigning it to variable "x"
                arr[i] = x; //assigning value of "x" to cells of array of integers called "arr"
            }
            int cnt = 0; //counter of prime numbers
            for (int i = 0; i < n; i++) //loop for counting prime numbers
            {
                if (Prime(arr[i])) //cheking numebrs for being prime by early created function "Prime"
                    cnt++; //plusing 1 every cycle if condition satisfied
            }
            Console.WriteLine(cnt); //displaying on console the number of prime numbers
            for (int i = 0; i < n; i++) //loop for checking and displaying numbers that sitisfied the folowing condition 
            {
                if (Prime(arr[i])) //checking nubers of array of integers for being prime
                    Console.Write(arr[i] + " "); //displaying on console numbers of array that satisfied the  above condition
            }
            Console.ReadKey();



        }
    }
}