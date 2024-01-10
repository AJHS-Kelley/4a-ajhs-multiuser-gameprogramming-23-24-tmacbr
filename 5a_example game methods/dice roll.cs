
using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM

    {
        static int DiceRoll(int numRolls, int maxRoll)
        {
            Random random = new Random();
            int playerRandomNum = 0;
            
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

        static int DiceChances(int amount)
        {
           
            float wins = 0;
            float losses = 0;
            string[] goodLuck = {"good try", "better luck next time", "keep going"};
            //string[] hello = {"hi", "sup", "blah"};
            
            //Console.WriteLine(hello[0]);
            
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
                    
                    if (roll == 4)
                    {
                        Random random = new Random();
                        int playerRandomNum = random.Next(1,4);
                        Console.WriteLine(goodLuck[playerRandomNum]);
                    }
                }
            }
            Console.WriteLine("wins: " + wins);
            Console.WriteLine("losses: " + losses);
            Console.WriteLine("amount: " + amount);
            float winRatio = 0.0F;
            float lossRatio = 0.0F;
            
        
            lossRatio = (float)(losses /amount) *  100; 
            winRatio = (float)(wins /amount) *  100; 
            Console.WriteLine(winRatio);
            Console.WriteLine(lossRatio);
            Console.WriteLine(winRatio + "% - " + lossRatio + "%");
            
            return 2;
            // wins divided by losses to give you your win per
        }
        
        
        static void Main(string[] args)
        {
            DiceChances(100);
            // DiceRoll(6,8);
        }
    }
}

// Code Review by Ryan Kelley`