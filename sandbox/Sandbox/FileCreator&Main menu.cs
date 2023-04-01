

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

        Console.WriteLine("loading databases...");
        WaitAnimation();
        (textDB, numDB) = dataBase.ReadDatabase("binary letters.csv");

        Console.WriteLine("translating file...");
        WaitAnimation();
        translator.TranslateFile(filedata, textDB, numDB, binary);

    }

    public void WaitAnimation()
        {
            Console.Write("||");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("//"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("--"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("||");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("//"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("--"); 
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);

            Console.Write("\b \b");
        }
     
}