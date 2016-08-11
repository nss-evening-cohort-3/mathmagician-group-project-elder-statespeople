using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci : Numbs
    {
        private List<int> FibonacciList = new List<int>() {0,1 };

        public List<int> GenerateFibonacci(int numFib)

        {
            int a = 0, b = 1, c = 0;
           
            for (int i = 2; i < numFib; i++)
            {
                c = a + b;
                FibonacciList.Add(c);
                a = b;
                b = c;
                
            }
            return FibonacciList;
          
        }
    }
}
