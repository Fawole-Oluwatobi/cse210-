using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int guesses = 0;

            Console.WriteLine("Guess My Number Game!");
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guesses} tries.");
                }
            }

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}
