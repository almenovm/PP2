using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //input of "n" variable which is the lenght of array of integers
            int[] arr = new int[n]; //creating array of integers with length equal to "n"
            string[] arrstr = Console.ReadLine().Split(); //creating second array of strings
            for (int i = 0; i < n; i++) //loop for rewriting values from array of strings to array of integers
            {
                int x = int.Parse(arrstr[i]);//here by Parse we change the type of data from string to integer and assigning it to variable "x"
                arr[i] = x;//assigning value of "x" to cells of array of integers called "arr"
            }
            for (int i = 0; i < n; i++) //loop for displaying previous array's numbers twice in order
            {
                Console.Write(arr[i] + " ");//fuction for displaying on console 
                Console.Write(arr[i] + " ");//fuction for displaying on console 
            }
            Console.ReadKey();
        }
    }
}