using System;

class Program
{
    static void Main()
    {
        // Welcomes the user
        Console.WriteLine("Welcome!");

        // Asks the user for their first name and assign it to the variable "firstName"
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Asks the user for their last name and assign it to the variable "lastName"
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Prints a greeting message with the user's first and last name
        Console.WriteLine($"Hello, {firstName} {lastName}!");
    }
}
