using System;

public class Exercise9example
{
    public static void Main()
    {
        char symbol;
         
        Console.Write("Input a symbol: ");
        symbol=Convert.ToChar(Console.ReadLine());
         
        if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || 
                (symbol == 'o') || (symbol == 'u'))
            Console.WriteLine("It's a lowercase vowel.");
        else if ((symbol >= '0') && (symbol <= '9'))
            Console.WriteLine("It's a digit.");
        else
            Console.Write("It's another symbol.");        
    }
}
//The benefit to this program over the one I wrote is that if you try to type anything that is 
//longer than one character, it throws and exception and ends the program.

//Mine on the other hand, I think only sees the first character and then converts it to a
//char, but ignores other characters typed after.
