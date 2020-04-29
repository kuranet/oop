using System;

namespace lab6
{
    class MathExpression
    {
        double a;
        double b;
        double c;
        double d;

        public MathExpression(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public double GetRes()
        {
            double sqrt = 24 + d - c;
            if (sqrt < 0)
                throw new ArithmeticException("Root Expression must be >= 0");
            if ( b == 0)
                throw new DivideByZeroException("Division by 0 by parameter b");
            double denomination = Math.Sqrt(sqrt) + a / b;
            if (denomination == 0)
                throw new DivideByZeroException("Denominator is 0");
            double result = (1 + a - b / 2) / denomination;
            return result;
        }
    }
}
