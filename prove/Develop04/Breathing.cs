using System;
public class Breathing : Base
    {
        
        public void BreathingTask()
            {
                Console.WriteLine("this task is intended to help you find peace in the moment and practice breathing");
                int iterations = base.HowLong(4);
                Console.WriteLine("the program will show instructions to breath in and to breath out.");
                Console.WriteLine("clear your mind and just follow the instructions as they appear.");
                WaitAnimation();

                while (iterations != 0)
                {
                    Console.Clear();
                    Console.Write("breath in... ");
                    WaitAnimation();
                    Console.Write("breath out... ");
                    WaitAnimation();

                    iterations = iterations - 1;

                }
            }
    }