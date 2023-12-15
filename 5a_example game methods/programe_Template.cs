
using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM

    {
        static int DiceRoll(int amount, int maxRoll)
        {
            Random random = new Random();
            int playerRandomNum = random.Next(1,7);
            
            string text = "hello welcome to dice roll";
            Console.WriteLine(text);
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("press any key to roll the dice if you dare!");
            
                Console.ReadKey(); 
                // Code here to roll dice.  
                Console.Clear();

                playerRandomNum = random.Next(1,maxRoll + 1);
                Console.WriteLine("you rolled a " + playerRandomNum);
                //  code here will be run length times
            }
            return playerRandomNum;
        }
        

        static void MethodTwo()
        {
            // you made it to the next level!!
        }

        static int MethodThree(int amount)
        {
            int roll = DiceRoll();
            int wins = 0;
            int losses = 0;
            
            for (int i = 0; i < amount; i++)
            {
                if (roll = 8) 
                {
                    Console.WriteLine(" you have won!!");
                    wins++;
                }
                else if (roll = 1)
                {
                    Console.WriteLine(" you lose, go home!!");
                }
            }
            // wins divided by losses to give you your win per
        }
        
        
        static void Main(string[] args)
        {
            DiceRoll(6,8);
            string[] billy = ["billy", "billy 2"];
            int[] winsLosses = [17, 24, 99];
        }
    }
}

// Code Review by Ryan Kelley`
