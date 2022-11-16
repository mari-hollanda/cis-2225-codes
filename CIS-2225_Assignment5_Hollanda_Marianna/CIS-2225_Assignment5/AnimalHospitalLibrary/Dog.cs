using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalLibrary
{
    public class Dog : Animal
    {
        //private Dog attibutes
        private string dogType;

        //static array of dog types used to populate the dog type combo box
        public static string[] DOG_TYPES = { "Lab", "Poodle", "Shepard", "Hound", "Mix" };
        
        //public property to access dogType
        public string DogType { get => dogType; set => dogType = value; }

        //Custom Dog constructor. Must have parameters to satisfy the Animal base class constructor.
        //Parameters to base class Animal must be passed using base()
        public Dog(string name, int nLegs, string vDate, string reason, string color,string type) : 
            base(name, nLegs, vDate, reason, color)//parameters passed to base class constructor
        {
            //set DogType value
            DogType = type;
        }

        //Must override abstract method AnimalTalk from Animal class
        public override string AnimalTalk()
        {
            return "The " + DogType + " named " + base.AnimalName + " says BARK";
        }

        //Override the base classes toString method.
        //Include the toString method from base class
        public override string ToString()
        {
            return "The " + DogType + " named " + base.ToString();
        }


    }
}
