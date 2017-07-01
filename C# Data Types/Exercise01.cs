using System;

class Exercise01
{
    static void Main()
    {
        string letter1, letter2, letter3;
        
        Console.Write("Enter letter: ");
        letter1 = Console.ReadLine();
        Console.Write("Enter letter: ");
        letter2 = Console.ReadLine();
        Console.Write("Enter letter: ");
        letter3 = Console.ReadLine();
        
        Console.WriteLine("{0} {1} {2}", letter3, letter2, letter1);
        Console.ReadLine();
    }
}