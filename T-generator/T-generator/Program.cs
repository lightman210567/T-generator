using System;

namespace lightman210567.TGenerator
{
    public class Generator
    {
        public static int TGenerate(int T) // requires a int value returned
        {
            if (T < 1)
            {
                throw new ArgumentException($"Input number must be 1 or larger");
            } 
            else if (T > 90)
            {
                throw new ArgumentException("Input number must be less than or equal to 90");
            }

            int n = T; // sets the value n to the value of T. n is used for the term to term rule of T-totals

            int TTotal = (5 * n) - 63; // multiplies n by 5 then subtracts 63 to get the T-total

            return TTotal; // returns the result
        }
    }
}
