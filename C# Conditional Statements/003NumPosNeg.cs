using System;

class NumPosNeg
{
    static void Main()
    {
        bool success = false;

        Console.Write("\nCheck whether a given number is positive or negative:\n");
        Console.Write("-----------------------------------------------------\n\n");

        while (!success)
        {
            try
            {
                Console.Write("Input a number: ");
                int num = Int32.Parse (Console.ReadLine());

                if (num > 0)
                {
                    Console.Write("{0} is a positive number", num);
                }
                else if (num < 0)
                {
                    Console.Write("{0} is a negative number", num);
                }
                else
                {
                    Console.Write("{0} is neither a positive nor negative number", num);
                }

                success = true;
            }
            catch (System.Exception)
            {               
                Console.Write("That is not a valid input\n");
            }
        }
        Console.Write("\n\nPress any key to exit");
        Console.ReadKey();     
    }
}