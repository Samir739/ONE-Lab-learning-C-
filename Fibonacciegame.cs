class Fibonacci
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any number greater then 0: ");
        int firstnumber = Convert.ToInt32(Console.ReadLine());
        long x = 0;
        long y = 1;
        for (int i = 0; i <= firstnumber-1; i++)
        {
            Console.WriteLine($"{Ordinal(i+1)} number: " + x);
            long a = x;
            x = y;
            y = a + y;
        }
        static string Ordinal(int number)
        {
            if (number % 100 >= 11 && number % 100 <= 13)
                return number + "th";

            switch (number % 10)
            {
                case 1: return number + "st";
                case 2: return number + "nd";
                case 3: return number + "rd";
                default: return number + "th";
            }
        }
    }
}

