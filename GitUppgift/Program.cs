namespace GitUppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var calc = new Calculation();

            int sum = calc.Add(5, 3);
            int difference = calc.Subtract(10, 4);
            int product = calc.Multiply(2, 6);
            double result = calc.Divide(10, 2);
        }
    }
}
