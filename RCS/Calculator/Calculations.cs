using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculations
    {
        public int AskUserForNumber ()
        {
            //ievadīt tekstu, kas paprasa ciparu
            Console.WriteLine("Please enter number");
            //ievadīt ciparu no konsoles
            //izveido mainīgo, kas glabās tekstu
            int number;
            //ieraksta mainīgajā ReadLine funkcijas rezultātu
            string inputText = Console.ReadLine();

            //pārveido lietotāja tekstu par ciparu
            bool success = Int32.TryParse(inputText, out number);

            if(success == false)
            {
                Console.WriteLine("Sorry, wrong value entered");
                number = this.AskUserForNumber();
            }

            return number;
        }
        

    }
}
