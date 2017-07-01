using System;

class Exercise02
{
    static void Main()
    {
        int num, wid;
        
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        Console.Write("Enter the desired width: ");
        wid = int.Parse(Console.ReadLine());
        
        for (int t = 1; t <= wid; t++)
        {
            for (int i = wid - t; i >= 1; i--)
            {
                Console.Write(num);
            }
        Console.WriteLine(num);
        }
        
        Console.ReadLine();
    }
}