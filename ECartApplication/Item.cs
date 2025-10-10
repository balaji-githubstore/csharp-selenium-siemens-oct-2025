using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECartApplication
{
    public class Item 
    {
        private int _id;
        private string _description;
        private double _price;
        private int _quanity;

        public Item(int quanity)
        {
            if (quanity > 0)
            {
                _quanity = quanity;
            }
        }
        //will resume at 11:10 AM IST
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    Console.WriteLine("Invalid id. Default value or already provided will be retained!!!");
                }
            }
        }

        //create property for price 
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Invalid Price. Default value or already provided will be retained!!!");
                }
            }
        }


        public string Description
        {
            set
            {
                if(value.Length>=10 && value.StartsWith("I"))
                {
                    _description = value;
                }
                else
                {
                    Console.WriteLine("Please provide atleast 10 characters!!!");
                }
            }
        }

        public int Quantity
        {
            get { return _quanity; }
        }
    }
}
