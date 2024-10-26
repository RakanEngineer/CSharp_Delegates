using System;
using static System.Console;

namespace CSharp_Delegates
{
    class Program
    {
        //delegate int performCalculation(int x, int y);
        delegate void PerformAction();

        static void Main(string[] args)
        {
            //performCalculation operation = new performCalculation(Addition);
            //operation += Multiplication;
            //int result = operation(1, 2);
            //operation -= Multiplication;
            //result = operation(1, 2);
            //Console.WriteLine(result);
            bool shouldNotExit = true;
            while (shouldNotExit)
            {
                WriteLine("1. Silver package");
                WriteLine("2. Gold package");
                WriteLine("3. Platina package");

                ConsoleKeyInfo keyPressed = ReadKey(true);
                PerformAction clean = new PerformAction(Wash);
                clean += Dry;
                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //1. tvätas
                        //2. torkes
                        //Wash();
                        //Dry();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //1. tvätas
                        //2. torkes
                        //3. vaxning   
                        //Wash();
                        //Dry();
                        //ApplyWax();
                        clean += ApplyWax;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //1. tvätas
                        //2. torkes
                        //3. vaxning
                        //4. städning
                        //Wash();
                        //Dry();
                        //ApplyWax();
                        //CleanInside();
                        clean += ApplyWax;
                        clean += CleanInside;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        shouldNotExit = false;
                        break;
                }
                //clean();
                StartProgram(clean);
                ReadKey(true);
                Clear();
            }
        }

        static void StartProgram(PerformAction actions)
        {
            Console.WriteLine("Starting program...");

            actions();

            Console.WriteLine("Program Done");

        }
        //static int Addition(int x, int y)
        //{
        //    Console.WriteLine("Performing addition...");
        //    return x + y;
        //}
        //static int Multiplication(int x, int y)
        //{
        //    Console.WriteLine("Performing multiplication...");
        //    return x * y;
        //}
        static void Wash()
        {
            WriteLine("Washing...");
        }
        static void Dry()
        {
            WriteLine("Drying...");
        }
        static void ApplyWax()
        {
            WriteLine("Applying wax...");
        }
        static void CleanInside()
        {
            WriteLine("Cleaning inside...");
        }
    }
}
