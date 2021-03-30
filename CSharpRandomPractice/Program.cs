using System;

namespace CSharpRandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var intName =(int)NameEnum.Banik;
            var enumName = (NameEnum)intName;
            var stringName = enumName.ToString();

            var str = "Chandra";
            var toEnum = Enum.Parse(typeof(NameEnum), str);

            var linq = new Linq();
            linq.PracticeLinq();
        }
    }
}
