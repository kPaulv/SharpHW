using System;
using System.Collections.Generic;

namespace SharpEx2
{
    public class Student
    {
        private readonly string _name;
        private readonly double _lowestGrade;
        private readonly double _highestGrade;
        private readonly double _meanGrade;

        public Student()
        {
            
        }

        public Student(string name, double lowGrade, double highGrade, double meanGrade)
        {
            _name = name;
            _lowestGrade = lowGrade;
            _highestGrade = highGrade;
            _meanGrade = meanGrade;
        }

        public Student(Student oStudent)
        {
            _name = oStudent.GetName();
            _lowestGrade = oStudent.GetLowestGrade();
            _highestGrade = oStudent.GetHighestGrade();
        }

        public string GetName()
        {
            return _name;
        }

        public double GetLowestGrade()
        {
            return _lowestGrade;
        }

        public double GetHighestGrade()
        {
            return _highestGrade;
        }

        public double GetMeanGrade()
        {
            return _meanGrade;
        }

        public void DisplayGrades()
        {
            Console.WriteLine($"Name: {_name}, LowGrade: {_lowestGrade}, HighGrade:" +
                              $" {_highestGrade}, Mean: {(_lowestGrade + _highestGrade) / 2}");
        }

    }
    public class StudentList
    {
        private LinkedList<Student> _students;

        public StudentList()
        {
            _students = new LinkedList<Student>();
        }

        public LinkedList<Student> GetStudents()
        {
            return _students;
        }

        public void SetStudents(LinkedList<Student> otherStudents)
        {
            _students = otherStudents;
        }

        public void AddStudent(Student student)
        {
            _students.AddLast(student);
        }

        public void ShowList()
        {
            foreach (var item in _students)
            {
                Console.WriteLine($"Name: {item.GetName()}, LowestGrade: {item.GetLowestGrade()}, " +
                                  $"HighestGrade: {item.GetHighestGrade()}, Mean: {item.GetMeanGrade()}.");
            }
        }
    }
}
