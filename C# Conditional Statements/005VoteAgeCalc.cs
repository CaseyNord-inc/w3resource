using System;

class VoteAgeCalc
{
    static void Main()
    {
        int age;

        Console.Write("\nTakes the age of a candidate and determines if they are eligable to vote:\n");
        Console.Write("-------------------------------------------------------------------------\n\n");

        Console.Write("Input an age: ");
        while (!Int32.TryParse(Console.ReadLine(), out age))
        {
            Console.Write("That is not a valid input. Please try again: ");
        }

        if (age > 18)
        {
            Console.Write("This candidate is eligable to vote");
        }
        else
        {
            Console.Write("This candidate is not eligable to vote");
        }
        Console.Write("\n\nPress any key to exit");
        Console.ReadKey();
    }
}