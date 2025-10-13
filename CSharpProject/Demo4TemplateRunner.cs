using Siemens.Math.Formulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Demo4TemplateRunner
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("check");

            double res= Area.AreaOfRectangle(4, 4);
            Console.WriteLine(res);
        }

    }
}
