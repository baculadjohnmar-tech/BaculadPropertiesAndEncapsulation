using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baculad_CaoExer1
{
    internal class Person
    {
        //Class members
        public string name, gender;
        public int age;

        //Method to display 
        public void Greet()
        {
            Console.WriteLine("Hi Everyone, I'm " + name + "and I'm" + age + "years old" + gender);
        }
    }
}
