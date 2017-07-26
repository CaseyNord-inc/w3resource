using System;

class Exercise09
{
    static void Main()
    {
        int x;
        char ch;       

        Console.WriteLine("This program will tell you everything you need to know about the character you input!");
        Console.WriteLine();

        Console.Write("Input a character: ");
        x = Console.Read();
        ch = Convert.ToChar(x);
        bool isVowel = "aeiouAEIOU".IndexOf(ch) >= 0;

        if(Char.IsUpper(ch) && isVowel == true)
        {
            Console.WriteLine("This character is an uppercase vowel.");
        }
        else if(Char.IsUpper(ch) && isVowel == false)
        {
            Console.WriteLine("This character is an uppercase consonant.");
        }
        else if(Char.IsLower(ch) && isVowel == true)
        {
            Console.WriteLine("This character is a lowercase vowel.");
        }
        else if(Char.IsLower(ch) && isVowel == false)
        {
            Console.WriteLine("This character is an lowercase consonant.");
        }
        else if(Char.IsNumber(ch))
        {
            Console.WriteLine("This character is a digit.");
        }
        else
        {
            Console.WriteLine("This character is a symbol.");
        }
        Console.Read();
    }
}