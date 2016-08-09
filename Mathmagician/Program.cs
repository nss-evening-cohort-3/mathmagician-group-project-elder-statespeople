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
                    case "Integers":
                        HowMany hmInt = new HowMany();
                        Integer i = new Integer();
                        int numberOfInts = hmInt.GetNumber();
                        i.GenerateIntegers(numberOfInts);
                        //string outputInts = i.PrintIntegers(ints);
                        //Console.WriteLine("The " + numberOfInts + " Integers are: " + outputInts);
                        loopCount = false;
                        break;
                    case "Primes":
                        Console.WriteLine("How many should I print?");
                        string numTimesStringPrimes = Console.ReadLine();
                        Primes p = new Primes();
                        int numberOfPrimes = p.GetNumber(numTimesStringPrimes);
                        if (numberOfPrimes > 0)
                        {
                            int[] primes = p.GeneratePrimes(numberOfPrimes);
                            string outputPrimes = p.PrintOut(primes);
                            Console.WriteLine("The " + numberOfPrimes + " Prime Numbers are: " + outputPrimes);
                            loopCount = false;
                        }
                        else
                            goto default;
                        break;
                    case "Fibonacci":
                        HowMany hmFibs = new HowMany();
                        Fibonacci f = new Fibonacci();
                        int numberOfFibs = hmFibs.GetNumber();
                        f.GenerateFibs(numberOfFibs);
                        //string outputFibs =f.PrintFibs(fibs);
                        //Console.WriteLine("The " + numberOfFibs + " Fibonacci Numbers are: " + outputFibs);
                        loopCount = false;
                        break;
                    case "Even":
                        HowMany hmEvens = new HowMany();
                        Even e = new Even();
                        int numberOfEvens = hmEvens.GetNumber();
                        e.GenerateEvens(numberOfEvens);
                        //string outputEvens = e.PrintEvens(evens);
                        //Console.WriteLine("The " + numberOfEvens + " Even Numbers are: " + outputEvens);
                        loopCount = false;
                        break;
                    case "Odd": 
                        Odds o = new Odds();
                        Console.WriteLine("How many should I print?");
                        string numTimesStringOdds = Console.ReadLine();
                        int numberOfOdds = o.GetNumber(numTimesStringOdds);
                        if (numberOfOdds > 0)
                        {
                            int[] odds = o.GenerateOdds(numberOfOdds);
                            string outputOdds = o.PrintOut(odds);
                            Console.WriteLine("The " + numberOfOdds + " Odd Numbers are: " + outputOdds);
                            loopCount = false;
                        }
                        else
                            goto default;
                        break; 
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
