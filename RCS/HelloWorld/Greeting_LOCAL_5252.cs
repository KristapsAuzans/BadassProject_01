﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Greeting
    {
        public string HelloText;
        public void SayHello()
        {
            Console.WriteLine("Write your name?");
            string myName;
            myName = Console.ReadLine();
            Console.WriteLine (HelloText + myName);
            Console.WriteLine("Sveiciens, " + myName + "!");
        }
    }
}
