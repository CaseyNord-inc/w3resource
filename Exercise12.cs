using System;

class Exercise12
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int digit = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0} {0} {0} {0}", digit);
        Console.WriteLine("{0}{0}{0}{0}", digit);
        Console.WriteLine("{0} {0} {0} {0}", digit);
        Console.WriteLine("{0}{0}{0}{0}", digit);
        Console.ReadLine();
    }
}