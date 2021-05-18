using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class FunctionLetters
    {

        public void Display (string letter, int number) // Displays the final output
        {
            letter = letter.ToUpper();
            switch (letter)
            {
                case "O":
                    FunctionO(number);
                    break;
                case "X":
                    FunctionX(number);
                    break;
                case "Y":
                    FunctionY(number);
                    break;
                case "Z":
                    FunctionZ(number);
                    break;
                default:
                    Console.Write("Error: Wrong Input \n");
                    break;
            }
        }

        private void FunctionO(int oddNum)
        {
            int rows; // Variable for the rows of the asterisks
            for (int height = 1; height <= oddNum; height++) // Total height of how many rows 
            {
                if (height == 1 || height == oddNum) // The first row and the Last Row
                {
                    for (rows = 1; rows <= oddNum; rows++) // First and Last Row ( Added space on first and last column to create a letter O using asterisks )
                    {
                        if (rows == 1 || rows == oddNum)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                else
                {
                    for (rows = 1; rows <= oddNum; rows++) // Second to second last rows
                    {
                        if (rows == 1 || rows == oddNum)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\n");
            }

        }

        private void FunctionX(int oddNum) // If the user typed X as its asterisks pattern
        {
            int copyNum = oddNum;
            int iCounter;

            for (int i = 1; i <= oddNum; i++, copyNum--) // Final Size ( how many rows )
            {
                iCounter = i; // copy i
                for (int j = 1; j <= oddNum; j++) // Insert *
                {
                    if (j == iCounter || j == copyNum) // Left and Right * diagonal
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        private void FunctionY(int oddNum)
        {
            int copyNum = oddNum;
            int iCounter;
            int dividedNum = (oddNum / 2) + 1;

            for (int i = 1; i <= oddNum; i++, copyNum--) // Final Size ( how many rows )
            {
                iCounter = i; // copy i
                for (int j = 1; j <= oddNum; j++) // Insert Row *
                {
                    if (i < dividedNum)
                    {
                        if (j == iCounter || j == copyNum) // Left and Right *
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" "); // Spaces for the V ( half of the Y ) 
                        }
                    }
                    else
                    {
                        if (j == dividedNum) // Insert * at the middle part
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\n");
            }
        }

        private void FunctionZ(int oddNum)
        {
            int copyNum = oddNum;

            for (int i = 1; i <= oddNum; i++, copyNum--) // Final Size ( how many rows )
            {
                if (i == 1 || i == oddNum) // Up and Down * 
                {
                    for (int j = 1; j <= oddNum; j++) // Insert * Row
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int k = 1; k <= oddNum; k++) // Diagonal  asterisk and then spaces
                    {
                        if (k == copyNum)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}