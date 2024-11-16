using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 99);

        int guess = -1;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("Guess a number 1-99! ");
            guess = int.Parse(Console.ReadLine());
            guessCount = guessCount + 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
            }
        }                    
    }
}
