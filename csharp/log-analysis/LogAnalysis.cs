public static class LogAnalysis 
{
    // The 'this string str' is the magic part—it tells C# to add this 
    // to every string in your project.
    public static string SubstringAfter(this string str, string delimiter)
    {
        // 1. Find the position where the delimiter starts
        int index = str.IndexOf(delimiter);
        
        // 2. We don't want the delimiter itself, so we add its length 
        //    to move the starting point to the end of the delimiter.
        int start = index + delimiter.Length;
        
        // 3. Return everything from that point to the end
        return str.Substring(start);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string SubstringBetween(this string str, string sub1, string sub2)
    {
        // 1. Find the start (skipping the first delimiter)
        int start = str.IndexOf(sub1) + sub1.Length;
        
        // 2. Find the end (where the second delimiter starts)
        int end = str.IndexOf(sub2);
        
        // 3. Subtract start from end to get the length of the word in the middle
        return str.Substring(start, end - start);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}