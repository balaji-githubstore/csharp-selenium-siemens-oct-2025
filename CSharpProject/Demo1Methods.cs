
using Siemens.Math.Formulae;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject2
{
    public class Demo1Methods
    {
        static void Main1(string[] args)
        {

            //create object -- it allocates memory for all non-static methods, variable, properties
            Area obj = new Area();

            double result = obj.AreaOfCircle(10);
            Console.WriteLine(result);

            Console.WriteLine(obj.AreaOfCircle(20));

            result = Area.AreaOfRectangle(10, 10.2);
            Console.WriteLine(result);

            double output = Area.AreaOfTriangle(25, 1);
            Console.WriteLine(output);

            string myName= obj.GetAuthorName();
            Console.WriteLine(myName);
        }
    }
}
