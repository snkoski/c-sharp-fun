using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("book1");
            book.AddGrade(89.1);
            book.AddGrade(77.7);
            book.AddGrade(95.5);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The average grade is: {stats.Average}");
        }
    }
}
