using System;

public class Entry

{
    public static void WriteEntry()
    {
        //get a prompt
        string _prompt = "";
        Console.WriteLine("Here's your prompt for today:");
        PromptGenerator.GeneratePrompt();

        //ask to input an answer
        Console.WriteLine("What's your answer?");
        string _answer = Console.ReadLine();

        //get the current date
        DateTime _currentDate = DateTime.Now;

        //display them
        Console.WriteLine("This is your Entry");
        Console.WriteLine($"{_prompt}\n {_answer}\n {_currentDate}")
    
    }
}