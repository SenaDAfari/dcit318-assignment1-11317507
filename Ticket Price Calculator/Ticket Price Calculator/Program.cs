using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        
        if (int.TryParse(input, out int age))
        {
            int ticketPrice;

            if (age <= 12 || age >= 65)
                ticketPrice = 7; // Discounted price
            else
                ticketPrice = 10; // Regular price

            Console.WriteLine($"Your ticket price is GHC{ticketPrice}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}