namespace Figures
{
    public class Circle
    {
        public double R;

        public Circle(){}

        public Circle(double r)
        {
            R = r;
        }

        public double Area()
        {
            double s = Math.PI * R;

            return s;
        }
    }
}