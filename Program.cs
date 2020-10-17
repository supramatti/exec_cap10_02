using exec_cap10_01.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace exec_cap10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> product = new List<Product>(n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    product.Add(new ImportedProduct(name, price, customFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    product.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product obj in product)
            {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}
