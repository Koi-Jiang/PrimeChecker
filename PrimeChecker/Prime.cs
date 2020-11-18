using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeChecker
{
    public static class Prime
    {
        public static bool Check(int num)
        {
            //if (num <= 1)
            //    return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
