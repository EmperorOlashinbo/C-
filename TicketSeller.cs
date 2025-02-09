using System;

namespace Assignment1
{
    public class TicketSeller
    {
        private string name; // Name of the ticket seller
        private double price = 99; // Price of a ticket
        private int numOfAdults; // Number of adult tickets sold
        private int numOfChildren; // Number of children tickets sold
        private double amountToPay; // Total amount to pay

        /// Reads user input to set ticket sales details.
        public void ReadTicketData()
        {
            Console.Write("Enter the ticket seller's name: "); // Prompt user to enter ticket seller's name
            name = Console.ReadLine(); // Read ticket seller's name

            Console.Write("Enter the number of adult tickets sold: "); // Prompt user to enter number of adult tickets sold
            numOfAdults = int.Parse(Console.ReadLine()); // Read the number of adult tickets sold

            Console.Write("Enter the number of children tickets sold: "); // Prompt user to enter number of children tickets sold
            numOfChildren = int.Parse(Console.ReadLine()); // Read the number of children tickets sold
            
            CalculatePayment(); // Calculate the total amount to pay
        }
        /// Calculates the total amount to pay based on the number of adult and children tickets sold.
        private void CalculatePayment()
        {
            double adultPrice = price; // Full price for adults
            double childPrice = price * 0.5; // 50% discount for children
            amountToPay = (numOfAdults * adultPrice) + (numOfChildren * childPrice); // Total amount to pay
        }
        /// Displays the ticket sales information.
        public void DisplayTicketInfo()
        {
            Console.WriteLine($"\nTicket Seller Information:"); // Display ticket seller information
            Console.WriteLine($"Name: {name}"); // Display ticket seller name
            Console.WriteLine($"Adult Tickets Sold: {numOfAdults}"); // Display number of adult tickets sold
            Console.WriteLine($"Children Tickets Sold: {numOfChildren}"); // Display number of children tickets sold
            Console.WriteLine($"Total Amount to Pay: {amountToPay:C}"); // Display total amount to pay
        }
        /// Starts the process of reading and displaying ticket sales data.
        public void Start()
        {
            ReadTicketData(); // Read ticket sales data
            DisplayTicketInfo(); // Display ticket sales information
        }
    }
}