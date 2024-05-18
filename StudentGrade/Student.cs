using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade
{
    public class Student
    {
        private Grade[] grades = [];
        public string Name { get; set; }
        public Grade[] Grades { get => grades; }

        public Student(string name)
        {
            Name = name;
        }

        public void AddGrade(params Grade[] forAddGrade)
        {
            foreach (Grade grade in forAddGrade)
            {
                Array.Resize(ref grades, grades.Length + 1);
                grades[grades.Length - 1] = grade;
            }
        }

        public void GetAllGrades()
        {
            foreach (var grade in grades) grade.GetDetails();
        }
    }
}
