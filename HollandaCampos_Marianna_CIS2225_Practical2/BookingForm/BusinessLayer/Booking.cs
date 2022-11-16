using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: November 13, 2021
 * Class: CIS-2225
 * Description: Practical 2 - Booking Class
 */

namespace BookingForm.BusinessLayer
{
    class Booking
    {
        //Private form attributes
        private string venueName;
        private string firstName;
        private string lastName;
        private string email;
        private string bandType;
        private string eventSize;

        //Cost attributes
        private double baseCost;
        private double totalCost;

        //Getters and Setters 
        public string VenueName { get => venueName; set => venueName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string BandType { get => bandType; set => bandType = value; }
        public string EventSize { get => eventSize; set => eventSize = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }

        //Calculate Price Method
        public void CalculatePrice()
        {
            //Base Cost
            if (BandType == "Rock: $1500")
            {
                baseCost = 1500;
            }

            if (BandType == "Pop: $2000")
            {
                baseCost = 2000;
            }

            if (BandType == "Classical: $1200")
            {
                baseCost = 1200;
            }

            //Total Cost
            if (EventSize == "300 and under")
            {
                totalCost = baseCost;
            }

            if (EventSize == "301 to 600 spectators")
            {
                totalCost = baseCost * 2;
            }

            if (EventSize == "601 to 1200 spectators")
            {
                totalCost = baseCost * 4;
            }
        }
    }
}

