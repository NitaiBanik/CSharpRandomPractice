using System;
using System.Collections.Generic;

namespace CSharpRandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input * 2);

            var dic = new Dictionary<string, string>
            {
                {"a", "b"},
                {"c", "d"},
            };

            var val = dic["a"];
            var val2 = dic["e"];


            var intName =(int)NameEnum.Banik;
            var enumName = (NameEnum)intName;
            var stringName = enumName.ToString();

            var str = "Chandra";
            var toEnum = Enum.Parse(typeof(NameEnum), str);

            var groupBy = new GroupBy();
            groupBy.TestGroupBy();
        }
    }
}
