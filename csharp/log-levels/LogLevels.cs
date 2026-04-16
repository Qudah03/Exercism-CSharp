static class LogLine
{
    public static string Message(string logLine)
    {
        // Find where the colon is, then take everything after it
        return logLine.Substring(logLine.IndexOf(":") + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[") + 1;
        int end = logLine.IndexOf("]");
        int length = end - start;

        return logLine.Substring(start, length).ToLower();
    }

    public static string Reformat(string logLine)
    {
        // Combine the cleaned message and the cleaned log level
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
