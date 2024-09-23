class Palindrome {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word: ");
        string userInput = Console.ReadLine().ToLower();//Takes user input and convert to lowercase.
        if (IsPalindrome(userInput))
            Console.WriteLine("The word "+userInput+ " is a palindrome.");//this will take a return value from boolean class, if there is true return
                                                                          //this will print userinput as palindrome else not a palindrome
        else
            Console.WriteLine("The word " + userInput + " is not a palindrome.");
      }
    static string Reversestring(string userInput)
    {
        string reversed = "";
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversed += userInput[i];
        }
        return reversed.ToString();
    }
    static bool IsPalindrome(string userInput)
        {
            string reversedStr = Reversestring(userInput);
            return userInput == reversedStr; // Returns true if palindrome, false otherwise
        }

        
    }
        