using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//input of "n" variable which is the lenght of 2D array of integers
            int[,] arr = new int[n, n]; //creating 2D array of integers with length "n*n"
            for (int i = 0; i < n; i++) //double loop for displaying 2D array on console
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                        Console.Write("[*]"); //elements of 2D array


                }
                Console.WriteLine();//analoge of endl for makin space after every row
            }
            Console.ReadKey();

        }
    }
}