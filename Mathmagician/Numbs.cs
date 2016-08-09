using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Numbs
    {
        public int GetNumber(string num)
        {
            
            int n = 0;
            if (int.TryParse(num, out n))
            {
                return n;
            } else
            {
                return -1;
            }

        }

        public string PrintOut(int[] Nums)
        {
            string output = "";
            foreach (int n in Nums)
            {
                output += " " + n + " ";
            }
            return output;
        }
    }
}
