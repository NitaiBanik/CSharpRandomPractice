using System.Collections.Generic;
using System.Linq;

namespace CSharpRandomPractice
{
    public class GroupBy
    {
        IList<Student> _studentList = new List<Student> {
            new() { StudentId = 1, StudentName = "John", Age = 18 } ,
            new () { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
            new () { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
            new () { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            new () { StudentId = 5, StudentName = "Abram" , Age = 21 }
        };

        public void TestGroupBy()
        {
            var res = _studentList.GroupBy(s => s.Age);
            var res2 = _studentList.ToLookup(s => s.Age);
        }
    }
}
