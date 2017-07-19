using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Students
    {
        public string GetStudentDegree (int studentNumber)
        {
            string studentDegree;
            switch (studentNumber)
            {
                case 1:
                    studentDegree = "Software = 23, DSS = 20, OR = 30, math = 25";
                    break;
                case 2:
                    studentDegree = "software = 21, DSS = 25, OR = 28,  math = 3";
                    break;
                case 3:
                    studentDegree = "software = 19, DSS = 30, OR = 29, math = 20";
                    break;
                default:
                    studentDegree = "Wrong student number";
                    break;
            }
            return studentDegree;
        }
    }
}
