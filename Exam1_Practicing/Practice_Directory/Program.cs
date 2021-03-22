using System;
using System.IO;

namespace Practice_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a directory path to get all the information >> ");
            string path = Console.ReadLine();

            while (Directory.Exists(path) == false)
            {
                Console.WriteLine("Enter a directiory path that exists");
                path = Console.ReadLine();
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Console.WriteLine();
            foreach (var File in directoryInfo.GetFiles())
            {
                Console.WriteLine(File.Name);
            }


        }
    }
}
