
using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM

    {
        static int DiceRoll(int numRolls, int maxRoll)
        {
            Random random = new Random();
            int playerRandomNum = random.Next(1,7);
            
            string text = "hello welcome to dice roll";
            Console.WriteLine(text);
            for (int i = 0; i < numRolls; i++)
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
           
            int wins = 0;
            int losses = 0;
            
            for (int i = 0; i < amount; i++)
            {
                int roll = DiceRoll(1,8);
                if (roll == 8) 
                {
                    Console.WriteLine(" you have won!!");
                    wins++;
                    
                }
                else if (roll != 8)
                {
                    Console.WriteLine(" you lose, go home!!");
                    losses++;
                    
                }
            }
            Console.WriteLine("wins: " + wins);
            Console.WriteLine("losses: " + losses);
            Console.WriteLine("amount: " + amount);
            double winRatio = 0.0;
            double lossRatio = 0.0;
            winRatio = 100;
            lossRatio = (losses/amount) * 100;
            Console.WriteLine(winRatio);
            Console.WriteLine(lossRatio);
            Console.WriteLine(winRatio + "% - " + lossRatio + "%");
            
            return wins;
            // wins divided by losses to give you your win per
        }
        
        
        static void Main(string[] args)
        {
            MethodThree(10);
            // DiceRoll(6,8);
        }
    }
}

// Code Review by Ryan Kelley`