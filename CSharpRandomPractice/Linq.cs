using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpRandomPractice
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class Linq
    {
        private readonly IList<Student> _studentList = new List<Student>
        {
            new() {StudentId = 1, StudentName = "John", Age = 18},
            new() {StudentId = 2, StudentName = "Steve", Age = 15},
            new () {StudentId = 3, StudentName = "Bill", Age = 25},
            new () {StudentId = 4, StudentName = "Ram", Age = 20},
            new () {StudentId = 5, StudentName = "Ron", Age = 19},
            new () {StudentId = 6, StudentName = "Ram", Age = 18}
        };

        readonly IList _mixedList = new ArrayList();
        
       

        public void PracticeLinq()
        {
            _mixedList.Add(0);

            _mixedList.Add("One");
            _mixedList.Add("Two");
            _mixedList.Add(3);
            _mixedList.Add(new Student() { StudentId = 1, StudentName = "Bill" });

            var stringResult = _mixedList.OfType<string>();
            var res = _studentList.OrderBy(s => s.StudentName)
                .ThenBy(s => s.Age).ToList();
        }
    }
}
