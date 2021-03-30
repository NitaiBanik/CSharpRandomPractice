using System.Collections.Generic;
using System.Linq;

namespace CSharpRandomPractice
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class Linq
    {
        private readonly IList<Student> _studentList = new List<Student>()
        {
            new() {StudentID = 1, StudentName = "John", Age = 18},
            new() {StudentID = 2, StudentName = "Steve", Age = 15},
            new () {StudentID = 3, StudentName = "Bill", Age = 25},
            new () {StudentID = 4, StudentName = "Ram", Age = 20},
            new () {StudentID = 5, StudentName = "Ron", Age = 19},
            new () {StudentID = 6, StudentName = "Ram", Age = 18}
        };

        public void PracticeLinq()
        {
            var res = _studentList.OrderBy(s => s.StudentName)
                .ThenBy(s => s.Age).ToList();
        }
    }
}
