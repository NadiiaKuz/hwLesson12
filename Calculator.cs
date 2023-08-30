namespace hwLesson12
{
    class Calculator
    {        
        public event EventHandler dividedByZero = null;

        public void InvokeEvent(object sender, EventArgs e)
        {
            dividedByZero.Invoke(sender, e);
        }

        public static double Mul(double a, double b) =>
                a * b;

        public static double Div(double a, double b) =>
           a / b;

        public static double Add(double a, double b) =>
            a + b;

        public static double Sub(double a, double b) =>
            a - b;
    }
}
