using System;

class Exercise11
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("You look older than " + age);
        Console.ReadLine();
    }
}