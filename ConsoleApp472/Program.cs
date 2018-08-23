using System;

namespace ConsoleApp472
{
    public class Program
    {
        static void Main()
        {
            for (int i = 0; i < 60; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"int.MaxValue is{Negate(IsPrime(int.MaxValue))} a prime: {int.MaxValue}");
            Console.WriteLine($"long.MaxValue is{Negate(IsPrime(long.MaxValue))} a prime: {long.MaxValue}");
            Console.WriteLine($"Ulong.MaxValue is{Negate(IsPrime(ulong.MaxValue))} a prime: {ulong.MaxValue}");

            Console.WriteLine("press a key to exit:");
            Console.ReadKey();
        }
        
        private static string Negate(bool trueOrFalse) => trueOrFalse ? string.Empty : " not";

        public static bool IsPrime(int number)
        {
            // process false numbers first
            if (number < 2) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0) return false;
            if (number % 5 == 0) return false;
            for (int i = 3; i <= Math.Abs(Math.Sqrt(number)); i = i + 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static bool IsPrime(long number)
        {
            // process false numbers first
            if (number < 2) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0) return false;
            if (number % 5 == 0) return false;
            for (long i = 3; i <= Math.Abs(Math.Sqrt(number)); i = i + 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static bool IsPrime(ulong number)
        {
            // process false numbers first
            if (number < 2) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0) return false;
            if (number % 5 == 0) return false;
            for (ulong i = 3; i <= Math.Abs(Math.Sqrt(number)); i = i + 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}