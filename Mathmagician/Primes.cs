using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Primes : Numbs
    {
        public int[] GeneratePrimes(int count)
        {
            int[] c = new int[count];

            Console.WriteLine("The number of Prime Numbers I will return is " + count);

            // Counter for # of successful Prime #s
            int loopCounter = 0;
            // Number being checked is Prime
            int numCheck = 1;
            // While haven't reached the number of desired Primes
            while (loopCounter < count)
            {
                // Increment the number being checked
                numCheck++;
                // If Number is Prime or not
                bool primeNum = true;
                
                // Starts at 2 and goes to 1 less than the number being checked
                for (int j = 2; j < numCheck; j++)
                {
                    // If number being checked is divisible by a number
                    if ((numCheck % j) == 0)
                    {
                        // Not a Prime number if divisible
                        primeNum = false;
                    }
                }
                // If Prime Number (including 2)
                if ((primeNum) || (numCheck == 2))
                {
                    c[loopCounter] = numCheck;
                    // Increment count of Prime Numbers
                    loopCounter++;
                }
            }
            return c;
        }
    }
}
