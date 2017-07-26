using System;

class Exercise11
{
    static void Main()
    {
        int a;
        
        Console.WriteLine("This program takes a number as input and displays its equivalent in binary form.");
        Console.WriteLine();

        Console.Write("Enter a number: ");
        a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Binary: " + Convert.ToString(a, 2));
        
        Console.WriteLine("Press any key to exit.");
        Console.Read();
    }
}