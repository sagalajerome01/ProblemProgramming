using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber; // This is for the size of the Rows of the Asterisks Patters
            string letter; // O, X, Y, Z only
            string yesNo; // if you want to try again, type Y or N
            bool tryAgain = true; // If Yes then it will repeat, if No then it will stop

            while (tryAgain)
            {
                Console.Write("Enter a character [O, X, Y, Z]: ");
                letter = Console.ReadLine(); // This is where you type the letter that you want

                var checker = new ErrorHandler(); // Will check if you put the right letter or not
                string finalLetter = checker.WrongInput(letter); // You will get the returned value in case you put a wrong letter before going inside the error handler

                Console.Write("Enter a non-negative odd integer that starts from 3: ");
                stringNumber = Console.ReadLine(); // Your number is still counted as string
                int finalNumber = checker.WrongNumber(stringNumber); // You will get the returned value that you finalized during the ErrorHandling

                var display = new FunctionLetters(); // Will go to the asterisks patterns function
                display.Display(finalLetter, finalNumber); // Displays the Final Result

                Console.Write("Do you want to try again? type [Y] yes or [N] no: ");
                yesNo = Console.ReadLine();
                tryAgain = checker.tryAgain(yesNo); // Will check your input and it will loop if you inserted the wrong input, It will stop if you type N and it will start again if you typed Y
            }
        }
    }
}