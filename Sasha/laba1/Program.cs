namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double U1 = 120;
            const double U2 = 63.5f;
            const double b = 1.86f;
            const double R1 = 15;
            const double R3 = 4.8f;
            const double U3 = 45;
            double R2;

            do
            {   
                Console.Clear();
                Console.Write("Enter the R2 variable: ");
            } while (!double.TryParse(Console.ReadLine(), out R2));
            Console.WriteLine("U = " + U(U1, U2, b));
            Console.WriteLine("R = " + R(R1, R2));
            Console.WriteLine("i = " + i(R(R1, R2), R3, U(U1, U2, b), U2));
            Console.ReadLine();

        }

        static double U(double U1, double U2, double b)
        {
            return 1 / Math.Sqrt(b) * (U1 + U2);
        }

        static double R(double R1, double R2)
        {
            return (R1 * R2) / (R1 + R2);
        }

        static double i(double R, double R3, double U, double U2) 
        {
            return (U + U2) / (R + R3);
        }
    }
}