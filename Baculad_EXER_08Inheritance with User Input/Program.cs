using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baculad_EXER_08Inheritance_with_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Shoe Details:");
            Console.WriteLine("Running Shoe or Formal Shoe");
            Console.Write("Enter your choice(Running Shoe or Formal Shoe):\t");
            string choice = Console.ReadLine();


            if (choice == "Running Shoe")
            {
                RunningShoe runningShoe = new RunningShoe();

                Console.Write("\nEnter the Brand    :");
                runningShoe.Brand = Console.ReadLine();
                Console.Write("Enter the size  :");
                runningShoe.Size = Console.ReadLine();
                Console.Write("Enter the Material:");
                runningShoe.Cuhioning = Console.ReadLine();
                Console.Write("Enter the Color:");
                runningShoe.Purpose = Console.ReadLine();

                
                runningShoe.RunningShoeInfo();
               

            }
            else if (choice == "Formal Shoe")
            {
                FormalShoe formalShoe = new FormalShoe();

                Console.Write("\nEnter the Brand    :");
                formalShoe.Brand = Console.ReadLine();
                Console.Write("Enter the size  :");
                formalShoe.Size = Console.ReadLine();
                Console.WriteLine("Enter the Material:");
                formalShoe.Material = Console.ReadLine();
                Console.WriteLine("Enter the Color:");
                formalShoe.Color = Console.ReadLine();

                formalShoe.FormalShoeInfo();

                Console.ReadKey();

            }
        }
    }
}
