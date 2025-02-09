using System;

namespace Assignment1
{
    public class Album
    {
        private string albumName;   // Name of the album
        private string artistName; // Name of the artist
        private int numOfTracks; // Number of tracks in the album

        /// Reads user input to set album details.
        public void ReadAlbumData()
        {
            Console.Write("Enter the album's name: "); // Prompt user to enter album's name
            albumName = Console.ReadLine(); // Read album's name

            Console.Write("Enter the artist's name: "); // Prompt user to enter artist's name
            artistName = Console.ReadLine(); // Read artist's name

            Console.Write("Enter the number of tracks: "); // Prompt user to enter number of tracks
            numOfTracks = int.Parse(Console.ReadLine()); // Read number of tracks
        }
        /// Displays the album information.
        public void DisplayAlbumInfo()
        {
            Console.WriteLine($"\nAlbum Information:"); // Display album information
            Console.WriteLine($"Album Name: {albumName}"); // Display album name
            Console.WriteLine($"Artist Name: {artistName}"); // Display artist name
            Console.WriteLine($"Number of Tracks: {numOfTracks}"); // Display number of tracks
        }
        /// Starts the process of reading and displaying album data.
        public void Start()
        {
            ReadAlbumData(); // Read album data
            DisplayAlbumInfo(); // Display album information
        }
    }
}