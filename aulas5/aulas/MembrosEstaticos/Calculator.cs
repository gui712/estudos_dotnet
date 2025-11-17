namespace MembrosEstaticos
{
    public class Calculator
    {
        public static double PI = 3.14;

        public static double Circunference(double r)
        {
            return 2.0 * Math.PI * r;
        }

        public static double Volume(double r)
        {
            return (4.0 / 3.0) * Math.PI * r * r * r;
        }
        
    }
}