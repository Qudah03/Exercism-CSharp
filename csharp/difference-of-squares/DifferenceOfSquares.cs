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

/*
using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        // Formula for sum of 1 to n: (n * (n + 1)) / 2
        int sum = (max * (max + 1)) / 2;
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        // Formula for sum of squares: (n * (n + 1) * (2n + 1)) / 6
        return (max * (max + 1) * (2 * max + 1)) / 6;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
*/