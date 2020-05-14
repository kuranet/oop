using System;

namespace ClassLib
{
    public class MyMath
    {
        public delegate double Operation(double value1, double value2);
        

        public double DoMath(double x, double y, Operation op)
        {
            double res = 0;
            if (op != null)
                res = op(x, y);
            return res;            
        }

        static public double Add(double x, double y) => x + y;
        static public double Subtract(double x, double y) => x - y;
        static public double Multiply(double x, double y) => x * y;

        static public double Divide(double x, double y) 
        {
            if (y == 0)
                throw new DivideByZeroException("Division by zero");
            return x / y;
        }
        public double MathAdd(double x, double y) => x + y;
    }
}
