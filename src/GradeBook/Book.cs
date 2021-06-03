using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {        
        public Book(string name)
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public List<double> grades;
    }
}