using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {

        static void Main(string[] args)
        {
            bool Prime(int x)
            {
                int crt = 0;
                for(int i=1; i<=x; i++)
                {
                    if (x % i == 0)
                        crt++;
                }
                if (crt == 2)
                    return true;
                return false;
            }

            StreamReader sr = new StreamReader("Input.txt");
            string[] arrstr = sr.ReadToEnd().Split();
            sr.Close();
            int[] arr = new int[arrstr.Length];
            for(int i=0; i<arrstr.Length; i++)
            {
                int x = int.Parse(arrstr[i]);
                arr[i]= x;
            }
            StreamWriter sw = new StreamWriter("Output.txt");
            for (int i=0; i<arr.Length; i++)
            {
                if (Prime(arr[i]))
                    sw.Write(arr[i]+" ");
            }
            sw.Close();
            Console.ReadKey();

        }
    }
}
