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

