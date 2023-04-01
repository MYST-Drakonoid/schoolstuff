using System;

public class DataBaseReader
    {
         public (List<string>, List<int>) ReadDatabase (string FileDB)
         {
            string[] lines = System.IO.File.ReadAllLines(FileDB);
            List<string> textDB = new List<string>();
            List<int> numDB = new List<int>();
            foreach (string line in lines)
            {
                string[] splitdb = line.Split(",");
                textDB.Add(splitdb[0]);
                string num = splitdb[1];
                numDB.Add(int.Parse(num));
            }
            return (textDB, numDB);

         }
 
    }

