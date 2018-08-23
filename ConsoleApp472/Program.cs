using System;

namespace ConsoleApp472
{
   public class Program
    {
        static void Main()
        {
            for (int  i = 0;  i < 60 ;  i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            if (IsPrime(int.MaxValue))
            {
                Console.WriteLine($"int.MaxValue is prime: {int.MaxValue}");
            }

            Console.WriteLine("press a key to exit:");
            Console.ReadKey();
        }

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
    }
}