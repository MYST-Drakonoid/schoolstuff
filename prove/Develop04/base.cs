using System;

public class Base
    {

        protected bool quit = false;
        protected bool taskComplete = false;
        string userInput = "";
        public void MainMenu()
        {
            while (quit == false)
            {

                

                
            }
        }

        public void MenuList()
        {
            Console.WriteLine("Please select a number from the following menu options");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Writing");            
        }

        public void WaitAnimation()
        {
            Console.Write("||");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("//"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("--"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("||");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("//"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("--"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);

            Console.Write("\b \b");
        }

        public int HowLong(int periods)
        {
            Console.WriteLine("how many iterations of this activity would you like to participate in?");
            Console.WriteLine($"each iteration lasts {periods} seconds");
            int length = int.Parse(Console.ReadLine());
            return length;
        }

    }