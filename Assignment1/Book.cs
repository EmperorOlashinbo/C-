using System;

namespace Assignment1
{
    public class Book
    {
        private string title;
        private string author;
        private int numOfPages;
        private DateTime publishedDate;
        private const int MAX_PAGES = 10000;

        public void ReadBookData()
        {
            Console.Write("Enter the book title: ");
            title = Console.ReadLine();

            Console.Write("Enter the author's name: ");
            author = Console.ReadLine();

            Console.Write("Enter the number of pages: ");
            numOfPages = int.Parse(Console.ReadLine());

            Console.Write("Enter the published date (YYYY-MM-DD): ");
            publishedDate = DateTime.Parse(Console.ReadLine());
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"\nBook Information:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Number of Pages: {numOfPages} (Max Allowed: {MAX_PAGES})");
            Console.WriteLine($"Published Date: {publishedDate:yyyy-MM-dd}");
        }

        public void Start()
        {
            ReadBookData();
            DisplayBookInfo();
        }
    }
}