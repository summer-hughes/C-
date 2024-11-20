// Grading ID: S2329
// Program 4
// Due: 04/19/2023
// CIS-199-50
// Cats class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    internal class Cats
    {
        // backing fields for each of cat specifications use in get and sets later on in the properties
        private string _catName; // cats name
        private string _catBreed; // cats breed
        private string _catGender; // cats gender
        private int _catAge; // cats age
        private string _catColor; // cats fur color
        private double _catPrice; // cats price
        private bool _isAvailable; // used for validation later on whether cat is adoptable.


        // Constructor for cats
        // precondition-  none
        // postcondition- setting the cat properties to parameters
        public Cats(string name, string breed, string gender, int age, string color, double price)
        {
            CatName = name;
            CatBreed = breed;
            CatGender = gender;
            CatAge = age;
            CatFurColor = color;
            CatPrice = price;
            isAvailable();
            Availability();
        }



        // Property to get and set cats name
        public string CatName
        {
            // precondition-  none
            // postcondition- the cats name has been returned
            get { return _catName; }
            // precondition-  none
            // postcondition- the cats name has been set
            set { _catName = value; }
        }

        // Property to get and set the cat's breed
        public string CatBreed
        {
            // precondition-  none
            // postcondition- the cats breed has been returned
            get { return _catBreed; }
            // precondition-  none
            // postcondition- the catss breed has been set
            set { _catBreed = value; }
        }

        // Property to get and set the cat's gender
        public string CatGender
        {
            // precondition-  none
            // postcondition- the cats gender has been returned
            get { return _catGender; }
            // precondition-  none
            // postcondition- the cats gender has been set
            set { _catGender = value; }
        }

        // Property for cat's age, uses if else as validation for a int greater than 0.

        public int CatAge
        {
            // precondition-  none
            // postcondition- the cats age has been returned
            get { return _catAge; }
            // precondition-  value > 0
            // postcondition- the cat's age is set to value > 0 
            set
            {
                if (_catAge > 0)
                    _catAge = value;

                else
                    _catAge = 3;
            }

        }
        // Property to get and set the cat's fur color
        public string CatFurColor
        {
            // precondition-  none
            // postcondition- the cats fur color has been returned
            get { return _catColor; }
            // precondition-  none
            // postcondition- the cats fur color has been set
            set { _catColor = value; }
        }

        // Property to get and set the price of the cat
        public double CatPrice
        {
            // precondition-  none
            // postcondition- the cats price has been returned
            get { return _catPrice; }
            // precondition-  none
            // postcondition- the cats price has been set
            set { _catPrice = value; }
        }

        // Method to make _isAvailable true if cat is available
        public void isAvailable()
        { _isAvailable = true; }

        // Method to make _isAvailable false if cat has been adopted
        public void isAdopted()
        { _isAvailable = false; }

        // Method to return if the cat is available (true) or has been adopted (false)
        public bool Availability()
        { return _isAvailable; }

        // Override method ToString to return cat specifications
        // precondition- none
        // postcondition- a string is returned
        public override string ToString()
        {
            return 
                $"Name: {CatName}{Environment.NewLine}" + $"Breed: {CatBreed}{Environment.NewLine}"
                    + $"Gender: {CatGender}{Environment.NewLine}" + $"Age: {CatAge} {Environment.NewLine}"
                    + $"Color: {CatFurColor} {Environment.NewLine}" + $"Price: {CatPrice} {Environment.NewLine}"
                    + $"Is Available: {Availability()}{Environment.NewLine}"; 
        }
    }
}


