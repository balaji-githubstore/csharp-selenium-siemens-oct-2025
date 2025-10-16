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

            //sonObj.Equals()



            int a = 111;
            string b = "king";


            object z = a; //boxing

            object x = b; //boxing

            object y = sonObj; //boxing


            //object to specific datatype 

            int a1 = (int)z;  //unboxing

            Console.WriteLine(a1+a1);

            string a2 = (string)x; //unboxing

            Console.WriteLine(a2);

            GrandSon a3 = (GrandSon)y; //unboxing

            a3.FatherStyle();

            object aa = 10; //boxing --> putting in the object type
            object bb = "john";
            object cc = 10.3;

            double zz = (double)cc;  //object to double  //unboxing


         
            string[] arr3 = { "red", "yellow", "green" };

        //    object[] demo = arr3;  //boxing

            object[] abc = new object[4];
            abc[0] = 45;
            abc[1] = "jack";
            abc[2] = sonObj;
            abc[3] = arr3;


            int demoabso = (int)abc[0];
            Console.WriteLine(demoabso);



            string[] arr4 = { "red", "yellow", "green" };


            for(int i=0;i<arr4.Length;i++)
            {
                Console.WriteLine(arr4[i]);
            }

        }
    }
}
