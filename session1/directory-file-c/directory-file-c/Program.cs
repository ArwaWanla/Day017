using System;
using System.IO;


namespace directory_file_c
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/arwawanla/Desktop/txtfiles/";
            string folderName = "/Arwa";

            string fileName = "/Tulip.txt";


            //if (!Directory.Exists(path + folderName))
            //{
            //    Directory.CreateDirectory(path + folderName);
            //    Console.WriteLine("Folder ' " + folderName + " ' created");

            //    //2.now we want to delete the folder
            //   /* Directory.Delete(path + folderName);
            //    Console.WriteLine("Folder ' " + folderName + " ' deleted");*/
            //}
            //else
            //{
            //    Console.WriteLine("Folder ' " + folderName + " ' exists");
            //}



            //3. create a file inside given path
            //File.Create(path + folderName + fileName);
            //Console.WriteLine("Folder ' " + fileName + " ' created in folder "+ folderName);

            //4.write in the txt file
            //File.WriteAllText(path + folderName + fileName, "Love you more");

            ////5.read the txt file
            //string content = File.ReadAllText(path + folderName + fileName);
            //Console.WriteLine(content);

            //6.delete file
            if (File.Exists(path + folderName + fileName))
            {
                File.Delete(path + folderName + fileName);
            }
            else
            {
                Console.WriteLine("File '" + fileName+" ' deleted");
            }
        }
    }
}
