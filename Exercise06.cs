using System;

public class Exercise06
{
   public static void Main(string[] args)
   {
      int number1, number2, number3;
      Console.Write("\nInput the first number to multiply : ");
      number1 = int.Parse(Console.ReadLine());
      Console.Write("\nInput the second number to multiply : ");
      number2 = int.Parse(Console.ReadLine());
      Console.Write("\nInput the third number to multiply : ");
      number3 = int.Parse(Console.ReadLine());
      
      int number4 = number1 * number2 * number3;
      Console.Write("\nThe factor of these numbers is : "+number4);
      Console.Read();         
   }
}