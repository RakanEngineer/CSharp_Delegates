using System;

namespace CSharp_Delegates
{
    class Program
    {
        delegate int performCalculation(int x, int y);

        static void Main(string[] args)
        {
            performCalculation operation = new performCalculation(Addition);

            int result = operation(2, 3);
            Console.WriteLine(result);
        }
        static int Addition(int x, int y)
        {
            return x+ y;
        }
    }
}
