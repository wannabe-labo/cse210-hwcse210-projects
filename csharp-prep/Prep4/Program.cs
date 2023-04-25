using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
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
      
        int largestNumber = numbers[0];
        int smallestPositiveNumber = numbers[0];
        numbers.Sort();

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            else if (number > 0 && number < smallestPositiveNumber)
            {
                smallestPositiveNumber = number;
            }
        }

        Console.WriteLine($"The largest is: {largestNumber}");

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}