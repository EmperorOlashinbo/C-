using System;

namespace Assignment1
{    
    class Program
    {
        static void Main(string[] args)
        {
            // Pet Object Creation
            Pet myPet = new Pet();
            myPet.Start(); // Start the process of reading and displaying pet data

            // Album Object Creation
            Album myAlbum = new Album();
            myAlbum.Start(); // Start the process of reading and displaying album data

            // TicketSeller Object Creation
            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.Start(); // Start the process of reading and displaying ticket sales data

            // Book Object Creation
            Book myBook = new Book();
            myBook.Start(); // Start the process of reading and displaying book data
        }
    }
}