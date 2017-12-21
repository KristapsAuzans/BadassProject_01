using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wisecalculator
{
    class mathParser
    {
        public int ParserMath(string input)
        {
            int result;
            int counter = 0;
            string firstenteredNumber = "";
            string secondenteredNumber = "";
            char enteredOperation = '';
            bool operationFound = false;
            while (counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
                {
                    if (operationFound == true)
                        int result = Int32.Parse(firstenteredNumber) + Int32.Parse(secondenteredNumber);
                    return result;


                }

                enteredOperation = symbol;
                operationFound = true;

                else
                {
                    
                    if (operationFound == false)
                    {
                        firstenteredNumber = firstenteredNumber + symbol;
                    }   
                    
                    else
                    {

                    }

                    firstenteredNumber = firstenteredNumber + symbol;


                    int number;
                    number = Int32.Parse(symbol.ToString());
                }

                counter = counter + 1;

                Console.WriteLine("error");
                return = 99999;
            }
        }

    }
}
