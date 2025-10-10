using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject2
{
    public class Calculator
    {
        private int a = 9;
        
        public void Add(int a, int b)
        {
            a = 999;

            Console.WriteLine(a);
            Console.WriteLine(this.a);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Add(int a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(double b, int a)
        {
            Console.WriteLine(a + b);
        }
    }


    
}
