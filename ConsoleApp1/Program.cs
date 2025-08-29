using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a class object
            Shoe shoe = new Shoe();

            shoe.Brand = "Nike";
            shoe.Size = 40;

            shoe.DisplayBrand();

            Console.ReadKey();
        }
    }
}
