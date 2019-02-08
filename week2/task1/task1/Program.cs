 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        public static string Reversem(string s)
        {
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Input.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            string rv = Reversem(s);
            int cnt = 0;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == rv[i])
                    cnt++;
            }
            StreamWriter sw = new StreamWriter("Output.txt");
            if (cnt == s.Length)
            
                sw.WriteLine("Yes");
                else
                sw.WriteLine("No");
                
                sw.Close();
   
            Console.ReadKey();
        }
    }
}
