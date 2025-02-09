using System;

namespace Assignment1
{
    public class TicketSeller
    {
        private string name;
        private double price = 99;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public TicketSeller(string name, int numOfAdults, int numOfChildren)
        {
            this.name = name;
            this.numOfAdults = numOfAdults;
            this.numOfChildren = numOfChildren;
            CalculatePayment();
        }

        private void CalculatePayment()
        {
            double adultPrice = price;
            double childPrice = price * 0.5;
            amountToPay = (numOfAdults * adultPrice) + (numOfChildren * childPrice);
        }

        public void DisplayTicketInfo()
        {
            Console.WriteLine($"\nTicket Seller Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Adult Tickets Sold: {numOfAdults}");
            Console.WriteLine($"Children Tickets Sold: {numOfChildren}");
            Console.WriteLine($"Total Amount to Pay: {amountToPay:C}");
        }
    }
}