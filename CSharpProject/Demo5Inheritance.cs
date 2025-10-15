using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Father
    {
        public int fAge = 60;

        public Father(int f)
        {
            fAge = f;
            Console.WriteLine("Father constructor!!!");
        }

        public void FatherStyle()
        {
            Console.WriteLine("father sytle123!!!");
        }
    }

    class Son : Father
    {
        public int sAge = 20;

        public Son(int f,int s):base(f)
        {
            sAge = s;
            Console.WriteLine("Son constructor");
        }
        public void SonStyle()
        {
            Console.WriteLine("Son style");
        }

    }
    class GrandSon : Son
    {
        public int gAge = 10;
        public GrandSon(int a,int b, int c):base(a,b)
        {
            gAge = c;
        }
    }

    public class Demo5Inheritance
    {
        static void Main(string[] args)
        {
           
            GrandSon sonObj=new GrandSon(80,40,10);

            Console.WriteLine(sonObj.fAge);
            Console.WriteLine(sonObj.sAge);

            sonObj.FatherStyle();
            sonObj.SonStyle();

            Console.WriteLine(sonObj.gAge);

           

        
        }
    }
}
