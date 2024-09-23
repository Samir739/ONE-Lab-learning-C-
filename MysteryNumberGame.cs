using System;
class MysteryNumberGame
{
    static void Main(string[] args)
    {
        Random rnd = new Random();//generates the random number as guiven index by the user
        int mysterynumber = rnd.Next(1, 100);
        Console.WriteLine("Welcome to the Mystery Number Game");
        Console.WriteLine("Guess any number from 1 to 100. You have 7 attempts to choose correct number.");
        int count = 0;
        bool success = false;
        while (count < 7)
        {
            Console.WriteLine(" Enter your Guess: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());// takes number from user
            count++;
            if (userGuess == mysterynumber)
            {
                Console.WriteLine("Congraatulations! You've guessed the right number!");
                success = true;
                break;
            }
            else if (userGuess < mysterynumber)
            {
                Console.WriteLine("Too Low! Try Again");
            }
            else 
                    {
                Console.WriteLine("Too High! Try Again");

            }
        }
        if (!success)
        {
          Console.WriteLine($"Sorry, You have used all your attempts. The correct Mystery Number is "+ mysterynumber);
            Console.WriteLine("Do you want to play again");
        }

    }
}