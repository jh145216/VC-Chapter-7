using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz_Woof
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 1 : Print number from 1 to 100
            for (int j = 1; j <= 100; j++)
            {
                string results = "";
                // Step 2 :- Divisible by 3 print Fizz
                if (j % 3 == 0) results = "Fizz ";
                // Step 3 :- Divisible by 5 print Buzz
                if (j % 5 == 0) results = results + "Buzz";
                // Step 4 :- Divisible by 3 and 5 print FizzBuzz

                // Step 5 :- Print the number as it is if not divisible ny 3 or 5
                if (results.Length == 0) results = j.ToString();

                Console.WriteLine(results);

            }
        }
    }
}
