using System;

namespace CSharpRandomPractice
{
    public enum Name
    {
        Nitai = 1,
        Chandra = 2,
        Banik = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var intName =(int) Name.Banik;
            var enumName = (Name)intName;
            var stringName = enumName.ToString();
        }
    }
}
