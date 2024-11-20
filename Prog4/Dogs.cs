// Grading ID: S2329
// Program 4
// Due: 04/19/2023
// CIS-199-50
// Dogs Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    internal class Dogs
    {
        // backing fields for each of dog specifications use in get and sets later on in the properties
        private string _dogName; // dog's name
        private string _dogBreed; //dog's breed
        private string _dogGender; // dog's gender
        private int _dogAge; // dog's age
        private string _dogColor; // dog's fur color
        private double _dogPrice; // dog's price
        private bool _isAvailable; // used for validation later in whether dog is adoptable

        // Constructor for dogs
        // precondition-  none
        // postcondition- setting the dog properties to parameters
        public Dogs(string name, string breed, string gender, int age, string color, double price)
        {
            DogName = name;
            DogBreed = breed;
            DogGender = gender;
            DogAge = age;
            DogFurColor = color;
            DogPrice = price;
            isAvailable();
            Availability();
        }



        // Property to get and set dogs name
        public string DogName
        {
            // precondition-  none
            // postcondition- the dogs name has been returned
            get { return _dogName; }
            // precondition-  none
            // postcondition- the dogs name has been set
            set { _dogName = value; }
        }

        // Property to get and set the dog's breed
        public string DogBreed
        {
            // precondition-  none
            // postcondition- the dogs breed has been returned
            get { return _dogBreed; }
            // precondition-  none
            // postcondition- the dogs breed has been set
            set { _dogBreed = value; }
        }

        // Property to get and set the dog's gender
        public string DogGender
        {
            // precondition-  none
            // postcondition- the dogs gender has been returned
            get { return _dogGender; }
            // precondition-  none
            // postcondition- the dogs gender has been set

            set { _dogGender = value; }
        }

        // Property for dogs age, uses if else as validation for a int greater than 0.

        public int DogAge
        {
            // precondition-  none
            // postcondition- the dogs age has been returned
            get { return _dogAge; }
            // precondition-  value > 0
            // postcondition- the dog's age is set to value > 0 
            set
            {
                if (_dogAge > 0)
                    _dogAge = value;

                else
                    _dogAge = 3;
            }

        }
        // Property to get and set the dogs fur color
        public string DogFurColor
        {
            // precondition-  none
            // postcondition- the dogs fur color has been returned
            get { return _dogColor; }
            // precondition-  none
            // postcondition- the dogs fur color has been set
            set { _dogColor = value; }
        }

        // Property to get and set the price of the dog
        public double DogPrice
        {
            // precondition-  none
            // postcondition- the dogs price has been returned
            get { return _dogPrice; }
            // precondition-  none
            // postcondition- the dogs price has been set
            set { _dogPrice = value; }
        }

        // Method to make _isAvailable true if dog is available
        public void isAvailable()
        { _isAvailable = true; }

        // Method to make _isAvailable false if dog has been adopted
        public void isAdopted()
        { _isAvailable = false; }

        // Method to return if the dog is available (true) or has been adopted (false)
        public bool Availability()
        { return _isAvailable; }

        // precondition- none
        // postcondition- a string is returned
        public override string ToString()
        {
            return $"Name:{DogName}{Environment.NewLine}" + $"Breed:{DogBreed}{Environment.NewLine}"
                + $"Gender:{DogGender}{Environment.NewLine}" + $"Age:{DogAge}{Environment.NewLine}"
                + $"Color:{DogFurColor}{Environment.NewLine}" + $"Price:{DogPrice}{Environment.NewLine}"
                + $"Is Available:{Availability()}{Environment.NewLine}";
        }
    }
}
