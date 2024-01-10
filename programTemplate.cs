using System; 

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring and assigning variables 
            // interger -- -2,147,483
            int MyInt = 5;
            //long = 8 bites
            long myLong = 1928742747637362;
            // Float
            float myyFloat = 3.14F;
            // double = 8 bytes 
            double myDouble = 9.12345678912345D;
            //Boolean = 1 bit 
            bool myBool = true; 
            // string
            // 2 bytes oer character
            // must be in double quotes ""
            string myString = "peanut Butter Jelley Time;"


            char myChar = 'c';

            // Type casting 
            // Implict -- happens automatically when going smaller -> Larger
            // char -> int -> long -> float -> double
           int myInt = 9;
           myDouble = myInt;
           Console.WriteLine(myDouble);
           
           
            // explict -- must be done manually when going larger -> smaller. 
            // double -> float -> long -> intr -> char 
            
            double exampleDouble = 9.756312345D;
            int myInt = (int) myDouble;
            
            
            Convert.Tostring() 
            Convert.ToDouble()
            Convert.Toint32()
            Convert.ToInt64()


            //switch statement 
            int dayofWeek = 5; 
            switch (dayofWeek)
            {
                case 1: 
                Console.WriteLine("the day is sunday.\n")
                break; 
                case 2: 
                Console.WriteLine("the day is monday.\n")
                break:
                case 3: 
                Console.WriteLine("the day is tuesday.\n")
                break:
                case 4: 
                Console.WriteLine("the day is wednesday.\n")
                break: 
                case 5: 
                Console.WriteLine("the day is thursday.\n")
                break:
                case 6: 
                Console.WriteLine("the day is friday.\n")
                break:
                case 7: 
                Console.WriteLine("the day is saturday.\n")
                break:
            }
            
            
        }
    }
}