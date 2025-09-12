using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baculad_EXER_08Inheritance_with_User_Input
{
    internal class Shoe
    {
        //Fields
        private string brand;
        private string size;


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        //Methods to display
        public void ShoeInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nShirt Details:");
            Console.WriteLine("Size              :" + brand);
            Console.WriteLine("Brand             :" + size);

        }
    }

    class RunningShoe : Shoe
    {
        private string cuhioning;
        private string purpose;

        public string Cuhioning
        {
            get {return cuhioning;}
            set { cuhioning = value;}
        }

        public string Purpose
        {
            get {return purpose;}
            set { purpose = value;} 
        }

        public void RunningShoeInfo()
        {
            ShoeInfo(); 
            Console.WriteLine("Running cuhioning  :" +cuhioning);
            Console.WriteLine("Running Shoe Purpose:" + purpose);
        }
    }

    class FormalShoe : Shoe
    {
        private string material;
        private string color;

        public string Material
        {
            get {return material;}
            set {material = value;}
        }

        public string Color
        {
            get{ return color;}
            set{ color = value;}
        }

        public void FormalShoeInfo()
        {
            ShoeInfo();
            Console.Write("Formal Shoe Material:" +  material);
            Console.Write("Formal Shoe Color:" + color);
        }
    }

}
         
