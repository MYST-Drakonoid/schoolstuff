using System;

public class Translator
{
    public void TranslateFile(string fileinfo, List<string> DB, bool binarycondition)
    {
        if (binarycondition == true)
        {
            TranslateBinary(fileinfo, DB);
        }
        else
        {
            TranslateText(fileinfo, DB);
        }
    }


    private void TranslateBinary(string fileinfo, List<string> DB) 
    {
        string[] filefull = System.IO.File.ReadAllLines(fileinfo);
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: false))
        {
            translatedFIle.WriteLine("translated Binary file");
            translatedFIle.WriteLine("");
        }
        int count = 0;
        
            foreach (string thing in filefull)
            {
                string[] file = thing.Split();
                
                foreach (string item in file)
                {
                    string TranslateResult = "";
                    if (item == "00100000")
                    {
                        SW_write(" ");
                    }
                    else {
                    foreach (string data in DB)
                    {
                        string[] SplitData = data.Split(",");
                        if (SplitData[1] == item)
                        {
                            TranslateResult = SplitData[0];
                        }
                    }
                    if (count < 50)
                    {
                        SW_write(TranslateResult);
                        count ++;
                    }
                    else if (count >= 50 && TranslateResult == " ") 
                    {
                        SW_writeline(TranslateResult);
                        count = 1;
                    }
                    else if (count >= 50 && TranslateResult != " ")
                    {
                        SW_write(TranslateResult);
                        count ++;
                    }
                
                }}}
    }

    private void TranslateText(string fileinfo, List<string> DB)
    {
        string[] filefull = System.IO.File.ReadAllLines(fileinfo);
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: false))
        {
            translatedFIle.WriteLine("translated text file");
            translatedFIle.WriteLine("");
        }
        string[] file;
        foreach (string thing in filefull)
        {
            file = thing.Split();
        
            int count = 0;
            foreach(string item in file)
            {
                string translateResult;
                
                char[] splitWord = item.ToCharArray();
                foreach (char part in splitWord)
                {
                    foreach (string data in DB)
                    {
                        string[] SplitData = data.Split(",");
                        char[] datapart = SplitData[0].ToCharArray();
                        if (SplitData[0] == item)
                        {
                            translateResult = SplitData[1];
                        
                        
                
                if (count != 8)
                {
                    SW_write($"{translateResult} ");
                    
                    count ++;
                }
                else
                {
                    SW_writeline($"{translateResult} ");
                    
                    count = 1;
                }
                    }
                    
                    SW_write("00100000 ");
                    count ++;
                    }
                
            }
            }
    }

    }
     void SW_write(string text)
    {
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: true))
            {
                translatedFIle.Write(text);
            }
    }
     void SW_writeline(string text)
    {
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: true))
            {
                translatedFIle.WriteLine(text);
            }
    }

}

