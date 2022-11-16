using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalLibrary
{
    public abstract class Animal
    {
        private string animalName;
        private int animalNumberLegs;
        private string visitDate;
        private string visitReason;
        private string animalColor;

        public static List<Animal> animals = new List<Animal>();

        public string AnimalName { get => animalName; set => animalName = value; }
        public int AnimalNumberLegs { get => animalNumberLegs; set => animalNumberLegs = value; }
        public string VisitDate { get => visitDate; set => visitDate = value; }
        public string VisitReason { get => visitReason; set => visitReason = value; }
        public string AnimalColor { get => animalColor; set => animalColor = value; }

        public Animal(string name, int numLegs, string vDate, string reason, string color)
        {
            AnimalName = name;
            AnimalNumberLegs = numLegs;
            VisitDate = vDate;
            VisitReason = reason;
            AnimalColor = color;
        }

        public abstract string AnimalTalk();

        public override string ToString()
        {
            return AnimalName + " with " + AnimalNumberLegs + " legs and " + AnimalColor + " color visited on "
                + VisitDate + ". Reason: " + VisitReason; 
        }
    }
}
