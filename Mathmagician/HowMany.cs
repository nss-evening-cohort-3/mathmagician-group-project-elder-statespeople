using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class HowMany
    {
        public int GetNumber()
        {
            bool x = true;
            int n = 0;

            while (x)
            {
                Console.WriteLine("How many should I print?");
                string numTimesString = Console.ReadLine();
                if (int.TryParse(numTimesString, out n))
                {
                    x = false;
                }
            }
            return n;
        }
    }
}
