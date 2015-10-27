using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        public PrimeNumbers()
        {
            first = 2;
        }

        public override int GetNext(int x)
        {
            int nextNum = x + 1;
            while (true)
            {
                if (GetPrime(nextNum))
                {
                    return nextNum;
                }
                else
                {
                    nextNum++;
                }
            }
        }

        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public static bool GetPrime(int x)
        {
            if (x % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < x / 2 + 1; i += 2)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
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
