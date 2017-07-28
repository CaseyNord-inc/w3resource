using System;

class LeapYearCalc
{
    static void Main()
    {
        int output;

        bool isLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Console.Write("\nCalculates if a year is a leap year:\n");
        Console.Write("------------------------------------\n\n");

        Console.Write("Input a year: ");
        
        while (!Int32.TryParse(Console.ReadLine(), out output))
        {
            Console.Write("That is not a valid input. Please try again: ");
        }

        if(isLeapYear(output) == true)
        {
            Console.Write("{0} is a leap year\n\n", output);
        }
        else
        {
            Console.Write("{0} is not a leap year\n\n", output);
        }
        Console.Write("Press any key to exit");
        Console.ReadKey();
    }
}