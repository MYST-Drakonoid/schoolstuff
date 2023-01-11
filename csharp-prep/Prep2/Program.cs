using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("what is the grade you recieved? ");
        string grade = Console.ReadLine();

        int intGrade = int.Parse(grade);

        string finalGrade = "";

        if (intGrade >= 93)
        {
            finalGrade = ("A");
        }
        else if (intGrade >= 90)
        {
            finalGrade = ("A-");
        }
         else if (intGrade >= 87)
        {
            finalGrade = ("B+");
        }
         else if (intGrade >= 83)
        {
            finalGrade = ("B");
        }
         else if (intGrade >= 80)
        {
            finalGrade = ("B-");
        }
         else if (intGrade >= 77)
        {
            finalGrade = ("C+");
        }                 
        else if (intGrade >= 73)
        {
            finalGrade = ("C");
        }
        else if (intGrade >= 70)
        {
            finalGrade = ("C-");
        }
        else if (intGrade >= 67)
        {
            finalGrade = ("D+");
        }
        else if (intGrade >= 63)
        {
            finalGrade = ("D");
        }
        else if (intGrade >= 60)
        {
            finalGrade = ("D-");
        }
        else if(intGrade <= 59)
        {
            finalGrade = ("F");
        }


        Console.WriteLine($"your grade was {finalGrade}");
        

        if (intGrade >= 70)
        {
          Console.WriteLine("You Passed!! Congratulations!!");  
        }
        else 
        {
            Console.WriteLine("You Did Not Pass. Study and you will do better next time.");
        }
    }

}