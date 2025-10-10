using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECartApplication
{
    public class ItemRunner
    {
        static void Main(string[] args)
        {

            //assume user - adding to cart
            Item item1 = new Item(1);
            Item item2=new Item(4);

            //item 1
            item1.Id = -8;
            item1.Price = -500;
            item1.Description = "I1 Watch488887";

            //item 2
            item2.Id = 90;
            item2.Price = 500;
            item2.Description = "E1 Lenovo Laptop";


            //Item[] items = new Item[2];
            //items[0] = item1;
            //items[1] = item2;

            //Console.WriteLine(items[1].Id);
            
            Console.WriteLine(item2.Quantity);

            item1.Products = new string[2] { "watch", "box" };


            Console.WriteLine(item1.Products[0]);

            Console.WriteLine(item1.Products[1]);
        }
    }
}
