using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson4_Part1
{
    class DomesticStudent : Student
    {
        //PRIVATE INSTANCE MEMBERS

        //PUBLIC PROPERTIES
        public string DometicAddress { get; set; }

        //CONSTRUCTOR(S)
        public DomesticStudent(string name, int age, string student_id , string domestic_address) : base(name, age, student_id)
        {
            DometicAddress = domestic_address;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
    }
}
