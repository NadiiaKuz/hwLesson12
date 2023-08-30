namespace hwLesson12
{
    public delegate double Calculate(double x, double y);

    internal class Program
    {

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
                    calculator.InvokeEvent();
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