using System;

class WritingTask : Base
    {
        public void WritingHelp()
            {
                Console.WriteLine("the idea of this task is to allow you to write out frustrations of your day");
                Console.WriteLine("please write all your frustrations, when you are finished please push enter and the purging");
                Console.WriteLine("process will begin");
                
                base.WaitAnimation();

                Console.Write("please write here:");
                string entree = Console.ReadLine();

                Console.WriteLine("your fustrations are now being burned away.");
                base.WaitAnimation();
                entree = "";
            }
    }