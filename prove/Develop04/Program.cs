using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        bool quit = false;

        Console.WriteLine("welcome to the wellness activity! Here you will have");
        Console.WriteLine("several options for activitiers desogned to encourage wellness.");
        Base menu = new Base();


        while (quit == false)
        {
                menu.MenuList();
                Console.Write(">>>");
                string userInput = Console.ReadLine();

                if (userInput  == "quit")
                {
                    quit = true;
                }

                if (userInput == "1")
                {
                    Breathing task1 = new Breathing();
                    task1.BreathingTask();
                }
                else if (userInput == "2")
                {
                    reflection task3 = new reflection();
                    task3.reflectiontask();
                }
                else if (userInput == "3")
                {
                    Listing task3 = new Listing();
                    task3.ListingTask();
                }
                else if (userInput == "4")
                {
                    WritingTask task4 = new WritingTask();
                    task4.WritingHelp();
                }
        }

        Console.WriteLine("thank you for taking time to take care of yourself!!");
    }
}