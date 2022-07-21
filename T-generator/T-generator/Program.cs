using System;

namespace lightman210567.TGenerator
{
    public class Generator
    {
        public static int TGenerate(int TNumber) // requires a int value returned
        {
            // The if statements check if the input number is in a 9x9 grid. 9x9 grids contain numbers 1-90
            if (TNumber < 1) // if T is less than 1 then throw an exception
            {
                throw new ArgumentException($"Input number must be 1 or larger");
            } 
            else if (TNumber > 90) // if T is more than 90 throw an exception
            {
                throw new ArgumentException("Input number must be less than or equal to 90");
            }

            int n = TNumber; // sets the value n to the value of T. n is used for the term to term rule of T-totals

            int TTotal = (5 * n) - 63; // multiplies n by 5 then subtracts 63 to get the T-total

            return TTotal; // returns the result
        }
    }
}
