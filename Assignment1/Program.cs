using System;

namespace Assignment1
{    
    class Program
    {
        static void Main(string[] args)
        {
            // Pet Object Creation
            Console.Write("Enter the pet's name: ");
            string petName = Console.ReadLine();

            Console.Write("Enter the pet's age: ");
            int petAge = int.Parse(Console.ReadLine());

            Console.Write("Is the pet female? (true/false): ");
            bool petIsFemale = bool.Parse(Console.ReadLine());

            Pet myPet = new Pet(petName, petAge, petIsFemale);
            myPet.DisplayPetInfo();

            // Album Object Creation
            Console.Write("Enter the album's name: ");
            string albumName = Console.ReadLine();

            Console.Write("Enter the artist's name: ");
            string artistName = Console.ReadLine();

            Console.Write("Enter the number of tracks: ");
            int numOfTracks = int.Parse(Console.ReadLine());

            Album myAlbum = new Album(albumName, artistName, numOfTracks);
            myAlbum.DisplayAlbumInfo();

            // TicketSeller Object Creation
            Console.Write("Enter the ticket seller's name: ");
            string sellerName = Console.ReadLine();

            Console.Write("Enter the number of adult tickets sold: ");
            int adultTickets = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of children tickets sold: ");
            int childTickets = int.Parse(Console.ReadLine());

            TicketSeller ticketSeller = new TicketSeller(sellerName, adultTickets, childTickets);
            ticketSeller.DisplayTicketInfo();

            // Book Object Creation
            Book myBook = new Book();
            myBook.Start();
        }
    }
}