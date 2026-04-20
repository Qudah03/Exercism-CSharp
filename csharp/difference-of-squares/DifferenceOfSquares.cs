using System;
using System.Linq;
public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        // Enumerable.Range(1, max) creates the list: 1, 2, 3...
        int sum = Enumerable.Range(1, max).Sum();
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        return Enumerable.Range(1,max).Select(x => x * x).Sum();
       
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
       return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}