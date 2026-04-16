public static class LineUp
{
    public static string Format(string name, int number)
    {
        // Step 1: Find the last two digits and the last single digit
        int lastTwoDigits = number % 100;
        int lastDigit = number % 10;
        string suffix;

        // Step 2: Determine the suffix
        if (lastTwoDigits == 11 || lastTwoDigits == 12 || lastTwoDigits == 13)
        {
            suffix = "th";
        }
        else
        {
            suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
        }

        // Step 3: Return the formatted string
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";  
        }
}
