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
            greet.HelloText = "Hello world!";
            greet.SayHello();

            Greeting seaGreet;
            seaGreet = new Greeting();
            seaGreet.HelloText = "Ahoy world!";
            seaGreet.SayHello();

            Console.ReadLine();
        }
    }
}
