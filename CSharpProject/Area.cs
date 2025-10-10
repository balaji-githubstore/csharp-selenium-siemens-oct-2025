using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.Math.Formulae
{
    public class Area
    {
        public double AreaOfCircle(double radius)
        {
            return 3.14 * radius * radius;
        }
        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }
        public static double AreaOfTriangle(double baseValue, double heightValue)
        {
            return (baseValue * heightValue) / 2;
        }
        public string GetAuthorName()
        {
            return "Balaji Dinakaran";
        }

        public void Quit()
        {

        }
      
    }
}
