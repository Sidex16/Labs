namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ф = 4.215f;
            double a = 286.35f;
            double C = 6.28f;
            double dk = 8.351f;
            double b = -12.6f;
            double x;
            //double c;

            do
            {
                Console.Write("Enter the x variable: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            
            //do
            //{
            //    Console.Write("Enter the c variable: ");
            //} while (!double.TryParse(Console.ReadLine(), out c));

            Console.WriteLine("R = " + R(x, b, ф));

            Console.WriteLine("s1 = " + s1(a, R(x, b, ф)));

            Console.WriteLine("b = " + B(a, s1(a, R(x, b, ф)), C, x, R(x, b, ф), dk));

            Console.ReadLine();

        }
        static double R(double x, double b, double ф)
        {
            return x * b + ф;
        }

        static double s1(double a, double R)
        {
            return Math.Sqrt(a + R);
        }

        static double B(double a, double s1, double C, double x, double R, double dk)
        {
            return (a + Math.Sqrt(Math.Pow(s1, 2) + 2 * Math.Pow(C, x))) / (R + dk * Math.Pow(Math.Sin(C), 2));
        }

    }
}