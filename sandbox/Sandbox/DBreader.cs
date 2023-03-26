using System;

public class DataBaseReader
    {
         public List<string> ReadDatabase (string FileDB)
         {
            string[] lines = System.IO.File.ReadAllLines(FileDB);
            List<string> MainDB = new List<string>();
            foreach (string line in lines)
            {
                MainDB.Add(line);
            }
            return MainDB;
         }
 
    }

public class Charactor
{

    string symbol(string text, bool Binary)
    {
        if (Binary == true)
        {
            
        }
        return null;
    }
    string Binary(string numbers)
    {
        
        return null;
    }
}