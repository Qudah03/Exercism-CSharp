using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public static class SquareRoot
{
    public static int Root(int number)
    {
        if (number == 0)
        {
            return 0;
        }

        int left = 1;
        int right = number;
        
        while (left <= right)
        {
            int mid = (left + right) / 2; // atuomatic floor in C# while using integers
            int square = mid * mid;

            if (square == number)
            {
                return mid;
            }
            else if (square < number)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return right;
    }
}
