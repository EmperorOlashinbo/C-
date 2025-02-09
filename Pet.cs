
using System;

namespace Assignment1
{
    public class Pet
    {
        private string name; // Name of the pet
        private int age; // Age of the pet
        private bool isFemale; // Gender of the pet

        /// Reads user input to set pet details.
        public void ReadAndSavePetData()
        {
            Console.Write("Enter the pet's name: "); // Prompt user to enter pet's name
            name = Console.ReadLine(); // Read pet's name

            Console.Write("Enter the pet's age: "); // Prompt user to enter pet's age
            age = int.Parse(Console.ReadLine()); // Read pet's age

            Console.Write("Is the pet female? (true/false): "); // Prompt user to enter pet
            isFemale = bool.Parse(Console.ReadLine()); // Read pet
        }
        /// Displays the pet information.
        public void DisplayPetInfo()
        {
            string gender = isFemale ? "Female" : "Male"; // Determine
            Console.WriteLine($"\nPet Information:"); // Display pet information
            Console.WriteLine($"Name: {name}"); // Display pet's name
            Console.WriteLine($"Age: {age}"); // Display pet's age
            Console.WriteLine($"Gender: {gender}"); // Display gender of the pet
        }
        /// Starts the process of reading and displaying pet data.
        public void Start()
        {
            ReadAndSavePetData(); // Read pet data
            DisplayPetInfo(); // Display pet information
        }
    }
}