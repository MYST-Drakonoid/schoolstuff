using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string continueInput = "no";
        int finished = 0;


         Random randomGenerator = new Random();
         int randomNum = randomGenerator.Next(1, 20);
        



        do 
        {


            Console.Write("please guess a number between 1 and 20: ");
            string userInput = Console.ReadLine();
            int intUserInput = int.Parse(userInput);


            if (intUserInput == randomNum)
                {
                    Console.WriteLine("Correct!");
                    finished = 20;
                }
            else if (intUserInput < randomNum)
                {
                    Console.WriteLine("too low, guess again.");
                }
            else if (intUserInput > randomNum)
                {
                    Console.WriteLine("too high, guess again.");
                }
            if (finished < 2)
            {
                Console.Write("would you like to try again?: ");
                continueInput = Console.ReadLine();
                if (continueInput == "no")
                    {
                        finished = 20;
                        Console.WriteLine("Thank you for playing! Game Over");
                    }
            }

        } while (finished < 2);
    }
}