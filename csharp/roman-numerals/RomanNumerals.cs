using System;
using System.Text;
public static class RomanNumeralExtension
{
    // Arrays ordered from largest to smallest value
    private static readonly int[] Values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    private static readonly string[] Symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    public static string ToRoman(this int value)
    {
        var roman = new StringBuilder();
        int remaining = value;

        // Loop through the values from 1000 down to 1
        for (int i = 0; i < Values.Length; i++)
        {
            // While the current value fits into our remaining number
            while (remaining >= Values[i])
            {
                roman.Append(Symbols[i]); // Add the symbol (e.g., "M" or "IV")
                remaining -= Values[i];   // Subtract the value
            }
        }

        return roman.ToString();

    }
}