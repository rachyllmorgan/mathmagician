using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibonacciNumbers : NaturalNumbers
    {
        public FibonacciNumbers()
        {
            first = 0;
        }

        public int GetNext(int x)
        {
            int next = x + increment;
            increment = x;
            return next;
        }

        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                //give me the last thing on the list = output.Last()
                // give me the next number on the next sequence = GetNext(output.Last())
                // adds the output into the list = output.Add(GetNext(output.Last()));
                output.Add(GetNext(output.Last()));
            }

            return output.ToArray();
        }
    }
}
