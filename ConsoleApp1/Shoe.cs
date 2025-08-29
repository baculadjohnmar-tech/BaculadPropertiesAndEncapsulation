using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shoe
    {
        //Declaring the fields
        private string brand;
        private int size;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        //Method to display
        public void DisplayBrand()
        {
            Console.WriteLine("Enter the brand: \t\t");
            Console.WriteLine("Enter the size: \t\t");
        }
    }
}
