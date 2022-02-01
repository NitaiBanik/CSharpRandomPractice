using System;

namespace CSharpRandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(AddNumbers, 5, 6);
            Print(DivNumbers, 5, 6);

            Action ac = Hi;
            ac();
        }
        public static double AddNumbers(int x, int y) => x + y;
        public static double DivNumbers(int x, int y) => (double)x / y;

        public static void Print(Func<int, int, double> del, int x, int y)
        {
            Console.WriteLine(del(x, y));
        }

        public static void Hi()
        {
            Console.WriteLine("Hi");
        }
    }


}
