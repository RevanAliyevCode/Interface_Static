// See https://aka.ms/new-console-template for more information

using StudentGrade;

Grade grade = new("Python", Degree.B);
Grade grade1 = new("C#", Degree.A);
Grade grade2 = new("Java", Degree.C);
Grade grade3 = new("C++", Degree.E);

Student student1 = new("Revan");

student1.AddGrade(grade, grade1, grade2, grade3);

student1.GetAllGrades();