using System;

class Exercise10
{
    static void Main()
    {
        int a, b;
        
        Console.WriteLine("This program takes two numbers as input and returns true when both numbers are even and false when both numbers are odd.");
        Console.WriteLine();

        Console.Write("Enter a number :");
        a = Int32.Parse(Console.ReadLine());

        Console.Write("Enter a number :");
        b = Int32.Parse(Console.ReadLine());

        if (a % 2 == 0 && b % 2 == 0)
        {
            Console.WriteLine("True");
        }
        else if (a % 2 != 0 && b % 2 != 0)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("Null");
        }
        
        Console.WriteLine("Press any key to exit.");
        Console.Read();
    }
}