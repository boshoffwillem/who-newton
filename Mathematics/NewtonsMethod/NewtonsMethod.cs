using System;

namespace NewtonsMethod
{
    /// <summary>
    /// Newton's method finds the square root of a given value.
    /// </summary>
    public static class NewtonsMethod
    {
        public static double SquareRoot(double value, double errorMargin = 1e-15)
        {
            double squareRoot = value;
            while(Math.Abs(squareRoot - value / squareRoot) > errorMargin * squareRoot)
            {
                squareRoot = (value / squareRoot + squareRoot) / 2.0;
            }
            return squareRoot;
        }
    }
}
