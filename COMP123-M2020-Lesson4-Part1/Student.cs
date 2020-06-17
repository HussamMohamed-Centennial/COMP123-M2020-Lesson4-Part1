using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson4_Part1
{
    class Student : Person
    {
        private string m_studentID;

        public Student(string name, int age, string student_id)
                :base(name,age)
        {
            m_studentID = student_id;
        }
    }
}
