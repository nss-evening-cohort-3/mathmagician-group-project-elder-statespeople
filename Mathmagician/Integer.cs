using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
   public class Integer
    {
       // public int IntegerValue {get; set;}

       public List<int> IntegerList = new List<int>();

        public void GenerateInteger(int numInt)
        {
            for(int i = 0; i < numInt; i++)
            {
                IntegerList.Add(i);
                Console.WriteLine(i);
            }
        }
        
        
    }
}
