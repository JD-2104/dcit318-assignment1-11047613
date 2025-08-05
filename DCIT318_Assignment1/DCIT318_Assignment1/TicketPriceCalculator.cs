using System;

class TicketPriceCalculator
{
    public static void Run()
    {
        const double regularPrice = 10.0;
        const double discountPrice = 7.0;

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double price;

        if (age <= 12 || age >= 65)
            price = discountPrice;
        else
            price = regularPrice;

        Console.WriteLine($"Your ticket price is: GHC{price}");
    }
}
