using System;
using System.IO;
// what i did to exceed the requirements was add an exeption handler to the file as well as looping variables to keep the program running until the user decides to quit. 
// i also added code that handles the adding of the .exe to the end of filenames. i compiled the code for loading the file and creating the file into one class for the most part as well





class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Develop02 World!");
        MenuUI mainmenu = new MenuUI();

        mainmenu.mainMenu();
    }
}
    class MenuUI
{

    // pulling methods and variables


    //Beginning menu
    public void mainMenu()
    {
        int userInput = 0;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        CreateEntry opt1 = new CreateEntry();
        LoadEntry opt2 = new LoadEntry();
        DisplayEntry opt3 = new DisplayEntry();

        //main menu
        while (userInput != 4)
        {

            Console.WriteLine("please enter a Selection:");
            Console.WriteLine("1.Create New entry");
            Console.WriteLine("2.Load entry");
            Console.WriteLine("3.Display entry");
            Console.WriteLine("4.quit");

            while (userInput != (4))
                {
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput == 1)
                    {
                        opt1.entryCreation(dateText);
                        break;
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("please enter the filename without the .EXE extension");
                        string input2 = Console.ReadLine();
                        string input2_1 = ($"{input2}.exe");
                        opt2.LoadingEntry(dateText, input2_1);
                        break;
                    }
                    else if (userInput == 3)
                    {
                        
                        
                        
                        opt3.displayingEntry();
                        break;
                    }
                    else if (userInput == 4)
                    {
                        Console.WriteLine("thank you for using this program!");
                        break;
                    }
                }

            
        }

        

    }
}
public class PromptGenerator
    {

    public string PromptGeneratorFunction()
    {
        string filename = "prompts.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        Random rnd = new Random();
        int num = rnd.Next(6);
        string genPrompt = lines[num];
        return genPrompt;
    }
    }

public class CreateEntry
    {


        public void entryCreation(string date, int foundFileName = 0, string fileName = "")
        {
            int continu = 1;
            if (foundFileName == 1)
            {
                Console.WriteLine($"would you like to edit this file? {fileName}");
                string Tempinput = Console.ReadLine();
                if (Tempinput == "n")
                {
                     continu = 0;
                }
            }
            continu = 1;
            while (continu == 1)
           {
            Console.WriteLine("do you want a prompt? y/n");
            string userInput = Console.ReadLine();

            if (userInput == "y")
            {
                PromptGenerator prompt = new PromptGenerator();
                string request = prompt.PromptGeneratorFunction();
                Console.WriteLine(request);
            }
        
            Console.WriteLine("type here to add to your journal, press enter to get new prompt and or save.");

            string entry = Console.ReadLine();

        

            
            string fileName1 = "";

            if ((foundFileName == 0)&& (entry != ""))
            {
                Console.WriteLine("where do you want to save this file? (input filename if it already exists");
                Console.WriteLine("!!DO NOT ADD THE .exe EXTENSION!!");
                fileName = Console.ReadLine();
                fileName1 = ($"{fileName}.exe");
                foundFileName = 1;
                
                
            }
            if (entry != "")
            {
                using (StreamWriter outputFile = new StreamWriter(fileName1))
            {
                outputFile.WriteLine($"{date}---{entry}");

            }
            }
            Console.WriteLine("do you wish to continue? y/n");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                continu = 0;
            }
            
            }
        }
    }
public class LoadEntry
        {
            public void LoadingEntry(string date, string filename)
            {
                CreateEntry readEntry = new CreateEntry();
                readEntry.entryCreation(date, 1, filename);
            }
        }
public class DisplayEntry
        {
            public void displayingEntry()
            {
                int tryAgain = 0;

                while(tryAgain == 0)
                {
                try
                {
                Console.WriteLine("please enter the filename without the .EXE extension");
                string input3 = Console.ReadLine();
                string input3_1 = ($"{input3}.exe");

                string[] inputFile = System.IO.File.ReadAllLines(input3_1);
                foreach (string line in inputFile)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("open another file? y/n");
                string answer = Console.ReadLine();
                if (answer == "n")
                    {
                        tryAgain = 1;
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("file not found try again? y/n");
                    string answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        tryAgain = 1;
                    }
                }
                }
            }
        }
    

