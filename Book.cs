using System;

namespace Assignment1
{
    public class Book
    {
        private string title; // Title of the book
        private string author; // Author of the book
        private int numOfPages; // Number of pages in the book
        private DateTime publishedDate; // Published date of the book
        private const int MAX_PAGES = 10000; // Maximum number of pages allowed
        
        /// Reads user input to set book details.
        public void ReadBookData()
        {
            Console.Write("Enter the book title: "); // Prompt user to enter book title
            title = Console.ReadLine(); // Read book title

            Console.Write("Enter the author's name: "); // Prompt user to enter author's name
            author = Console.ReadLine(); // Read author's name

            Console.Write("Enter the number of pages: "); // Prompt user to enter number of pages
            numOfPages = int.Parse(Console.ReadLine()); // Read number of pages

            Console.Write("Enter the published date (YYYY-MM-DD): "); // Prompt user to enter published date
            publishedDate = DateTime.Parse(Console.ReadLine()); // Read published date
        }
        /// Displays the book information.
        public void DisplayBookInfo()
        {
            Console.WriteLine($"\nBook Information:"); // Display book information
            Console.WriteLine($"Title: {title}"); // Display book title
            Console.WriteLine($"Author: {author}"); // Display author's name
            Console.WriteLine($"Number of Pages: {numOfPages} (Max Allowed: {MAX_PAGES})"); // Display maximum number of pages allowed
            Console.WriteLine($"Published Date: {publishedDate:yyyy-MM-dd}"); // Display published date in YYYY-MM-DD format
        }
        /// Starts the process of reading and displaying book data.
        public void Start()
        {
            ReadBookData(); // Read book data
            DisplayBookInfo(); // Display book information
        }
    }
}