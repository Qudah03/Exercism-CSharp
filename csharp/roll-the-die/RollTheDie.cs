using System;

public class Player
{
    private Random _random = new Random();

    public int RollDie()
    {
        return _random.Next(1, 19); // Returns a random integer between 1 and 18
    }

    public double GenerateSpellStrength()
    {
        return _random.NextDouble() * 100.0; // Returns a random double between 0 and 100
    }
}
