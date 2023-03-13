using System;

class ProgramBase
{
    
    
    
    
    public virtual void SaveFile(string filename, int variable = 0, string saveItem = "none", bool completeditem = false )
    {
        string file1 = filename;
        while (filename == file1)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            File.Create(filename).Close();

            foreach (string line in lines)
            {

                string[] parts = line.Split(",");

                string eventName = parts[0];
                string score = parts[1];


                if (variable != 0)
                {
                    if (eventName == saveItem)
                    {
                        parts[1] = ($"{int.Parse(score)+variable}");
                    }
                }
              
            }

            
                
            
        }
    }

        public async void newFile(string infofile)
        {
           
            
                using (StreamWriter outputFile = new StreamWriter(infofile, append: true))
                {
                    string endless = "";
                    Console.WriteLine("what is the name of the goal?");
                    string newitem = Console.ReadLine();
                    Console.WriteLine("does this goal have an end? Y/N");
                    string endlessYN = Console.ReadLine();
                    if (endlessYN.ToLower() == "y")
                    {
                        endless = "egoal";
                    }
                    else 
                    {
                        Console.WriteLine("how many times does this goal need to be completed?");
                        endless = Console.ReadLine();
                    }
                    Console.WriteLine("how many points should this give you?");
                    string variable = Console.ReadLine();

                    if (endless == "1")
                    {
                        endless = "simple";
                    }

                    Console.WriteLine("");
                    await outputFile.WriteLineAsync(($"{newitem}, {variable}, 0, {endless}"));
                }
        }
    
    
    public virtual List<string> GetFileInfo(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<string> events = new List<string>();

        foreach (string item in lines)
        {
            events.Add(item);
        }
        return events;
    }

    public static void CreateInfoFile()
    {
        using (StreamWriter InfoFile = File.CreateText("infoFile.txt"))
        {
            InfoFile.WriteLine("running task, 100, 0, simple");
            InfoFile.WriteLine("scriptures, 200, 0, Egoal");
            InfoFile.WriteLine("attend temple, 700, 1, 7");
            
        }
    }
    public static void CreateScoreFile()
    {
        using (StreamWriter InfoFile = File.CreateText("scoreFile.txt"))
        {
            InfoFile.WriteLine("score, 0");
        }

    }
    
    
    }



