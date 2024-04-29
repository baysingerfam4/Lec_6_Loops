using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;
using System.Xml;
using System.Text.RegularExpressions;

namespace Lec_6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carla Baysinger
            // Lecture 6 Loops
            // April 28th 2024

            WhileLoopExample();
            ValidateUserInput();
            DoWhileExample();
            PasswordValidation();
            ForLoopExample();
            SumAndAverageNumbers();
        }

        public static void WhileLoopExample()
        {
            int count = 0;

            while (count <= 10)
            {
                if (count <= 10)
                    Console.WriteLine(count); //prints out count
                    count++; //increases the count by 1
            }
        } //WhileLoopExample()

        public static void ValidateUserInput()
        {
            //Declare variables input (string), number (integer), and isValid (boolean)
                           
            string input;
            int number = 0;
            bool isValid = false; //Set isValid to false
            while (!isValid)
            {
                Console.Write("Enter a number: "); //While isValid is false:
                                                   //Ask the user to enter a number
                input = Console.ReadLine(); //Read the user's input and store it in the 'input' variable

                if (int.TryParse(input, out number)) //Try to convert the 'input' string to an integer and store the result in 'number'
                {
                    isValid = true; // If conversion succeeds:Set isValid to true
                }

                else     //Else: Display an error message  "Invalid input"

                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine($"You entered: {number} "); //Print the message "You entered: " followed by the value in the 'number' variable


        } //ValidateUserInput()

        public static void DoWhileExample()
        {
            int count = 11; //Set count to 11
                            
            do
            {
                Console.WriteLine(count); //Do:Print the current value of count
            } while (count <= 10);  //While 'count' is less than or equal to 10

            Console.WriteLine("This is after our while loop"); //Print the message "This is after our while loop"
        } //DoWhileExample()

        public static void PasswordValidation()
        {
        //Purpose: Enforces password entry with at least 8 characters, an uppercase letter, and a number.Uses a do -while loop for repeated prompts.

            string password; //Declare variables password(string), isValidPassword(boolean)
            bool isValidPassword;
            string userpassword = "Baysinger2"; //Set the correct password
            isValidPassword = false; //Set isValidPassword to false

            do
            {
                Console.Write("Enter your password: "); //Do:Ask the user to enter a password
                password = Console.ReadLine(); //Read the user's input and store it in the 'password' variable
                if (isValidPassword = password == userpassword) // Check if the entered password matches the correct password
                {
                    isValidPassword = true; //If they match: Set isValidPassword to true
                }
                else
                {
                    Console.WriteLine("invalid"); //Else:Display an error message
                }
                
            } while (!isValidPassword); //While isValidPassword is false


        } //passwordValidation()

        public static void ForLoopExample()
        {
            //Demonstrates the use of a for loop for basic counting and decrementing iteration.
            for (int i = 450; i > -25; i -= 5) //For a variable 'i' starting at 450 and going down to above -25, decreasing by 5 each time:               
            {
                Console.WriteLine(i); //Print the current value of 'i'
            }
        } //ForLoopExample()

        public static void SumAndAverageNumbers()
        {
            //Calculates the sum and average of numbers from 0 to 300 incrementing by 4.       
            int sum = 0; //Initialize variables sum and count to 0 
            int count = 0;
            for (int i = 0; i < 300; i += 4) //For a variable 'i' starting at 0 and going up to, but not including, 300, increasing by 4 each time:
            {
                sum += i;  // Add 'i' to the 'sum' variable
                count++; //Increase 'count' by 1
            }
            Console.WriteLine($"Sum: {sum} - Count: {count}");  //Print the sum and the count
            double avg = sum / count; //Calculate the average(sum divided by count)
            Console.WriteLine($"Average: {avg}"); //Print the average
        } //SumAndAverageNumber()



    } //class
} //namespace
