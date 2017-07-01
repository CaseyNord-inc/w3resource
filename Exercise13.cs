using System;

class Exercise13
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0}{0}{0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0}{0}{0}", number);
        Console.ReadLine();
    }
}