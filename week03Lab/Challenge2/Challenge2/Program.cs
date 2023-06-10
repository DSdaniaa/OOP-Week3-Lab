using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> s = new List<product>();
            char option;
            string name;
            do
            {
                option = productMenu();
                if (option == '1')
                {
                    s.Add(addProduct());
                    
                }
                else if (option == '2')
                {
                    viewProducts(s);
                }
                else if (option == '3')
                {
                    name = findProduct(s);
                    Console.Clear();
                    Console.WriteLine("Product with the Highest Unit Price is: {0}", name);
                    Console.ReadKey();

                }
                else if (option == '4')
                {
                    tax(s);
                }
                else if(option == '5')
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("invalid Choice");
                }
            } while (option != '5');
            Console.WriteLine("Press Enter To Exit...");
            Console.Read();
        }
        static char productMenu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press1 to Add a product ");
            Console.WriteLine("press2 to view products");
            Console.WriteLine("press3 to Find Product with the Highest Unit Price");
            Console.WriteLine("press4 to View Sales Tax of All Products. ");
            Console.WriteLine("press5 to exit");
            choice = char.Parse(Console.ReadLine());
            return choice;

        }
        static product addProduct()
        {
            Console.Clear();
            product s1 = new product();
            Console.Write("Enter the name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter the category: ");
            s1.category = Console.ReadLine();
            Console.Write("Enter the price: ");
            s1.price = float.Parse(Console.ReadLine());
            Console.Write("Enter the stock Quantity: ");
            s1.stockQuantity = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minimum Stock Quantity: ");
            s1.minStockQuantity = int.Parse(Console.ReadLine());

            return s1;
        }
        static void viewProducts(List<product> s)
        {
            Console.Clear();
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine("Name: {0} Category: {1} Price: {2} Stock Quantity: {3} Minimum Stock Quantity: {4}", s[i].name, s[i].category, s[i].price, s[i].stockQuantity, s[i].minStockQuantity);
            }
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
        static string findProduct(List<product> s)
        {
            int temp = -1;
            Console.Clear();
            for (int i = 1; i < s.Count; i++)
            {
                if (s[i - 1].price > s[i].price)
                {
                    temp = i - 1;
                }

            }
            return s[temp].name;
        }
        static void tax(List<product> s)
        {
            Console.Clear();
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].category == "fruit" || s[i].category == "Fruit")
                {
                    Console.WriteLine("Product Name: {0} Tax: 5%", s[i].name);
                }
                else if (s[i].category == "grocery" || s[i].category == "Grocery")
                {
                    Console.WriteLine("Product Name: {0} Tax: 10%", s[i].name);
                }
                else
                {
                    Console.WriteLine("Product Name: {0} Tax: 15%", s[i].name);
                }
            }
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();

        }
    }
}
