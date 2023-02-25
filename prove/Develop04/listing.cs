using System;
public class Listing : Base
    {
        
        public void ListingTask()
            {
                Console.WriteLine("This task will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                int iterations = base.HowLong(8);
                
                Console.WriteLine("the program will show instructions to breath in and to breath out.");
                Console.WriteLine("clear your mind and just follow the instructions as they appear.");
                base.WaitAnimation();
                DateTime startTime = DateTime.Now;
                DateTime FutureTime = startTime.AddSeconds(iterations * 8);


                DateTime CurrentTime = DateTime.Now;
                List<string> listing = new List<string>;
                while (CurrentTime != FutureTime)
                {
                    CurrentTime = DateTime.Now;
                    Console.Write(">>>");
                    listing.Add(Console.ReadLine());
                }
            }
    }