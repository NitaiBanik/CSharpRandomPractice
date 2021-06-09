using System;
using System.Collections.Generic;

namespace CSharpRandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "NitaiBanik";
            string partWithoutLength = testString.Substring(5);
            string partWithLength = testString.Substring(5, 5);
            Console.WriteLine(partWithoutLength);
            Console.WriteLine(partWithLength);

            int charIndex = testString.IndexOf('i');
            int stringIndex = testString.IndexOf("it");
            int charIndexAfter = testString.IndexOf('i',5);
            int stringIndexAfter = testString.IndexOf("ii", 5);

            Console.WriteLine(charIndex + " " + stringIndex + " " + charIndexAfter + " " + stringIndexAfter);

            Console.WriteLine(testString.Remove(1));
            Console.WriteLine(testString.Remove(1, 2));
            Console.WriteLine(testString.Insert(5, " "));
            Console.WriteLine(testString.Insert(0, "Mr. "));

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
