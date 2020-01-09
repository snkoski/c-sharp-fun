using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var total = 0.0;
            foreach(double grade in grades)
            {
                highGrade = Math.Max(highGrade, grade);
                lowGrade = Math.Min(lowGrade, grade);
                total += grade;
            }

            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"The average grade is: {total / grades.Count:N1}");
        }
        public string GetName()
        {
            return name;
        }

        private List<double> grades;
        private string name;
    }
}