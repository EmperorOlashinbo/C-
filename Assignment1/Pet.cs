
using System;

namespace Assignment1
{
    public class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public Pet(string name, int age, bool isFemale)
        {
            this.name = name;
            this.age = age;
            this.isFemale = isFemale;
        }

        public void DisplayPetInfo()
        {
            string gender = isFemale ? "Female" : "Male";
            Console.WriteLine($"\nPet Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
        }
    }
}