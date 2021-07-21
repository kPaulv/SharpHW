using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEx2
{
    struct Student
    {
        public string Name;
        public double LowestGrade;
        public double HighestGrade;
        public double MeanGrade;

        public void SetName(string oName)
        {
            Name = oName;
        }

        public void CountMean()
        {
            MeanGrade = (LowestGrade + HighestGrade) / 2;
        }

        public void DisplayGrades()
        {
            Console.WriteLine($"Name: {Name}, LowGrade: {LowestGrade}, HighGrade:" +
                              $" {HighestGrade}, Mean: {MeanGrade}");
        }

    }
    class StudentList
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

        public void ShowList()
        {
            foreach (var item in _students)
            {
                Console.WriteLine($"Name: {item.Name}, LowestGrade: {item.LowestGrade}, " +
                                  $"HighestGrade: {item.HighestGrade}, Mean: {item.MeanGrade}.");
            }
        }
    }
}
