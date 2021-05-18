using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class ErrorHandler
    {
        public string WrongInput(string letter) // It will automatically check if the letter that you typed is right or wrong
        {
            bool input = true;
            letter = letter.ToUpper();
            while (input)
            {
                switch (letter)
                {
                    case "O":
                        input = false;
                        break;
                    case "X":
                        input = false;
                        break;
                    case "Y":
                        input = false;
                        break;
                    case "Z":
                        input = false;
                        break;
                    default:
                        Console.Write("Error: Wrong Input \n");
                        input = true;
                        Console.Write("Enter a character [O, X, Y, Z]: ");
                        letter = Console.ReadLine();
                        letter = letter.ToUpper();
                        break;
                }
            }
            return letter;
        }
        

        public int WrongNumber(string stringNumber) // It will automatically check if the number that you typed is right or wrong
        {
            int number;
            Int32.TryParse(stringNumber, out number); // Converted string into Integer, This way the application does not throw an exception even if just press *enter* without typing anything or if you use characters instead of numbers
            bool inputNum = true;
            while (inputNum)
            {
                switch (number % 2)
                {
                    case 0:
                        inputNum = true;
                        Console.Write("Error: Even numbers, Charaters or Typing nothing are not allowed, Please Try again \n ");
                        Console.Write("\nEnter a non-negative odd integer that starts from 3: ");
                        string stringEvenNumber = Console.ReadLine(); // Your even number is still counted as string 
                        Int32.TryParse(stringEvenNumber, out number); // Converted that string into number
                        break;
                    case 1:
                        if (number == 1)
                        {
                            inputNum = true;
                            Console.Write("Error: The value is lower than 3, Please Try again \n");
                            Console.Write("\nEnter a non-negative odd integer that starts from 3: ");
                            string stringOddNumber = Console.ReadLine(); // Your odd number that is less that 3 is still counted as string
                            Int32.TryParse(stringOddNumber, out number);
                            break;
                        }
                        else
                        {
                            inputNum = false;
                            break;
                        }
                    default:
                        Console.Write("Enter a non-negative odd integer that starts from 3: ");
                        string stringNumber1 = Console.ReadLine(); // Your number is still counted as string
                        Int32.TryParse(stringNumber1, out number);
                        break;
                        
                }
            }
            return number;
        }

        public bool tryAgain (string yesNo) // It will check it for you if you typed Y, N or different characters
        {
            yesNo = yesNo.ToUpper();
            bool input = true;
            bool confirmation = false;
            while (input)
            {
                switch (yesNo)
                {
                    case "Y":
                        input = false;
                        confirmation = true; // Confirmation is true therefore it will loop back to the start so you can try again
                        break;
                    case "N":
                        input = false;
                        confirmation = false; // Confirmation is false therefore it will stop after typing N
                        break;
                    default:
                        input = true;
                        Console.Write("Wrong input.\nDo you want to try again?: ");
                        yesNo = Console.ReadLine();
                        yesNo = yesNo.ToUpper();
                        break;

                }
            }
            return confirmation;
        }

    }
}
