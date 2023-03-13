using System.IO;
using System;

class MainMenu : ProgramBase
{
    public void CreateFile()
    {
        string infofilename = "infoFile.txt";
        string scoreFile = "scoreFile.txt";

        if (File.Exists(infofilename) == false)
        {
            CreateInfoFile();

        }
        if (File.Exists(scoreFile) == false)
        {
            CreateScoreFile();
        }
        ProgramBase info = new MMinfo();
        List<string> infolist = info.GetFileInfo("infoFile.txt");

        int number = 1;
        Console.WriteLine("please enter the goal you would like to report as finished");
        foreach (string item in infolist)
        {
            Console.WriteLine($"{number}. {item}");
            number ++;
        }
        int answer = int.Parse(Console.ReadLine()) -1;



        reportScore task1 = new reportScore();
        string reportedScore = infolist[answer];
        string[] modscore = reportedScore.Split(",");
        reportedScore = modscore[0];
        int returnedscore = task1.reporter("infoFile.txt", reportedScore);
        SaveFile(scoreFile, returnedscore);
    }

    
}
class MMinfo : ProgramBase
{
    public override List<string> GetFileInfo(string fileName)
    {
        List<string> events = GetFileInfo("infoFile.txt");
        List<string> MMinfo = new List<string>();
        foreach (string item in events)
        {
        string[] parts = item.Split(",");
        MMinfo.Add($"{parts[0]}, {parts[2]}");
        }
        return MMinfo;
    }
}