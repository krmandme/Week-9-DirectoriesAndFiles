using System;
using System.IO;

namespace DirectoriesAndFiles
{
	class Program
	{
		static void Main(string[] args)
		{
            string rootDirectory = @"C:\Users\...\Samples";
            Console.WriteLine("Enter directory name:");

            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();


            if (System.IO.Directory.Exists($"{rootDirectory}\\{newDirectory}") && System.IO.File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exist.");
            }
            else
            {
				System.IO.Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
	}
}
