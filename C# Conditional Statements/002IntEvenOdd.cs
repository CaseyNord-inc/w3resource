using System;

class IntEvenOdd
{
    static void Main()
    {
        int num;

        Console.Write("\nCheck to see whether an integer is even or odd\n");
        Console.Write("----------------------------------------------\n\n");
        
        Console.Write("Enter a number: ");
        while (!Int32.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("That is not a valid input. Please try again: ");
        }

        if (num % 2 != 0)
        {
            Console.Write(num + " is an odd number.");
        }
        else
        {
            Console.Write(num + " is an even number.");
        }
        Console.Write("\n\nPress any key to exit");
        Console.ReadKey();
    }
}