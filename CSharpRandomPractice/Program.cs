using System;

namespace CSharpRandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, double> add = Calculator.AddNumbers;
            Console.WriteLine(add(10, 20));

            Func<int, int, double> divide = Calculator.DivNumbers;

            Console.WriteLine(divide(10, 3));

            Action<int, int> printSum = Calculator.PrintSum;
            printSum(44, 44);

            Predicate<int> isEven = Calculator.IsEven;
            Console.WriteLine(isEven(5));


        }
    }
    public static class Calculator
    {
        public static double AddNumbers(int x, int y) => x + y;
        public static double DivNumbers(int x, int y) => x / y;

        public static void PrintSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static bool IsEven(int x) => x % 2 ==  0;
    }
}
