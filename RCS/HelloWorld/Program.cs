using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greet;
            greet = new Greeting();
            greet.SayHello();
            Console.ReadLine();
        }
    }
}
