using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter first number");
            calculator.firstNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            calculator.secondNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter calculate symbol");
            calculator.Symbol = char.Parse(Console.ReadLine());

            decimal result = calculator.calculate();

            string message = $"{calculator.firstNum} {calculator.Symbol} {calculator.secondNum} = {result}";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
