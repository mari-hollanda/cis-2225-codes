using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: November 17, 2021
 * Class: CIS-2225
 * Description: Assignment 5 - Horse Class
 */
namespace AnimalHospitalLibrary
{
    public class Horse : Animal
    {
        //Private Horse attributes
        private string horseType;

        //Static array of cat types used to populate the horse type
        public static string[] HORSE_TYPES = { "American Quarter Horse", "Andalusian", "Appaloosa", "Pony", "Warmblood" };

        //Public property to access catType
        public string HorseType { get => horseType; set => horseType = value; }

        //Custom Horse constructor. Must have parameters to satisfy the Animal base class constructor.
        //Parameters to base class Animal must be passed using base()
        public Horse(string name, int nLegs, string vDate, string reason, string color, string type) :
            base(name, nLegs, vDate, reason, color)//parameters passed to base class constructor
        {
            //set HorseType value
            HorseType = type;
        }

        //Must override abstract method AnimalTalk from Animal class
        public override string AnimalTalk()
        {
            return "The " + HorseType + " named " + base.AnimalName + " says WHINNY";
        }

        //Override the base classes toString method.
        //Include the toString method from base class
        public override string ToString()
        {
            return "The " + HorseType + " named " + base.ToString();
        }
    }
}
