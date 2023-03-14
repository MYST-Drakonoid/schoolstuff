using System;
using System.IO;

class reportScore : ProgramBase
{
    public int reporter(string filename, string completeditem)
    {
        string file1 = filename;
        string goodScore = "null";
        int variable = 0;
        int scorenum = 0;
        string completeditem1 = completeditem.ToLower();
        while (filename == file1)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            string[] totalScore = System.IO.File.ReadAllLines("scoreFile.txt");
            string[] total1 = totalScore[0].Split(",");

            
            
            foreach (string line in lines)
            {

                string[] parts = line.Split(",");

                string eventName = parts[0].ToLower();
                string score = parts[1];

                
                if (variable != -1)
                {
                    if (eventName == completeditem1)
                    {
                        parts[2] = ($"{int.Parse(score)+int.Parse(total1[1])}");
                        goodScore = parts[2];
                        scorenum = int.Parse(parts[1]);

                        Console.WriteLine($"Congragulations you have earned {scorenum} points!");

                        using (StreamWriter scoreFile = new StreamWriter(@"D:\sem 4\schoolstuff\prove\Develop05\scoreFile.txt", append : false))
                        {
                            scoreFile.WriteLineAsync($"score, {goodScore}");
                        }

                    }
                }
              
            }
            
            break;
            
            

        }
        return scorenum;
    }   
}

class listInfo : ProgramBase
{
    public void ShowList()
    {
       List<string> info = GetFileInfo("infoFile.txt");
       foreach (string item in info)
       {
        string[] fullLine = item.Split(",");
        string head = fullLine[0];
        string tail = fullLine[1];
        
        Console.WriteLine($"{head}: worth {tail} points");
       }
    }
}