using System.Reflection;

namespace hwLesson12
{
    class Calculator
    {        
        public event EventHandler dividedByZero = null;

        public double Mul(double a, double b) =>
                a * b;

        public double Div( double a, double b)
        {
            if (b == 0)
            {
                dividedByZero.Invoke(null, new EventArgs());
                return 0;
            }
            else
                return a / b;
        }

        public double Add(double a, double b) =>
            a + b;

        public double Sub(double a, double b) =>
            a - b;
    }
}
