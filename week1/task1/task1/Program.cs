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
                int crt = 0;
                for (int i = 1; i <= x; i++)
                { if (x % i == 0) crt++; }

                if (crt == 2)
                    return true;
                return false;
            }




            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] arrstr = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(arrstr[i]);
                arr[i] = x;
            }
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (Prime(arr[i]))
                    cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                if (Prime(arr[i]))
                    Console.Write(arr[i] + " ");
            }
            Console.ReadKey();



        }
    }
}