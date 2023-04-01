using System;

public class DataBaseReader
    {
         public (List<string>, List<string>) ReadDatabase (string FileDB)
         {
            string[] lines = System.IO.File.ReadAllLines(FileDB);
            List<string> textDB = new List<string>();
            List<string> numDB = new List<string>();
            foreach (string line in lines)
            {
                string[] splitdb = line.Split(",");
                textDB.Add(splitdb[0]);
                numDB.Add(splitdb[1]);
            }
            return (textDB, numDB);

         }
 
    }

