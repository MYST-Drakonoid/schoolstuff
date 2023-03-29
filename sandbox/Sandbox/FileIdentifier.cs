using System;

public class FileTypeIdentifer
{
    public bool IsFileBinary(string filename)
    {
        Console.WriteLine("checking to see if the file is binary");
        List<string> f16 = GetFirst16(filename);
        Console.WriteLine("obtained first 16 characters, processing info...");
        bool result = IsStringBinary(f16);
        string entry = "";
        if (result == true)
        {
            entry = "binary";
        }
        else
        {
            entry = "text";
        }
        Console.WriteLine($"the text file is in {entry}");
        return result;
    }

    private List<string> GetFirst16(string Filename)
    {
        string[] file = System.IO.File.ReadAllLines(Filename);
        
        List<string> f16 = new List<string>();
        int length = 0;
        while (length != 16)
        {
            foreach (string item in file)
            {
                string[] chara = item.Split();
                foreach (string part in chara)
                {
                    if (length != 16)
                    {
                        f16.Add(part);
                        length ++;

                    }

                }
            }
        }
        return f16;
    }

    private bool IsStringBinary(List<string> f16)
    {
        int truecount = 0;
        bool answer = false;
        foreach (string item in f16)
        {
            if (item == "1" | item == "0")
            {
                truecount ++;
            }
        }    
        if (truecount == 16)
        {
            answer = true;
        }
        return answer;
    }
}