/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: October 28, 2021
 * Class: CIS-2225
 * Description: Assignment 4 - Villager Class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2225_Assignment4_HollandaCP_Marianna.BusinessLayer
{
    class Villagers
    {
        //Global variables
        private string name;
        private string specie;
        private string birthday;
        private string hobby;
        private string personality;

        public static List<Villagers> villagersList = new List<Villagers>();

        //List of Personalities
        public static string[] personalityType = { "Jock", "Cranky", "Peppy", "Sisterly", "Lazy", "Normal", "Snooty", "Smug" };

        //Getters and Setters 
        public string Name { get => name; set => name = value; }
        public string Specie { get => specie; set => specie = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string Personality { get => personality; set => personality = value; }

        //ToString method Overrided
        public override string ToString()
        {

            return "Villager: " + name +  ". || Specie: " + specie + ". Personality: " + personality + ". || Birthday: " + birthday + ". || Hobby: " + hobby;
        }

    }
}
