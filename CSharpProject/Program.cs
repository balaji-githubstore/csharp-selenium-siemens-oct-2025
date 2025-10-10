using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.CSharpProject
{
    public class Program
    {
        static void Main1(string[] args)
        {
            sbyte myNumber = 100; //8 bits of memory will be occupied
            short myNumber1 = 100; //16 bits of memory will be occupied
            int myNumber2 = 100;  //32 bits of memory will be occupied
            long myNumber3 = 100L; //64 bits of memory will be occupied


            //0 to 100 
            //1000 students
            // byte or sbyte --> 1000*8 bits = 8000 bits of memory will be occupied
            // int --> 1000*32 bits = 32000 bits of memory will be occupied

            float myNumber4 = 1.1f;  //32 bits
            double myNumber5 = 1.123456789;  //64 bits

            decimal myNumber6 = 1.2m; 

            char letter= 'B'; //16 bits of memory
            bool myBoolean = false;


            //non-predefined datatypes 
            string myName = "Bala"; //4*16 bits 

            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.Length);
            Console.WriteLine(myName[1]);

            Console.WriteLine(myNumber);
            Console.WriteLine(myNumber1);
            Console.WriteLine(myNumber2);
            Console.WriteLine(myNumber3);

            Console.WriteLine(myNumber4);
            Console.WriteLine(myNumber5);


            //10, 20, 30, 40, 50
            int[] numbers = new int[5];  //5*32 bits 

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine(numbers.GetHashCode());
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[4]);

            double[] arr1 = new double[3]; //3*64 bits 
            arr1[0] = 4.5;
            arr1[1] = 4;

            bool[] arr2 = new bool[3]; //3* 4 bits 

            //create an array to store red, green, yellow 
            string[] colors=new string[3]; 

            colors[0] = "red";
            colors[1] = "green";
            colors[2] = "yellow";


            // 14 * 16 bits of memory
            Console.WriteLine(colors);
            Console.WriteLine(colors.Length);
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);

            string[] arr3 = { "red", "yellow", "green" };
            Console.WriteLine(arr3[0]);
            Console.WriteLine(arr3[1]);
            Console.WriteLine(arr3[2]);

            int radius = 10;

            double result = 3.14 * radius * radius;
            Console.WriteLine(result);



            Console.WriteLine(1 == 2);
           // string myName = "Bala";
            int num = 9;

            if(num<0)
            {
                Console.WriteLine("negative");
            }
            else if(num==0)
            {
                Console.WriteLine("It's zero");
            }
            else
            {
                Console.WriteLine("positive");
            }

            string myValue = "E1 jack";

            Console.WriteLine(myValue.Length);

            //total character should have atleast 4 & contains E1 

            if(myValue.Length>=4 && myValue.StartsWith("E1"))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Not ok");
            }

        }
    }
}
