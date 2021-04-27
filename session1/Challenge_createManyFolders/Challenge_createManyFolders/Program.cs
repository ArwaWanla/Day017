using System;
using System.IO;

namespace Challenge_createManyFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/arwawanla/Desktop/txtfiles/";
            string folder = "/Challenge";
            string file = "/file.txt";

            Directory.CreateDirectory(path + folder);
            for (int i = 1; i <=10; i++)
            {
                File.CreateText(path + folder + (file + i));
            }
        }
    }
}
