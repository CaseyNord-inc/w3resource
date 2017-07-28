using System;

class TwoIntsEqual
{
    static void Main()
    {
        int num1, num2;

        Console.Write("\nCheck if two integers are equal:\n");
        Console.Write("--------------------------------\n\n");
        
        Console.Write("Input 1st number: ");
        while (!Int32.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("That is not a valid input. Please try again: ");
        }
        
        Console.Write("Input 2nd number: ");
        while (!Int32.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("That is not a valid input. Please try again: ");
        }

        if (num1 == num2)
        {
            Console.Write("{0} and {1} are equal", num1, num2);
        }
        else
        {
            Console.Write("{0} and {1} are not equal", num1, num2);
        }
        Console.Write("\n\nPress any key to exit.");
        Console.ReadKey();
    }
}