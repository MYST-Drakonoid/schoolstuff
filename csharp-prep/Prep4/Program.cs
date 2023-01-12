using System;
using System.Collections.Generic;

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Please enter a list of numbers and type 0 when finished");


        // creating variables
        string input = "";
        int intInput = 0;
        List<int> NUMBERS = new List<int>();
        int totalNumber = 0;
    
        // creating list
        do
        {

            
            Console.Write("enter a number: ");
            input = Console.ReadLine();
            intInput = int.Parse(input);
            NUMBERS.Add(intInput);



        } while (intInput > 0);

        // summing lists and creating average

        foreach (int number in NUMBERS)
        {
            totalNumber = totalNumber + number;

        }
        int numOfNum = NUMBERS.Count;
        float average = ((float)totalNumber) / numOfNum;

        // finding largest number

        int max = NUMBERS[0];

        foreach (int number in NUMBERS)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // finding smallest number
        
        int min = NUMBERS[0];

        foreach (int number in NUMBERS)
            {
                if (number < min && number > 0) 
                    {
                        min = number;
                    }
            }


        // Printing results to console

        Console.WriteLine($"The sum of the list is: {totalNumber}");

        Console.WriteLine($"the average of the list is :{average}");

        Console.WriteLine($"The largest number is: {max}");

        Console.WriteLine($"The smallest Positive number is: {min}");



    }
}