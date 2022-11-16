using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: November 30, 2021
 * Class: CIS-2225
 * Description: Assignment 6 - Guest Class
 */
namespace CIS2225_Assignment6.BusinessObjects
{
    public class Guest
    {
        //private attributes
        private string lastName;
        private string firstName;
        private string street;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;
        private string lastVisitDate;
        private string room;
        private int guestId;


        //custom constructor used to populate combobox
        public Guest(string fName, string lname, int gID)
        {
            LastName = lname;
            FirstName = fName;
            GuestId = gID;
        }

        public Guest(string fName, string lName)
        {
            LastName = lName;
            FirstName = fName;
        }

        //default Guest constructor
        public Guest()
        {

        }

        //public properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string LastVisitDate { get => lastVisitDate; set => lastVisitDate = value; }
        public string Room { get => room; set => room = value; }
        public int GuestId { get => guestId; set => guestId = value; }

        //override toString to display firstName attibute value
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
