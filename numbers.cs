using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of integers (separated by spaces):");
        string input = Console.ReadLine();

        string[] numberStrings = input.Split(' ');

        foreach (string numberString in numberStrings)
        {
            int number = int.Parse(numberString);
            numbers.Add(number);
        }

        List<int> evenNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        List<int> modifiedNumbers = new List<int>();

        foreach (int number in evenNumbers)
        {
            if (number % 3 == 0)
            {
                modifiedNumbers.Add(number * number);
            }
            else
            {
                modifiedNumbers.Add(number);
            }
        }

        Console.WriteLine("Original numbers:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nModified numbers:");
        foreach (int number in modifiedNumbers)
        {
            Console.Write(number + " ");
        }
    }
}
