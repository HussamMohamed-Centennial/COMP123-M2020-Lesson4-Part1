using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson4_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hussam", 38);
            person.SaysHello();

            Console.WriteLine(person.ToString());
            
            Person jacky = new Person("Jacky", 20);
            jacky.SaysHello();
            Console.WriteLine(jacky.ToString());

            InternationalStudent maxim=new InternationalStudent("Maxium",21,"B1234556","1 Russia Rd");
            maxim.SaysHello();
            
        }
    }
}
