using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4

{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C: /Users/Альменов/Desktop/path/test1.txt");
            sw.Write(111);
            sw.Close();
            string sourceFile = @"C:\Users\Альменов\Desktop\path\test1.txt";
            string dest = @"C:\Users\Альменов\Desktop\path1\test1.txt";
            File.Copy(sourceFile, dest);
            File.Delete(sourceFile);
        }
    }
}
