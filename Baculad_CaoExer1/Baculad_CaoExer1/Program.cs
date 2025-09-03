using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baculad_CaoExer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Mar C. Baculad    IT306
            //Creating a class

            //Instantiation of an object
            Person person1 = new Person();

            //Initialization of fields 
            person1.name = "John Mar";
            person1.age = 18;
            person1.gender = "Male";

            //Call the method 
            person1.Greet();

            Console.ReadKey();
        }
    }
}
