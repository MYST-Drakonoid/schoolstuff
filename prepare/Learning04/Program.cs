using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

         string myName = "Anthony Peterson";
        // base assignment
        Assignment Task1 = new Assignment(myName, "Multiplication");
        Console.WriteLine(Task1.GetSummmary());

        MathsAssignment Task2 = new MathsAssignment(myName, "maths", "section 7.3", "problems 8 - 17");
        Console.WriteLine(Task2.GetSummmary());
        Console.WriteLine(Task2.GetHomeworkList());

        WritingAssignment Task3 = new WritingAssignment(myName, "world History", "Nobody expects the spanish inquisition");
        Console.WriteLine(Task3.GetWritingInformation());

    }
}