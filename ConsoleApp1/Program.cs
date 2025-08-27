using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maloi bini = new Maloi();
            Console.Write("Name: ");
            bini.name = Console.ReadLine();
            Console.Write("Age: ");
            bini.age = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}


