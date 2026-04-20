static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        // 1. Determine the Department text first
        string deptName = (department == null) ? "OWNER" : department.ToUpper();

        // 2. Decide if we need the [ID] prefix or not
        if (id == null)
        {
            return $"{name} - {deptName}";
        }
        else
        {
            return $"[{id}] - {name} - {deptName}";
        }
    }
}

/*
public static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        // If ID is null, use empty string. Otherwise, format it with brackets and dash.
        string idPart = id == null ? "" : $"[{id}] - ";
        
        // If department is null, use "OWNER". Otherwise, make it uppercase.
        string deptPart = (department ?? "OWNER").ToUpper();

        return $"{idPart}{name} - {deptPart}";
    }
}
*/