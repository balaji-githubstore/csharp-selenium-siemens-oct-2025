using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Demo6Logics
    {
        static void Main(string[] args)
        {
            int[] numbers = { 99, 24, 23, 44, 55, 3434, 545, 4545 };



            for(int i=0;i<numbers.Length; i++)
            {
                
                Console.WriteLine(numbers[i]);
            }

            foreach(int value in numbers)
            {
                if(value==55)
                {
                    Console.WriteLine("yes it's present"+value);
                    break;
                }
            }


            List<string> colors = new List<string>();

            colors.Add("red");
            colors.Add("blue");
            colors.Add("orange");

            Console.WriteLine(colors.Count);

            foreach(var val  in colors)
            {

            }

        }
    }
}
