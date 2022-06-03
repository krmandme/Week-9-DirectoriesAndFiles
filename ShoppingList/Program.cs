using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
	class Program
	{
		static void Main(string[] args)
		{
            string fileLocation = @"C:\Users\...\Samples\Ostunimekiri";
            string fileName = @"\\Ostunimekiri.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a product to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter product:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }

            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your product: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
	}
}
