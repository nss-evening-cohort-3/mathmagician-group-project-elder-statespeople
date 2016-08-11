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
                        Console.WriteLine("How many should I print?");
                        string numInteger = Console.ReadLine();
                        Integer i = new Integer();
                        int numberOfInts = i.GetNumber(numInteger);
                        // i.GenerateInteger(numberOfInts);
                        
                        if (numberOfInts > 0)
                        {
                            List<int> IntList = i.GenerateInteger(numberOfInts);
                            string outputInts = i.PrintList(IntList);
                            Console.WriteLine("The " + numberOfInts + " Integers are: " + outputInts);
                            loopCount = false;
                        }else
                            goto default;
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
                        Console.WriteLine("How many should I print?");
                        string numFib = Console.ReadLine();
                        Fibonacci f = new Fibonacci();
                        int numOfFib = f.GetNumber(numFib);
                        //f.GenerateFibs(numberOfFibs); 
                        if (numOfFib > 0)
                        {
                            List<int> fibList = f.GenerateFibonacci(numOfFib);
                            string outputFibs =f.PrintList(fibList);
                            Console.WriteLine("The " + numOfFib + " Fibonacci Numbers are: " + outputFibs);
                            loopCount = false;
                        }
                        else
                            goto default;
                        break;
                    case "Even":
                        Console.WriteLine("How many should I print?");
                        string numEven = Console.ReadLine();
                        Even e = new Even();
                        int numberOfEvens = e.GetNumber(numEven);                 
                        if (numberOfEvens > 0)
                        {
                            List<int> evenList = e.GenerateEven(numberOfEvens);
                            string outputEvens = e.PrintList(evenList);
                            Console.WriteLine("The " + numberOfEvens + " Even Numbers are: " + outputEvens);
                            loopCount = false;
                        }
                        else
                            goto default;
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
