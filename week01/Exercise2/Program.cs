using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter grade percentage: ");
        string userEntry = Console.ReadLine();
        int valueFromUser = int.Parse(userEntry);

        string letter = "";

        if (valueFromUser >= 90)
        {
            letter = "A";
        }
        else if (valueFromUser >= 80)
        {
            letter = "B";
        }
        else if (valueFromUser >= 70)
        {
            letter = "C";
        }
        else if (valueFromUser >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (valueFromUser >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else
        {
            Console.WriteLine("Sorry you didn't make it, please try again");
        }
    }
}