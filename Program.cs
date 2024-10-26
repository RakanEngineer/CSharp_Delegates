using System;

namespace CSharp_Delegates
{
    class Program
    {
        delegate int performCalculation(int x, int y);

        static void Main(string[] args)
        {
            performCalculation operation = new performCalculation(Addition);

            operation += Multiplication;

            int result = operation(1, 2);

            operation -= Multiplication;

            result = operation(1, 2);

            Console.WriteLine(result);
        }
        static int Addition(int x, int y)
        {
            Console.WriteLine("Performing addition...");
            return x + y;
        }
        static int Multiplication(int x, int y)
        {
            Console.WriteLine("Performing multiplication...");
            return x * y;
        }
    }
}
