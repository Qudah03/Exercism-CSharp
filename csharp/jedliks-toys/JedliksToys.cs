class RemoteControlCar
{
    private int _distanceDriven;
    private int _batteryPercentage;

    // Constructor: Runs EVERY time 'new RemoteControlCar()' is called
    public RemoteControlCar()
    {
        _batteryPercentage = 100;
        _distanceDriven = 0;
    }

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        // Handle the specific "empty" case
        if (_batteryPercentage == 0)
        {
            return "Battery empty";
        }
        return $"Battery at {_batteryPercentage}%";
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distanceDriven += 20;
            _batteryPercentage -= 1;
        }
    }
}