public class FileCreator
{
    public void CreateFile(string filename)
    {

    }


}

public class MainMenu
{
    public void Startup()
    {
        DataBaseReader dataBase = new DataBaseReader();
        Translator translator = new Translator();
        FileTypeIdentifer FTI = new FileTypeIdentifer();

        string filedata;
        bool binary = true;
        List<string> DB = new List<string>();
        








        
        Console.WriteLine("please enter the file that you wish to be translated");
        filedata = Console.ReadLine();
    }

     
}