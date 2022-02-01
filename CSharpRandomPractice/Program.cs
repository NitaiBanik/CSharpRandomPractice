namespace CSharpRandomPractice
{
    class Program
    {
        delegate double Calculate(int x, int y);

        static void Main(string[] args)
        {
            Calculate add = Calculator.AddNumbers;
            System.Console.WriteLine(add(10,20));

            Calculate divide = Calculator.DivNumbers;

            System.Console.WriteLine(divide(10, 3));
        }
    }
    public static class Calculator
    {
        public static double AddNumbers(int x, int y) => x + y;
        public static double DivNumbers(int x, int y) => x / y;
    }
}
