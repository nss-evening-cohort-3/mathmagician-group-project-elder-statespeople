using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {

        static void Main(string[] args)
        {
            bool loopCount = true;

            while (loopCount)
            {
                Console.WriteLine("What would you like for me to do?");
                string command = Console.ReadLine();
                
                switch (command)
                {
                 /*   case "Integers":
                        HowMany hmInt = new HowMany();
                        Integers i = new Integers();
                        int numberOfInts = hmInt.GetNumber();
                        int[] ints = i.GenerateIntegers(numberOfInts);
                        string outputInts = i.PrintIntegers(ints);
                        Console.WriteLine("The " + numberOfInts + " Integers are: " + outputInts);
                        loopCount = false;
                        break; */
                    case "Primes":
                        HowMany hmPrimes = new HowMany();
                        Primes p = new Primes();
                        int numberOfPrimes = hmPrimes.GetNumber();
                        int[] primes = p.GeneratePrimes(numberOfPrimes);
                        string outputPrimes = p.PrintPrimes(primes);
                        Console.WriteLine("The " + numberOfPrimes + " Prime Numbers are: "  + outputPrimes);
                        loopCount = false;
                        break;
                   /* case "Fibonacci":
                        HowMany hmFibs = new HowMany();
                        Fibonacci f = new Fibonacci();
                        int numberOfFibs = hmFibs.GetNumber();
                        int[] fibs = f.GenerateFibs(numberOfFibs);
                        string outputFibs =f.PrintFibs(fibs);
                        Console.WriteLine("The " + numberOfFibs + " Fibonacci Numbers are: " + outputFibs);
                        loopCount = false;
                        break;
                    case "Even":
                        HowMany hmEvens = new HowMany();
                        Evens e = new Evens();
                        int numberOfEvens = hmEvens.GetNumber();
                        int[] evens = e.GenerateEvens(numberOfEvens);
                        string outputEvens = e.PrintEvens(evens);
                        Console.WriteLine("The " + numberOfEvens + " Even Numbers are: " + outputEvens);
                        loopCount = false;
                        break;
                    case "Odd":
                        HowMany hmOdds = new HowMany();
                        Odds o = new Odds();
                        int numberOfOdds = hmOdds.GetNumber();
                        int[] odds = o.GenerateOdds(numberOfOdds);
                        string outputOdds = o.PrintOdds(odds);
                        Console.WriteLine("The " + numberOfOdds + " Prime Numbers are: " + outputOdds);
                        loopCount = false;
                        break; */
                    default:
                        Console.WriteLine("Whoops!");
                        break;
                }
             
            }
            Console.WriteLine("Hit Enter key to finish");
            Console.Read();
        }
    }
}
