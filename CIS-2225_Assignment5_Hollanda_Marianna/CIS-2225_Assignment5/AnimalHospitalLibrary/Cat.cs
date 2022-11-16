using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: November 17, 2021
 * Class: CIS-2225
 * Description: Assignment 5 - Cat Class
 */
namespace AnimalHospitalLibrary
{
    public class Cat : Animal
    {
        //Private Cat attributes
        private string catType;

        //Static array of cat types used to populate the cat type
        public static string[] CAT_TYPES = { "Aegan", "Birman", "Burmese", "Foldex", "Persian" };

        //Public property to access catType
        public string CatType { get => catType; set => catType = value; }

        //Custom Cat constructor. Must have parameters to satisfy the Animal base class constructor.
        //Parameters to base class Animal must be passed using base()
        public Cat(string name, int nLegs, string vDate, string reason, string color, string type) :
            base(name, nLegs, vDate, reason, color)//parameters passed to base class constructor
        {
            //set CatType value
            CatType = type;
        }

        //Must override abstract method AnimalTalk from Animal class
        public override string AnimalTalk()
        {
            return "The " + CatType + " named " + base.AnimalName + " says MEOW";
        }

        //Override the base classes toString method.
        //Include the toString method from base class
        public override string ToString()
        {
            return "The " + CatType + " named " + base.ToString();
        }
    }
}
