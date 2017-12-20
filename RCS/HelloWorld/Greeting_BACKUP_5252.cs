using System;
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
<<<<<<< HEAD
            Console.WriteLine (HelloText + myName);
=======
>>>>>>> fd81862d2452688d9673260edf454fd9a2c9858e
            Console.WriteLine("Sveiciens, " + myName + "!");
        }
    }
}
