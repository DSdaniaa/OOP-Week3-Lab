using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class product
    {
        public product()
        {
            Console.WriteLine("Default Constructor Called");
        }
        public product(string n)
        {
            name = n;
        }
        public product(string n,string c)
        {
            name = n;
            category = c;
        }
        public product(string n, string c,float p)
        {
            name = n;
            category = c;
            price = p;
        }
        public product(string n, string c, float p,int q)
        {
            name = n;
            category = c;
            price = p;
            stockQuantity = q;
        }
        public product(string n, string c, float p, int q,int m)
        {
            name = n;
            category = c;
            price = p;
            minStockQuantity = m;
            stockQuantity = q;
        }
        public product(product s)
        {
            name = s.name;
            category = s.category;
            price = s.price;
            stockQuantity = s.stockQuantity;
            minStockQuantity = s.minStockQuantity;

        }
        public string name;
        public string category;
        public float price;
        public int stockQuantity;
        public int minStockQuantity;

       
    }
}
