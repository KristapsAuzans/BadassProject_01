using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //izveido kalkulēšanas objektu
            Calculations calc;
            calc = new Calculations();

            //Prasa lietotājam skaitli
            int firstNumber = calc.AskUserForNumber();
            
            //Prasa lietotājam skaitli
            int secondNumber = calc.AskUserForNumber();

            //Veic kalkulācijas
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
            Console.ReadLine();
        
        }
    }
}
