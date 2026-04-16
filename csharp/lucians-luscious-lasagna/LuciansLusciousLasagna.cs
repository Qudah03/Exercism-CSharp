class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remainingTime)
    {
        int timeLeft = 40 - remainingTime;
        return timeLeft;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int totalTimeForLayers = 2*layers;
        return totalTimeForLayers;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers,int timeInOven)
    {
        // Total worked = Prep time + time already in oven
        return PreparationTimeInMinutes(layers) + timeInOven;
    }
}
