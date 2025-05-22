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
            int number = 0;
            bool success = false;

            while (!success)
            {
                Console.WriteLine("Type a number to know if it's a prime number");
                success = Int32.TryParse(Console.ReadLine(), out number);

                if (success) continue;
                Console.WriteLine("Please type a number");
            }

            int sqrt = (int) Math.Ceiling(Math.Sqrt(number));
            int divisible = -1;

            for (int i = 2; i < sqrt; i++)
            {
                int reste = number % i;
                if (reste == 0) {
                    divisible = i;
                    break; 
                }
            }

            if (divisible == -1)
            {
                Console.WriteLine($"{number} is a prime number");
                return;
            }

            Console.WriteLine($"{number} is not a prime number and can be divised by {divisible}");
        }
    }
}
