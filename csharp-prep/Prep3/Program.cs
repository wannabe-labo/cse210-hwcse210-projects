using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            int guessNumber = 1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                    guessNumber ++;
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                    guessNumber ++;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You got the right number in {guessNumber}.");
                }
            }
            Console.WriteLine("Do you want to continue? ");
            response = Console.ReadLine();
        } while  (response == "yes");          
    }
}