namespace hwLesson12
{
    public delegate double Calculate(double x, double y);

    internal class Program
    {
        static private void Handler(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Divided by 0");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input A:");
                double a = Double.Parse(Console.ReadLine());

                Console.Write("Input B:");
                double b = Double.Parse(Console.ReadLine());

                Console.Write("Input the sign of the math operation: ");
                char operation = Char.Parse(Console.ReadLine());

                Calculator calculator = new Calculator();

                if (operation == '/' && b == 0)
                {
                    calculator.dividedByZero += new EventHandler(Handler);
                    calculator.InvokeEvent(null, new EventArgs());
                    continue;
                }               

                Calculate calculate = operation switch
                {
                    '+' => Calculator.Add,
                    '-' => Calculator.Sub,
                    '*' => Calculator.Mul,
                    '/' => Calculator.Div,
                };

                Console.WriteLine($"{a} {operation} {b} = {calculate(a, b)}");
            }
        }
    }
}