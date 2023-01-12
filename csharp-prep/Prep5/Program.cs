class Program
{   
    

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
                
        DisplayWelcome();

        string name = GetName();

        int number = GetFavoriteNumber();

        InfoSpitOut(name, number);
            

    }
    static void DisplayWelcome()
        {
            Console.WriteLine("welcome to my program!");
        }

    static string GetName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
            
        }
    static int GetFavoriteNumber()
        {
            Console.Write("Please enter your Favorite number: ");
            string number= Console.ReadLine();
            int intNumber = int.Parse(number);
            int sQRNumber = intNumber * intNumber;
            return sQRNumber;
            
        }

    static void InfoSpitOut(string name, int number)
        {
            Console.WriteLine($"{name} the sqare of your favorite number is {number}");
        }
    
    
}

