using System;

public class FileTypeIdentifer
{
    public bool IsFileBinary(string filename)
    {
        Console.WriteLine("checking to see if the file is binary");
        List<char> f16 = GetFirst16(filename);
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

    private List<char> GetFirst16(string Filename)
    {
        string[] file = System.IO.File.ReadAllLines(Filename);
        
        List<char> f16 = new List<char>();
        int length = 0;
        while (length != 16)
        {
            foreach (string item in file)
            {
                char[] chara = item.ToCharArray();
                foreach (char part in chara)
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

    private bool IsStringBinary(List<char> f16)
    {
        int truecount = 0;
        bool answer = false;
        foreach (char item in f16)
        {
            if (item.ToString() == "1" | item.ToString() == "0")
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