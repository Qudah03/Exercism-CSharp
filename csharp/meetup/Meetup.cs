using System.Linq;
public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int _month;
    private readonly int _year;
    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

   public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
{
    // 1. Determine the start of the 7-day search window
    // Using a switch expression ensures we get a startDay or throw an error
    int startDay = schedule switch
    {
        Schedule.First  => 1,
        Schedule.Second => 8,
        Schedule.Third  => 15,
        Schedule.Fourth => 22,
        Schedule.Teenth => 13,
        Schedule.Last   => DateTime.DaysInMonth(_year, _month) - 6,
        _ => throw new ArgumentOutOfRangeException(nameof(schedule))
    };

    // 2. Iterate through the 7-day window
    for (int d = startDay; d < startDay + 7; d++)
    {
        var date = new DateTime(_year, _month, d);
        if (date.DayOfWeek == dayOfWeek)
        {
            return date;
        }
    }
    

    // 3. The Fallback (Satisfies the compiler)
    throw new Exception("This line should be unreachable, but the compiler needs it.");
}
}