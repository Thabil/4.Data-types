﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Thabile";
            int age = 10;
            bool isTall = false;
            double weight = 25.5;

            //Hi Thabile, you are 10 and your weight is 25.5
            Console.WriteLine(" Hi " + name + ", you are " + age + " and your weight is " + weight);
            
            //
            Console.WriteLine(" true or false you are tall: " + isTall);
        }
    }
}
