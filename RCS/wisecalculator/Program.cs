using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wisecalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveido calkulatora objektu
            mathParser parser;
            parser = new mathParser();


            //Paprasīt lietotājam ievadīt darbību

            Console.WriteLine("Please enter calculation");
            string input = Console.ReadLine();
            //aprēķināt "1 + 5 - 4" Skaits ir 5, bet pēdējā simbola pozīcija ir 4 (Length = 5)
            // "1+" Skaits ir 2 pēdējā pozīcija ir 1 (Length = 2)

            //izsauc aprēķināšanas rezultātu
            int result = parser.ParserMath(input);

            //izvada rezultātu uz ekrāna
            Console.WriteLine("Your Result" + result);


            Console.ReadLine();
            
        }
    }
}
