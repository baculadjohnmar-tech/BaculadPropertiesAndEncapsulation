﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public string name {get; set;}
        public int age {get; set;}

        public void DisplayMaloi()
        {
            Console.WriteLine($"Hi I'm {name} and I am {age}");
        }
    }
}

