using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
   public class Even
    {
       // public int EvenValue {get; set;}

        public List<int> EvenList = new List<int>();

        public void GenerateEven(int numEven)
        {
            // Console.Write("{0} ", c);
            var j = 0;
            for (int i = 0; i < numEven; i++)
            {           
                EvenList.Add(j);
                Console.Write(" " + j + " ");
                j = j + 2;   
            }
            Console.WriteLine();
        }

        /*public void CheckIfEven(int my_even)
        {
            if (my_even % 2 == 0)
            {
                this.EvenValue = my_even;
               
            } else
            {
                throw new ArgumentException();
            }
        }*/
    }
}
