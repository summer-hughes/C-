// Grading ID: S2329
// Program 4
// Due: 04/19/2023
// CIS-199-50
// This program is for listing out cats and dogs with their various specs, and showing whether they are available for adoption or not.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog4
{
    internal class Program
    {
        // preconditon- none
        // postcondition- objects created and output
        public static void Main(string[] args)
        {
            // Creating 5 objects, one for each dog up for adoption
            Dogs d1 = new Dogs("Lucy", "Great Pyreness", "F", 7, "White", 150.00);
            Dogs d2 = new Dogs("Ruby", "Black Lab", "F", 4, "Black", 160.00);
            Dogs d3 = new Dogs("Julia", "Bichon", "F", 16, "White", 300.00);
            Dogs d4 = new Dogs("Remi", "Golden Retriever", "F", 3, "Golden", 250.00);
            Dogs d5 = new Dogs("Annie", "Plot Hound", "F", 10, "Brindle", 150.00);

            // Creating 5 objects, one for each cat up for adoption
            Cats c1 = new Cats("Mittens", "Bengal", "F", 1, "Brown", 100.00);
            Cats c2 = new Cats("Liam", "Maine Coon", "M", 2, "Black", 500.00);
            Cats c3 = new Cats("Mia", "Domestic Shorthair", "F", 7, "White", 200.00);
            Cats c4 = new Cats("Burly", "Calico", "M", 4, "Calico", 150.00);
            Cats c5 = new Cats("Taco", "Tabby", "F", 5, "Orange", 600.00);

            Dogs[] dogs = { d1, d2, d3, d4, d5 }; // Array of dogs
            Cats[] cats = { c1, c2, c3, c4, c5 }; // Array of cats

            // List out all the pets
            WriteLine("List of Pets");
            WriteLine("------------");
            WriteLine("Dogs:");
            WriteLine("");

            DisplayDogs(dogs);

            WriteLine("Cats:");
            WriteLine("");

            DisplayCats(cats);

            // List out all of pets with one change made to the first cat in the list to adopted/ is available false.
            WriteLine("After 1st Change");
            WriteLine("----------------");

            c1.isAdopted();

            WriteLine("Dogs:");
            WriteLine("");

            DisplayDogs(dogs);

            WriteLine("Cats:");
            WriteLine("");

            DisplayCats(cats);

            // List all pets, has the first change, and the second change with all the dogs to is available: false.
            WriteLine("After 2nd Change");
            WriteLine("----------------");
            // foreach loop to put all the dogs as adopted
            foreach (Dogs dog in dogs)
            { dog.isAdopted(); }

            WriteLine("Dogs");
            WriteLine("");

            DisplayDogs(dogs);

            WriteLine("Cats");
            WriteLine("");

            DisplayCats(cats);


        }

        // Method for dogs to accept arrays of dogs, and is called to list out all dogs in the main
        static void DisplayDogs(Dogs[] dogs)
        { foreach (Dogs dog in dogs)
            { WriteLine(dog); }
        }

        // Method for cats to accept arrays of cats, and is called to list out all cats in the main
        static void DisplayCats(Cats[] cats)
        {
            foreach (Cats cat in cats)
            { WriteLine(cat); }
        }
    }
}
