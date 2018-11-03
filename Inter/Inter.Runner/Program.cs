using System;

namespace Inter.Runner
{
    class Program
    {
        static void Main()
        {
            var res = new Calculator().Calc(1, 2);
            Console.WriteLine($"Result = {res}");
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public int Calc(int a, int b)
        {
            return a + b;
        }
    }
}
