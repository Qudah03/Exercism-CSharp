public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
       string[] parts = phoneNumber.Split('-');
    
        // parts[0] is the Area Code (e.g., "212")
        // parts[1] is the Prefix (e.g., "555")
        // parts[2] is the Line Number (e.g., "1234")

        return (parts[0] == "212", parts[1] == "555", parts[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        // You just need to reach into the tuple and grab the IsFake boolean
        return phoneNumberInfo.IsFake;
    }
}
