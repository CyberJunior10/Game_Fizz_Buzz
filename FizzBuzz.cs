using System;

namespace Game_Fizz_Buzz
{
    class Game_Fizz_Buzz
    {
        static void Main()
        {
            int dividedWithTree = 3;
            int dividedWithFive = 5;

            while (true)
            {
                Console.WriteLine("\nWelcome in Game Fizz Buzz !!!.\n");
                try
                {
                    Console.WriteLine("\nGive a number: \n");
                    var userNumber = int.Parse(Console.ReadLine());

                    if ((userNumber % dividedWithTree == 0) && (userNumber % dividedWithFive == 0))
                    {
                        Console.WriteLine("\n***  !!! FizzBuzz !!! ***, {0} is lucky number !.", userNumber);
                        break;
                    }

                    else if (userNumber % dividedWithTree == 0)
                    {
                        Console.WriteLine("\n--- Fizz ! ---. Close to lucky number.");
                    }
                    else if (userNumber % dividedWithFive == 0)
                    {
                        Console.WriteLine("\n--- Buzz ! --->. Close to lucky number.");
                    }
                    else //(userNumber !% dividedWithTree == 0) && (userNumber !% dividedWithFive == 0))
                    {
                        Console.WriteLine("\nInput number: {0}. Far to lucky number.", userNumber);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong data input.");
                }
            }
        }
    }
   
}
