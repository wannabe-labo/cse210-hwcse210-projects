using System;
using System.Linq;
using System.Collections.Generic;
public class PromptGenerator
{
    public static void GeneratePrompt()
    {
        //make a list that has prompts inside
        List<string> prompts = new List<string>(){"What are three things that you're grateful for today?",
                                "Describe a recent challenge you faced and how you overcame it.",
                                "Write about a moment that made you feel proud of yourself.",
                                "What's something that you've been procrastinating on, and what steps can you take to start working on it?",
                                "Write about a recent accomplishment that you're proud of."};

        //pick a random prompt from the list  
        Random random = new Random();

        int rnd = random.Next(prompts.Count);
        Console.WriteLine(prompts[rnd]);
        string _prompt = prompts[rnd];
    }
}