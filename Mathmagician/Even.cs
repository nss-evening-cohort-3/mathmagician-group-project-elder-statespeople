using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
   public class Even : Numbs
    {
        private List<int> EvenList = new List<int>();

        public List<int> GenerateEven(int numEven)
        {
            var j = 0;
            for (int i = 0; i < numEven; i++)
            {           
                EvenList.Add(j);
                j = j + 2;   
            }
            return EvenList;
        }

    }
}
