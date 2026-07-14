class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tip your Server!");

        //Total price of the Bill
        Console.Write("Enter the total price of the bill: $");
        if (decimal.TryParse(Console.ReadLine(), out decimal totalPrice) || totalPrice < 0)
        {
            //Get the tip percentage from the user
            Console.Write("Enter the tip percentage (e.g., 15 for 15%): ");
            if (double.TryParse(Console.ReadLine(), out double tipPercentage)) 
            {
                //Calculate the tip amount
                double tipDecimal = tipPercentage / 100;
                decimal tipAmount = totalPrice * (decimal)(tipPercentage / 100);
                //Calculate the total amount to be paid
                decimal totalAmount = totalPrice + tipAmount;
                //Display the results
                Console.WriteLine($"Bill Total: {totalPrice:C}");
                Console.WriteLine($"Tip Amount ({tipPercentage / 100:P0}) : {tipAmount:C}");
                Console.WriteLine("================================");
                Console.WriteLine($"Total Amount to be Paid: {totalAmount:C}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number for the tip percentage.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for the total price.");
        }
    }
}