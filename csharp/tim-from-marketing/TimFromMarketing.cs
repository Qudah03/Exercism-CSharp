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
