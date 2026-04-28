public class SpaceAge
{
    private readonly double _seconds;
    private const double SecondsPerEarthYear = 31_557_600.0;
    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        // Divide total seconds by the seconds in an Earth year
        return _seconds / SecondsPerEarthYear;
    }

    public double OnMercury()
    {
        // Divide by (Earth Year Seconds * Mercury's Ratio)
        return _seconds / (SecondsPerEarthYear * 0.2408467);
    }

    public double OnVenus()
    {
        return _seconds / (SecondsPerEarthYear * 0.61519726);
    }

    public double OnMars()
    {
        return _seconds / (SecondsPerEarthYear * 1.8808158);
    }

    public double OnJupiter()
    {
        return _seconds / (SecondsPerEarthYear * 11.862615);
    }

    public double OnSaturn()
    {
        return _seconds / (SecondsPerEarthYear * 29.447498);
    }

    public double OnUranus()
    {
        return _seconds / (SecondsPerEarthYear * 84.016846);
    }

    public double OnNeptune()
    {
        return _seconds / (SecondsPerEarthYear * 164.79132);
    }
}