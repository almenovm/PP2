using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {

        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
            {

                Console.Write("    ");
            }
        }
        static void Folders(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles();

            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);

                Console.WriteLine(file.Name);
            }

            for (int i = 0; i < directories.Length; i++)
            {
                PrintSpaces(level);
                Console.WriteLine(directories[i].Name);
                Folders(directories[i], level + 1);
            }
        }
        static void Main(string[] args)
        {

            DirectoryInfo d = new DirectoryInfo("C:/Users/Альменов/Desktop/test1");
            Folders(d, 0);
            Console.ReadKey();
        }

    }
}
