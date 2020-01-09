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
            book.ShowStatistics();
        }
    }
}
