using System;

public class Exercise08.2
{
    public static void Main()
    {        
        Console.Write("Input a number: ");
        int userNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 1000; i++)
        {
            int total = userNumber * i;
            Console.WriteLine("{0} * {1} = {2}", userNumber, i, total);          
        }
        
        Console.ReadLine();
      
    }
}