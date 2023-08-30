namespace hwLesson12
{
    class Calculator
    {        
        public event EventHandler dividedByZero = null;

        public Calculator()
        {
            dividedByZero += new EventHandler(Handler);
        }
        
        static private void Handler(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Divided by 0");
            Console.ResetColor();
        }

        public void InvokeEvent()
        {
            dividedByZero.Invoke(null, new EventArgs());
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
