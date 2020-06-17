using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson4_Part1
{
    class InternationalStudent : Student
    {
        //PRIVATE INSTANCE MEMBERS

        //PUBLIC PROPERTIES
        public string InternationAddress { get; set; }

        //CONSTRUCTOR
        

        //PRIVATE METHODS

        //PUBLIC METHODS
        public InternationalStudent(string name, int age, string student_id,string international_address) 
            : base(name, age, student_id)
        {
            InternationAddress = international_address;
        }
    }
}
