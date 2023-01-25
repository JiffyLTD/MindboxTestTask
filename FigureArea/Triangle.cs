namespace Figures
{
    public class Triangle
    {
        public static double Area(int a, int b, int c)
        {
            double p = (double)(a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return s;
        }

        public static double Area(double a, double b, double c)
        {
            double p = (double)(a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return s;
        }

        public static bool IsItRectangular(int a, int b, int c)
        {
            return ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a));
        }

        public static bool IsItRectangular(double a, double b, double c)
        {
            return ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a));
        }
    }
}
