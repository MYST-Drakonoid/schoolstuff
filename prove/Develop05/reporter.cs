using System;

class reportScore : ProgramBase
{
    public int reporter(string filename, string completeditem)
    {
        string file1 = filename;
        int variable = 1;
        int scorenum = 0;
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
                    if (eventName == completeditem)
                    {
                        parts[2] = ($"{int.Parse(score)+variable}");
                        scorenum = int.Parse(parts[1]);
                    }
                }
              
            }
            foreach (string item in lines)
            {
                using (StreamWriter outputFile = new StreamWriter(filename, append: true))
                {
                    outputFile.WriteLine(item);
                }
                
            }
            break;
            
            

        }
        return scorenum;
    }   
}