using System.Runtime.CompilerServices;

public static class Triangle
{
    private static bool IsValid(double a, double b, double c)
    {
        // All sides must be positive
        if (a <= 0 || b <= 0 || c <= 0) return false;
        
        // Triangle inequality
        return (a + b >= c) && (a + c >= b) && (b + c >= a);
    }
    public static bool IsScalene(double side1, double side2, double side3)
    {
        // 1. Validation check - return false, don't throw
        if (!IsValid(side1, side2, side3)) return false;

        // 2. Scalene logic
        return side1 != side2 && side2 != side3 && side1 != side3;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (!IsValid(side1, side2, side3)) return false;
        
        return side1 == side2 || side2 == side3 || side1 == side3;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (!IsValid(side1, side2, side3)) return false;

        return side1 == side2 && side2 == side3;
}
}