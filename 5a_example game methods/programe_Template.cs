using System;
// All examples provided. 
namespace MethodsParameters
{
    class MethodsParameters
    {
          //METHOD -- Named block of code, can be used over and over.
          // ALL methods have a SIGNATURE that defines their name, parameters, and 
          // Example Signature
          static void myMethod()
          {
        Console.WriteLine("I like mine with lettuce and tomatoes, heinz 57, and frenc fried potatoes.\n");
          } 
        
        
        
        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("this method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum;
        }
        
        
        static void MakePancakes(int num) 
        { 
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("one golden, Fluffy pancake coming up!\n");
            }

        }
        
        static void MakeEggs(int num, string style)
        {   
            Console.WriteLine("you have orrdered" + num + "eggs cooked" + style + ".\n");
        }
        
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("i am going to cook " + num + "hamburgers.\n");
        }
        
        static void AllMyChildren(string child1, string child2, string child3)
        {
             Console.WriteLine("my favorite child is " + child3);
        }
        
        
        
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: "+ sum);
            return sum;
        }


        static double FindSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: "+ sum);
            return sum;
        }

        
        static void Main(string[] args)
        {
            //myMethod();
            //DoubleUp();
            //MakePancakes();
            //MakeEgges(10."sunny side up");
            //MakeBurger();
            //MakeBurger(10);
            //AllMyChildren(child3: "steve", child2: "susan", child1: "chewbaca");
            FindSum(1,5);
            FindSum(9.5,2.4);
            FindSum(5,2.5);

            
        }
    }
}