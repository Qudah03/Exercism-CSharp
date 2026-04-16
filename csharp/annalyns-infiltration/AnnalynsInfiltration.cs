static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        return (knightIsAwake || archerIsAwake || prisonerIsAwake);
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        return (prisonerIsAwake && !archerIsAwake);
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // Scenario 1: Dog is here and archer is asleep
        bool dogOption = petDogIsPresent && !archerIsAwake;

        // Scenario 2: No dog, prisoner is awake, knight is asleep, archer is asleep
        bool sneakyOption = !petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake;

        return dogOption || sneakyOption;
    }
}
