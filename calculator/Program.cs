using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add(10, 11);
            Console.WriteLine($"10 + 11 = {result}");
        }
    }
}
