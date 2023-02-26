using System;

public class reflection : Base
    {

        public void reflectiontask()
        {

        List<string> prompts = new List<string>(); //("did you feel the spirit today, if so how?", "did you do any good in the world today?", "what are people that you appreciate?");
        prompts.Add("did you feel the spirit today, if so how?");
        prompts.Add("did you do any good in the world today?");
        prompts.Add("what are people that you appreciate?");
        
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience."); 
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life");
        int iterations = HowLong(8);

        List<string> answers = new List<string>();
        
        WaitAnimation();

        DateTime startTime = DateTime.Now;
        DateTime FutureTime = startTime.AddSeconds(iterations * 8);


        DateTime CurrentTime = DateTime.Now;
        List<string> listing = new List<string>();

        foreach (string item in prompts)
        {
        while (CurrentTime < FutureTime)
        {
            CurrentTime = DateTime.Now;
            Console.WriteLine(item);
        }
        }
        Console.Write("please enter a filename: ");
        string filename = Console.ReadLine();
        textFile(filename, listing);
        }
    }