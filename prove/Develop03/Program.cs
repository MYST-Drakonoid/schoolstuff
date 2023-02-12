using System;

class Program
{
    static void Main(string[] args)
    {
        //initial interface
        Console.WriteLine("welcome to the Scripture Memorizer,");
        Console.Write("please enter the Scripture reference: ");
        string reference = Console.ReadLine();
        Console.WriteLine("Please enter the scripture Text:");
        string scripture = Console.ReadLine();
        scriptureManager brkScrpt = new scriptureManager();
        List<string> brokenscripture = brkScrpt.ScriptureBreaker(scripture);

        List<int> numberList = brkScrpt.NumberList(brokenscripture);

        MemorizationTool memorytool = new MemorizationTool();

        MemorizationTool.memTool(numberList, brokenscripture, reference);
        

    }
}
class scriptureManager
{

    public List<string> ScriptureBreaker(string scripture)
    {
        //creates a list of the individual words within the scripture

        List<string> brokenScripture = new List<string>(scripture.Split(' '));

        // debugging tool
        // foreach (string r in brokenScripture)
        // {
        //     Console.Write(r);
        //     Console.Write(' ');
        // }
        // Console.WriteLine("");
        return brokenScripture;
    }

    public List<int> NumberList(List<string> ScriptureList)
    {
        //creates index for the scripture list in order
        //to keep the program from repeating numbers
        List<int> NumberList = new List<int>();
        int counter = 0;

        foreach (string item in ScriptureList)
        {
            counter += 1;
            NumberList.Add(counter);
        }

        //debug purposes
        // foreach (int r in NumberList)
        // {
        //     Console.WriteLine(r);
        // }
        return NumberList;
    }
}
public class MemorizationTool
    {
        public static void memTool(List<int> numlist, List<string> scripture, string scriptRef)
        {

            List<int> numlist1 = new List<int>();
            List<string> scripture1 = new List<string>();

            int continu = 0;
            if ((numlist.Count() == 0) )
            {
                continu = 2;
                Console.WriteLine("there are no more words to remove\n program will end upon pressing enter");
                while (Console.ReadKey().Key != ConsoleKey.Enter){}
                Console.Clear(); 
                
            }
            if (continu == 1)
            {
                Console.WriteLine("program will end upon pressing enter, thank you!");
                while (Console.ReadKey().Key != ConsoleKey.Enter){}
                Console.Clear();                
            }

            Console.Clear();
            Console.WriteLine("welcome to he memorization phase.\n every time the enter key is pressed ");
            Console.WriteLine(" a word will be removed from the verse.\n enter the word 'done' when you wish to quit");

            int fincount = 0;
            int wordcound = 0;

            while (continu == 0)
            {
                Console.WriteLine(scriptRef);

                fincount ++;

                foreach (string r in scripture)
                {
                    if (r == "________")
                    {
                        wordcound ++;
                    }
                    Console.Write(r);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");

                scripture1 = scripture;
                numlist1 = numlist;
                
                Console.WriteLine("double press enter to continue");
                lineClearer clear = new lineClearer();
                List<string> stuff = clear.stuff(); 


                
                //creates a waiting icon
                // do {
                //     foreach (string r in stuff)
                //     {
                //         Console.WriteLine("");
                //         Console.WriteLine(r);
                //         Thread.Sleep(500);
                //         lineClearer.ClearLastLine();
                //     }
                //     if (Console.ReadLine() == "")
                //     {
                //         break;
                //     }
                // } while (1 == 1);

                string input = Console.ReadLine();
                if (input == "done")
                {
                    continu = 1;
                }
                else if (Console.ReadLine() == "" && (Console.ReadKey().Key == ConsoleKey.Enter))
                {                }

                Console.Clear();

                (scripture, numlist) = clear.listModifier(scripture1, numlist1);

            }
        }
    }
    public class lineClearer
    {
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public List<string> stuff()
        {
            List<string> things = new List<string>();

            things.Add("--");
            things.Add("\\");
            things.Add("||");
            things.Add("//");
            return things;
        }

        public (List<string>, List<int>) listModifier(List<string> scripture, List<int> numList)
        {
            Random rnd = new Random();
            do {
            
            int index = rnd.Next(numList.Count());

            int index1 = numList[index];
            //recalls the index of the random number
            
            

            if (scripture[index1 - 1] != "________")
            {
            numList.Remove(index1 - 1);
            scripture[index1-1] = "________";
            return (scripture, numList);                
            }
            } while (1 ==1);


            //replaces the indexed word with underscores and removes the indexer number

            
        }
    }
