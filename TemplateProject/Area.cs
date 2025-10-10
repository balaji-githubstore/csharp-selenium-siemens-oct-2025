namespace Siemens.Math.Formulae
{
    public class Area
    {
        public static double AreaOfCircle(double radius)
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
    }
}
