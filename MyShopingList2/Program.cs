using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShopingList2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\ShoppingList";
            string fileName = @"\\shoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppinglist = arrayFromFile.ToList<string>();


            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Add your wish:");
                    string userWish = Console.ReadLine();
                    shoppinglist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Wishes are completed.");
                }
                foreach (string wish in shoppinglist)
                {
                    Console.WriteLine($"your wishes were: {wish}");
                }

                File.WriteAllLines($"{fileLocation}{fileName}", shoppinglist);

            }

        }
    }
}
