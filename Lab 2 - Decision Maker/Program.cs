using System;

public class Program
{
    public static void Main()
    {
        var response = "y";         //Global variable which acts as a trigger. When this value isn't 'y', the do while loop will exit.
        string isEven = "";         //Global variable which stores a string. String indicates whether user input is even or odd.
        string statement = "";      //Global variable which stores a string related to the user's numerical input. 

        do
        {
            //Lines 15-23: Introduces the program to user and asks for their name.

            Console.WriteLine("\nHello! Welcome to the 'Totally Unnecessary Number Analyzer,' or TUNA for short!\n");
            Console.WriteLine("Are YOU unable to tell whether a number is even or odd? Well, don't waste time blaming your elementary math teacher.\n");
            Console.WriteLine("Just use TUNA! This, you see, is the application for you.");

            Console.WriteLine("\nFirst, we here at TUNA like to get to know our users. What is your name?\n");

            string name = Console.ReadLine();

            Console.WriteLine("\nHi " + name + "! Don't worry, we won't tell your friends that you don't know how to divide something by two.\n");

            //Lines 28-42: Prompts the user to enter a number between 1 & 100 and checks users input with 'TryParse'.
            //Conditional statements loop the user back to the program start based on 'TryParse' results.

            Console.WriteLine("Next, please enter a positive number, but not one greater than 100. We don't talk about such crass numbers here.");
            Console.WriteLine();

            var isNumeric = int.TryParse(Console.ReadLine(), out int num1);

            if (isNumeric == false)
            {
                Console.WriteLine("\nI'm sorry, that wasn't a number at all! Let's try that again.\n");
                continue;
            } 
            else if (isNumeric == true && num1 < 0 || num1 > 100) 
            {
                Console.WriteLine("\nI told you...We don't talk about those numbers here! Try again!\n");
                continue;
            }

            Console.WriteLine();

            //Lines 49-73: Conditional statements check the value of num1 returned by user's input.
            //Based on the number the user enters, different strings will be concatenated together to make the final response.

            if (num1 % 2 == 0)
            {
                isEven = " is even ";
            }
            else
            {
                isEven = " is odd ";
            }

            if (num1 <25)
            {
                statement = "and less than 25";
            } 
            else if (num1 >= 26 && num1 <= 60)
            {
                statement = "and between 26 and 60 inclusive";
            }
            else if (num1 <= 59)
            {
                statement = "and less than 60";
            }
            else if (num1 > 60)
            {
                statement = "and greater than 60";
            }

            //Line 77: The final feedback in the user is concatenated based on the choices thus far.

            Console.WriteLine(num1 + isEven + statement + ", " + name + ".");

            //Lines 81-83: User is prompted for final input, asking if they would like to continue the program. Interacts with global var 'response.'

            Console.WriteLine("\nIf you want to check another number, enter 'y'. Otherwise, this program will end.");
            Console.WriteLine();
            response = Console.ReadLine();

        } while (response == "y" || response == "Y" || response == "yes");

        Console.WriteLine("\nGoodbye! Thank you for using the 'Totally Unneccessary Number Analyzer!'");
    }
}