using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.Math.Formulae
{
    public class Volume
    {
        public static double VolumeOfSphere(double radius)
        {
            
            return (4.0 / 3.0) * 3.14 * radius * radius * radius;
        }
    }
}
