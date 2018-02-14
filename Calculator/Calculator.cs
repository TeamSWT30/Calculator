using System;
using System.Data;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;

        public Calculator()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Power(double a, double b)
        {
            if (a < 0 && b != Convert.ToInt32(b))
            {
                Accumulator = 0;
                throw new InvalidOperationException("Number is complex");
            }
            else
            {
                return Accumulator = Math.Pow(a, b);
            }
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                Accumulator = 0;
                throw  new DivideByZeroException();
            }
            else
            {
                return Accumulator = dividend / divisor;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double addend)
        {
            return Accumulator = Accumulator + addend;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator = Accumulator - subtractor;
        }

        public double Multiply(double multiplier)
        {
            return Accumulator = Accumulator * multiplier;
        }

        public double Power(double exp)
        {
            if (Accumulator < 0 && exp != Convert.ToInt32(exp))
            {
                Accumulator = 0;
                throw new InvalidOperationException();
            }
            else
            {
                return Accumulator = Math.Pow(Accumulator, exp);
            }
        }

        public double Divide(double divisor)
        {
            if (divisor != 0)
            {
                return Accumulator = Accumulator / divisor;
            }
            else
            {
                Accumulator = 0;
                throw new DivideByZeroException();
            }
        }

    }
}
