using System;
using System.IO;

namespace MyShopingList1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\samples";

            Directory.CreateDirectory($"{rootDirectory}\\ShoppingList");

            File.Create($"{rootDirectory}\\ShoppingList\\ShoppingList.txt");
        }
    }
}