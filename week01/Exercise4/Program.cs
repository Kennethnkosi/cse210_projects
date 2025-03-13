using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int numberEntry = -1;

        while (numberEntry != 0)
        {
            Console.Write("Enter a number: ");
            string entry = Console.ReadLine();
            numberEntry = int.Parse(entry);
            
            if (numberEntry != 0)
            {
                numbers.Add(numberEntry);
            }
            
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}