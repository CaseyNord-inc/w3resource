using System;

class Exercise03
{
    static void Main()
    {
        Console.Write("Enter userid: ");
        Console.ReadLine();
        
        Console.Write("Enter password: ");
        string try1 = Console.ReadLine();
        
        if(try1 == "password")
        {
            Console.WriteLine("Acces Granted!");
            Console.ReadLine();
        }
        else
        {
            Console.Write("Password incorrect, please try again: ");
            string try2 = Console.ReadLine();
            
            if(try2 == "password")
            {
                Console.WriteLine("Acces Granted!");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Password incorrect, one try remaining: ");
                string try3 = Console.ReadLine();
                
                if (try3 == "password")
                {
                    Console.WriteLine("Acces Granted!");
                    Console.ReadLine();
                }
                else
                {                    
                    Console.WriteLine("Access Denied");
                    Console.ReadLine();    
                }
            }
        }
    }
}