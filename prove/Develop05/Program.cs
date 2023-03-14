using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menulist = new List<string>();
        MainMenu mm = new MainMenu();
        
        SystCheck.syst();
        
        bool end = false;
        Console.WriteLine("welcome to the goalsetter program, please select an option");

        while (end == false)
        {
            Console.WriteLine("1. report goal");
            Console.WriteLine("2. create goal");
            Console.WriteLine("3. current score");
            Console.WriteLine("4. show goals");
            Console.WriteLine("5. save and end");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 1 )
            {
                mm.CreateFile();
            }
            else if (answer == 2)
            {
                ProgramBase task2 = new ProgramBase();
                task2.newFile("infoFile.txt");
            }
            else if (answer == 3)
            {
                scoreFinder task2 = new scoreFinder();
                string[] score = task2.Findpoints();
                Console.WriteLine($"your current score is {score[1]}");
            }
            else if (answer == 4)
            {
                listInfo show = new listInfo();
                show.ShowList();
            }
            else if (answer == 5)
            {
                Console.WriteLine("thank you and we hope to see you again!");
                end = true;
            }

        }


    }
}