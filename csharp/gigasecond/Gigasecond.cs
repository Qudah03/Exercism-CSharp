public static class Gigasecond
{
    private const double GigasecondValue = 1_000_000_000;

    public static DateTime Add(DateTime moment)
    {
        // Use the built-in AddSeconds method to handle the math
        return moment.AddSeconds(GigasecondValue);
    }
}