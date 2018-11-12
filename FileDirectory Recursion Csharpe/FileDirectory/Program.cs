using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directo = new DirectoryInfo(@"C:\Users\Owner\Documents\Visual Studio 2015\Projects");
            FileDirectory(directo);
        }

        static void FileDirectory(DirectoryInfo directory)
        {
            DirectoryInfo[] subDirs = directory.GetDirectories();
            for (int i = 0; i < subDirs.Length; i++)
            {
                Console.WriteLine("/dir - {0}", subDirs[i].Name);
                FileDirectory(subDirs[i]);

            }
            FileInfo[] subFiles = directory.GetFiles();
            for (int i = 0; i < subFiles.Length; i++)
            {
                Console.WriteLine("\t file - {0}", subFiles[i].Name);

            }
         
        }
    }
    }

