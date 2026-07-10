using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter yout 5 - letter guess");
        String guess = Console.ReadLine();
        guess = (guess ?? "").ToUpper();
        Console.WriteLine("\n your guess");
        foreach(char letter in guess)
        {
            Console.WriteLine(letter);
        }
        Console.WriteLine();
    }
}

