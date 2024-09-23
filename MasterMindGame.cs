using System;
class MasterMInd
{
    static int GenerateSecret()
    {
        Random rnd = new Random();
        return rnd.Next(1000, 10000);  // Generates a number from 1000 to 9999
    }

    static string outputFeedback(string secretnumber, string userguess)
    {
        string feedback = "";
        for (int i = 0; i < 4; i++)
        {
            if (userguess[i] == secretnumber[i])
            {
                feedback += "  Hit ";
            }
            else if (secretnumber.Contains(userguess[i]))
            {
                feedback += " Close ";
            }
            else
            {
                feedback += " Miss ";
            }
        }
        return feedback;
    }
    static void Main(string[] args)
    {
        int secret = GenerateSecret();
        int attempts = 0;
        const int maxAttempts = 10;

        Console.WriteLine("Welcome to Simple Mastermind!");
        Console.WriteLine("Guess the 4-digit number between 1000 and 9999.");

        while (attempts < maxAttempts)
        {
            Console.Write($"Enter your guess (attempt {attempts + 1}/{maxAttempts}): ");
            string input = Console.ReadLine();
            int userguess;

           if (!int.TryParse(input, out userguess) || userguess < 1000 || userguess > 9999)
            {
                Console.WriteLine("Invalid guess. Please enter a 4-digit number between 1000 and 9999.");
                continue;
            }

            if (userguess == secret)
            {
                Console.WriteLine("Congratulations! You've guessed the number correctly!");
                break;
            }

            string feedback = outputFeedback(secret.ToString(), input);
            Console.WriteLine("Feedback: " + feedback);
            attempts++;
        }

        if (attempts == maxAttempts)
        {
            Console.WriteLine($"You've reached the maximum attempts. The secret number was: {secret}");
        }
    }

   
}