using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject2
{
    public class Demo2Variable
    {
        public static int aS = 10;    //static variable or class variable
        public static int bS = 20;

        public int aNS = 10;        //non-static variable or instance variable 
        public int bNS = 20;


        static void Main2(string[] args)
        {
            Demo2Variable.aS = 5000;

            Console.WriteLine(Demo2Variable.aS);
            Console.WriteLine(Demo2Variable.bS);

            Demo2Variable obj1=new Demo2Variable();
            Demo2Variable obj2 = new Demo2Variable();
            Demo2Variable obj3 = new Demo2Variable();

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine(obj3.GetHashCode());

            obj1.aNS = 6000;

            obj3.aNS = 2000;

            obj2 = obj1;  //asking obj2 to point to the object refered by the obj1

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine(obj3.GetHashCode());


            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);

            Console.WriteLine(obj2.aNS);
            Console.WriteLine(obj2.bNS);

            Console.WriteLine(obj3.aNS);
            Console.WriteLine(obj3.bNS);
        }
    }
}
