using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
   public class Integer : Numbs
    {
       
       private List<int> IntegerList = new List<int>();

        public List<int> GenerateInteger(int numInt)
        {
            for(int i = 0; i < numInt; i++)
            {
                IntegerList.Add(i);
               // Console.WriteLine(i);
            }
            return IntegerList;
        }     
        
    }
}
