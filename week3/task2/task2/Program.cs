using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class FarManager
    {
        public int cursor = 0;
        public string path;
        public int sz;
        public bool ok = true;


        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }

        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }


        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] fileSystemInfos = directory.GetFileSystemInfos();
            sz = fileSystemInfos.Length;

            int index = 0;
            int pos = 1;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (FileSystemInfo fs in fileSystemInfos)
            {
                if (ok && fs.Name.StartsWith("."))
                {
                    sz--;
                    continue;
                }
                Color(fs, index);
                Console.Write(pos + ".");
                pos++;
                Console.WriteLine(fs.Name);
                index++;


            }
        }




        public void Start(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            FileSystemInfo fs = null;
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                consoleKey = Console.ReadKey();

                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    directory = directory.Parent;
                    path = directory.FullName;
                }

                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();

                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();

                if (consoleKey.Key == ConsoleKey.RightArrow)
                    ok = false;

                if (consoleKey.Key == ConsoleKey.LeftArrow)
                    ok = true;
                /*if (consoleKey.Key == ConsoleKey.R)
                {
                    
                        for (int i = 0, k = 0; i < directory.GetFileSystemInfos().Length; i++)
                        {
                            if (ok && directory.GetFileSystemInfos()[i].Name.StartsWith("."))
                                continue;
                            if (cursor == k)
                            {
                                fs = directory.GetFileSystemInfos()[i];
                                break;
                            }
                            k++;
                        }
                    DirectoryInfo deldirinfo = new DirectoryInfo(fs.FullName);
                    File.Move(fs.FullName, Console.ReadLine());

                }*/

                if (consoleKey.Key == ConsoleKey.D)
                {
                    for (int i = 0, k=0; i < directory.GetFileSystemInfos().Length; i++)
                    {
                        if (ok && directory.GetFileSystemInfos()[i].Name.StartsWith("."))
                            continue;
                        if (cursor == k)
                        {
                            fs = directory.GetFileSystemInfos()[i];
                            break;
                        }
                        k++;
                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;

                        try
                        {
                            DirectoryInfo deldirinfo = new DirectoryInfo(fs.FullName);
                            deldirinfo.Delete(true);
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    else
                        File.Delete(fs.FullName);



                }

                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    for (int i = 0, k = 0; i < directory.GetFileSystemInfos().Length; i++)
                    {
                        if (ok && directory.GetFileSystemInfos()[i].Name.StartsWith("."))
                            continue;
                        if (cursor == k)
                        {
                            fs = directory.GetFileSystemInfos()[i];
                            break;
                        }
                        k++;

                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        directory = new DirectoryInfo(fs.FullName);
                        path = fs.FullName;
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(fs.FullName);
                        sw.Write(Console.ReadLine());
                        sw.Close();
                    }

                }
            }


        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Альменов/Desktop/test1";
            FarManager farManager = new FarManager();
            farManager.Start(path);
            Console.ReadKey();

        }
    }
}
