public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // Divisible by 4 AND (NOT divisible by 100 OR divisible by 400)
    return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
    }
}

/*
public static bool IsLeapYear(int year)
{
    // Rule 1: Every 400 years is ALWAYS a leap year
    if (year % 400 == 0) return true;

    // Rule 2: If it's a century but not the 400th, it's NOT a leap year
    if (year % 100 == 0) return false;

    // Rule 3: Otherwise, any year divisible by 4 is a leap year
    return year % 4 == 0;
}
---------------------------------------------------------------------------
public static bool IsLeapYear(int year)
{
    return (year % 4, year % 100, year % 400) switch
    {
        (_, 0, 0) => true,
        (_, 0, _) => false,
        (0, _, _) => true,
        _ => false,
    };
}
*/