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
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] arrstr = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(arrstr[i]);
                arr[i] = x;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}