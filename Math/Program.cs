using System;

namespace Math;

class Operation
{
    public static double Add(double x, double y)
    { return x + y; }
    public static int Subtract(int x, int y)
    { return x - y; }

    public static int Multiply(int x, int y)
    { return x * y; }

    public static double Divide(int x, int y)
    { return (double)x / y; }
}