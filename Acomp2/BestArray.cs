using System;
using System.Collections.Generic;
using System.Linq;
namespace Acomp2
{
    public class BestArray
    {
        public int[] Array;
        public BestArray(int n)
        {
            Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = i;
            }
        }
    }
}
