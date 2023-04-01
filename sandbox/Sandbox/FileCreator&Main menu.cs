

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
        Console.WriteLine("file has been translated. will be located where you stored the original file");
    }

    public void WaitAnimation()
        {
            Console.Write("||");

            Thread.Sleep(500);

            ClearCurrentConsoleLine();
            Console.Write("//"); 
            Thread.Sleep(500);

            ClearCurrentConsoleLine();
            Console.Write("--"); 
            Thread.Sleep(500);

            ClearCurrentConsoleLine();
            Console.Write("\\");
            Thread.Sleep(500);

            ClearCurrentConsoleLine();
            Console.Write("||");

            Thread.Sleep(500);

            ClearCurrentConsoleLine();
            Console.Write("//"); 
            Thread.Sleep(500);

            ClearCurrentConsoleLine();
            Console.Write("--"); 
            Thread.Sleep(500);

            ClearCurrentConsoleLine();
            Console.Write("\\");
            Thread.Sleep(500);

            ClearCurrentConsoleLine();
        }
        public static void ClearCurrentConsoleLine()
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth)); 
                Console.SetCursorPosition(0, currentLineCursor);
            }
     
}