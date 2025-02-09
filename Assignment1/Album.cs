using System;

namespace Assignment1
{
    public class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public Album(string albumName, string artistName, int numOfTracks)
        {
            this.albumName = albumName;
            this.artistName = artistName;
            this.numOfTracks = numOfTracks;
        }

        public void DisplayAlbumInfo()
        {
            Console.WriteLine($"\nAlbum Information:");
            Console.WriteLine($"Album Name: {albumName}");
            Console.WriteLine($"Artist Name: {artistName}");
            Console.WriteLine($"Number of Tracks: {numOfTracks}");
        }
    }
}