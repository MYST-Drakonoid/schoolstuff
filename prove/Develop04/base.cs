using System;

class Base
    {

        protected bool quit = false;
        string userInput = "";
        public void MainMenu()
        {
            while (quit == false)
            {
                MenuList();
                Console.Write(">>>");
                userInput = Console.ReadLine();

                
            }
        }

        static void MenuList()
        {
            Console.WriteLine("Please select a number from the following menu options");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Writing");            
        }

        static void WaitAnimation()
        {
            Console.Write("||");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("//"); // Replace it with the - character
            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("--"); // Replace it with the - character
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);

            Console.Write("\b \b");
        }
    }