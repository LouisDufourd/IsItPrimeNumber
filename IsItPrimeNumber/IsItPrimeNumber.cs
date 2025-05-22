using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItPrimeNumber
{
    class IsItPrimeNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = 0;
                bool success = false;
                int divisable = 0;
                bool isPrime;

                while (!success)
                {
                    Console.WriteLine("Type a number to know if it's a prime number (Press Q to leave the close the program).");
                    String input = Console.ReadLine();

                    if (String.Equals(input, "q", StringComparison.InvariantCultureIgnoreCase) || input == null) return;

                    success = Int32.TryParse(input, out number);

                    if (success) continue;
                    Console.WriteLine("Please type a number");
                }

                if (number < 0) number *= -1;

                isPrime = isPrimeNumber(number, out divisable);

                if (isPrime)
                {
                    Console.WriteLine($"{number} is a prime number!");
                } else
                {
                    Console.WriteLine($"{number} is not a prime number and can be divised by {divisable}!");
                }
            }
        }

        public static bool isPrimeNumber(int number, out int divisable)
        {
            divisable = -1;

            int sqrt = (int)Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i < sqrt; i++)
            {
                int reste = number % i;
                if (reste == 0)
                {
                    divisable = i;
                    break;
                }
            }

            return divisable == -1;
        }
    }
}
