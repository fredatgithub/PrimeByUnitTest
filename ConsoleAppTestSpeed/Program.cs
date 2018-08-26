using System;
using System.Diagnostics;

namespace ConsoleAppTestSpeed
{
    class Program
    {
        static void Main()
        {
            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            int iteration = 10;
            for (int i = 0; i < iteration; i++)
            {
                bool result = ConsoleApp472.Program.IsPrime(1000000000100011);
            }

            chrono.Stop();
            Console.WriteLine(chrono.ElapsedMilliseconds);

            chrono.Start();
            for (int i = 0; i < iteration; i++)
            {
                bool result = ConsoleApp472.Program.IsPrimeWithEgalSign(1000000000100011);
            }

            chrono.Stop();
            Console.WriteLine(chrono.ElapsedMilliseconds);
            Console.WriteLine("press any key to exit:");
            Console.ReadKey();
        }
    }
}