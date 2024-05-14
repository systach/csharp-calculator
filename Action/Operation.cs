using System;

namespace Action.Operation;

class Operation
{
    public static double Add(double x_1, double x_2) { return x_1 + x_2; }
    public static double Subtract(double x_1, double x_2) { return x_1 - x_2; }
    public static double Multiply(double x_1, double x_2) { return x_1 * x_2; }
    public static double Divide(double x_1, double x_2) { return (double)x_1 / x_2; }
}