using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            string StudentDegree;
            Console.WriteLine("Please input the student id");
            int studentNumber = int.Parse(Console.ReadLine());
            StudentDegree = student.GetStudentDegree(studentNumber);
            Console.WriteLine("Degree of student with number " + studentNumber
                + " is :\n" + StudentDegree);
            
        }
    }
}
