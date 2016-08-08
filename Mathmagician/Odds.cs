using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odds : Numbs
    {
        public int[] GenerateOdds(int count)
        {
            // Array holding Odd numbers
            int[] c = new int[count];
            // y is the Number to compare
            // x is current number in Array of Odds
            int y = 1, x = 0;

            // while loop controls number of Array Items
            while (x < count)
            {
                if ((y % 2) != 0)
                {
                    c[x] = y;
                    x++;
                }
                y++;             
            }

            return c;
        }
    }
}
