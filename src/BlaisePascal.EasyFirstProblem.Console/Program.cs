using BlaisePascal.EasyFirstProblem.Domain;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("Welcome to the Library!");

        Console.WriteLine("Enter your name:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter the amount of books you have ordered:");
        int bookAmount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price of a single book:");
        int bookPrice = int.Parse(Console.ReadLine());

        Console.WriteLine("Are you a student? (yes/no)");
        bool student = false;
        if (Console.ReadLine() == "yes")
        {
            student = true;
        }

        Console.WriteLine("What kind of shipment would you like? (delivery/withdrawal)");
        string shipment = "None";
        if (Console.ReadLine() == "delivery")
        {
            shipment = "delivery";
        }
        else if (Console.ReadLine() == "withdrawal")
        {
            shipment = "withdrawal";
        }

        int subtotalPrice = bookAmount * bookPrice;
        int totalPrice = subtotalPrice;
        if (shipment == "delivery")
        {
            totalPrice += 5;
        }

        if (totalPrice <= 0 || bookAmount == 0)
        {
            Console.WriteLine("Your order is empty or costs nothing. Rewrite the order information.");
        }
        else
        {
            Console.WriteLine($"You are {username}, you ordered {bookAmount} books at the price of {bookPrice} euros each.");
            if (shipment == "delivery")
                Console.WriteLine($"Your subtotal is {subtotalPrice} and the price with delivery is {totalPrice}.");
            else Console.WriteLine($"Your total is {totalPrice} as you selected {shipment}.");
            Console.WriteLine("Thank you for your order!");
            if (totalPrice > 100)
                Console.WriteLine("Since this was a big order, you have a free coupon for 25% off your next order of books!");
        }
    }
}
