using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM

    {
        static void MethodOne()
        {
            Random random = new Random();
            int playerRandomNum = random.Next(1,7);
            
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll the dice if you dare!");
            
                if (Console.ReadKey() == true) {
                    // Code here to roll dice.  
                }

                playerRandomNum = random.Next(1,7);
                Console.WriteLine("you rolled a " + playerRandomNum);
                //  code here will be run length times
            }
        }
        Console.Readkey();

        static void MethodTwo()
        {

        }

        static int ()
        {


        }

            
        
    }
}

// Code Review by Ryan Kelley`