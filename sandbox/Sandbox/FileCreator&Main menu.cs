

public class MainMenu
{
    public void Startup()
    {
        DataBaseReader dataBase = new DataBaseReader();
        Translator translator = new Translator();
        FileTypeIdentifer FTI = new FileTypeIdentifer();

        string filedata;
        bool binary = true;
        List<string> textDB = new List<string>();
        List<int> numDB = new List<int>();
        
        Console.WriteLine("please enter the file, with file extension, that you wish to be translated");
        filedata = Console.ReadLine();
        binary = FTI.IsFileBinary(filedata);
        (textDB, numDB) = dataBase.ReadDatabase("binary letters.csv");
        translator.TranslateFile(filedata, textDB, numDB, binary);

    }

     
}