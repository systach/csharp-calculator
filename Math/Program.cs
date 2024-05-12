using System;

namespace Math;

class LinearFunction
{
    double slope;
    double intercept;

    public LinearFunction(double slope, double intercept)
    {
        this.slope = slope;
        this.intercept = intercept;
    }
    public double GetSlope() { return slope; }
    public double GetIntercept() { return intercept; }
    public void SetIntercept(double newIntercept) { intercept = newIntercept; }

    public void SetSlope(double newSlope) { slope = newSlope; }

    public double Evaluate(double value)
    {
        return (slope * value) + intercept;
    }
}

class Operation
{
    public static double Add(double x, double y)
    { return x + y; }
    public static double Subtract(double x, double y)
    { return x - y; }

    public static double Multiply(double x, double y)
    { return x * y; }

    public static double Divide(double x, double y)
    { return (double)x / y; }

    public static double GetHypothenuse(double x, double y)
    {
        double squared = Operation.Add(MathF.Pow((float)x, 2), MathF.Pow((float)y, 2));
        double sqaureRoot = MathF.Sqrt((float)squared);
        return sqaureRoot;
    }

    public static LinearFunction CreateLinearFunction(double slope, double intercept)
    {
        return new LinearFunction(slope, intercept);
    }
}