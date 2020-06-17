using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson4_Part1
{
    class Person
    {
        // PRIVATE INSTANCE VARIABLE (FIELDS)
        private string m_name;
        private int m_age;

        // PUBLIC PROPERITIES
        public string Name 
        { 
            get //accessor
            {
                return m_name;
            }
            set // mutator
            {
                m_name = value;
            }
        }

        public int Age
        {
            get
            {
                return m_age;
            }
            set
            {
                m_age = value;
            }
        }

        //CONSTRUCTOR
        public Person(string name, int age)
        {
            m_name = name;
            m_age = age;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
        public void SaysHello()
        {
            Console.WriteLine($"{Name} say hello");
        }

        /// <summary>
        /// this method override the superclass Tostring method
        /// </summary>
        /// <returns>
        /// this method return a formatted string that display class method
        /// </returns>
        public override string ToString()
        {
            string outputstring = "";

            outputstring += $"name:{Name} \n";
            outputstring += $"Age : {Age} \n";
            return outputstring;
        }
    }
}
