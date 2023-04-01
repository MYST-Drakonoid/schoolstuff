using System;

public class Translator
{
    public void TranslateFile(string fileinfo, List<string> textDB, List<int> numDB, bool binarycondition)
    {
        if (binarycondition == true)
        {
            TranslateBinary(fileinfo, textDB, numDB);
        }
        else
        {
            TranslateText(fileinfo, textDB, numDB);
        }
    }


    private void TranslateBinary(string fileinfo, List<string> textDB, List<int> numDB) 
    {
        string result;
        string[] TeilFile;
        string[] filefull = System.IO.File.ReadAllLines(fileinfo);
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: false))
        {
            translatedFIle.WriteLine("translated Binary file");
            translatedFIle.WriteLine("");
        }
        int count = 0;
        
           foreach (string tiel in filefull)
           {
            TeilFile = tiel.Split();
            

            foreach (string teil in TeilFile)
            {
                int indx;

                if (teil == "00100000")
                {
                    result = " ";
                }
                else if(teil == "")
                {
                    result = null;
                }
                else
                {
                    indx = numDB.IndexOf(int.Parse(teil));
                    result = textDB[indx];
                }

                
                if (result == null)
                {
                    //dont do a gosh darn thing
                }
                else if(count < 50)
                {
                    SW_write(result);
                    count ++;
                }
                else if (count >= 50 && result == " ")
                {
                    SW_writeline();
                    count = 0;
                }
                else if (count >= 50 && result != " ")
                {
                    SW_write(result);
                }

            }
           }
           
    }

    private void TranslateText(string fileinfo, List<string> textDB, List<int> numDB)
    {
        int result;
        int count = 0;
        string[] filefull = System.IO.File.ReadAllLines(fileinfo);
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: false))
        {
            translatedFIle.WriteLine("translated binary file");
            translatedFIle.WriteLine("");
        }
            foreach (string teil in filefull)
            {
                string[] teilfile = teil.Split();

                foreach (string word in teilfile)
                {   
                    count = count;
                    char[] charteil = word.ToCharArray();

                    foreach (char letter in charteil)
                    {
                        int indx = textDB.IndexOf(letter.ToString());
                        result = numDB[indx];

                        if (count != 8)
                        {
                            SW_write($"{result} ");
                            count ++;
                        }
                        else
                        {
                            SW_writeline($"{result} ");
                            count = 1;
                        }
                    }
                    if (count != 8)
                    {
                        SW_write("00100000 ");
                        count ++;
                    }
                    else
                    {
                        SW_writeline("00100000 ");
                        count = 1;
                    }
                }

            }
        }
       
    

    
     void SW_write(string text = "")
    {
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: true))
            {
                translatedFIle.Write(text);
            }
    }
     void SW_writeline(string text = "")
    {
        using (StreamWriter translatedFIle = new StreamWriter("TranslatedFile.txt", append: true))
            {
                translatedFIle.WriteLine(text);
            }
    }
}



