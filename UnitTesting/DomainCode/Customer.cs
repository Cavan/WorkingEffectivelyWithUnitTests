using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.DomainCode
{
    public class Customer
    {
        private string name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(string name) 
        {
            this.name = name;
        }

        public string GetName() 
        { 
            return name; 
        }

        public List<Rental> GetRentals() 
        { 
            return rentals; 
        }

        public void addRental(Rental rental) 
        { 
            rentals.Add(rental); 
        }

        public string Statement()
        {
            string result =
                "Rental record for " + GetName() + "\n";
            foreach (Rental rental in rentals)
            {
                result +=
                    "Amount owed is " + GetTotalCharge() +
                    "\n" + "You earned " +
                    GetTotalPoints() +
                    " frequent renter points";
            }
            return result;
        }

        public string HtmlStatement()
        {
            string result =
                "<h1>Rental record for <em>" +
                GetName() + "</em></h1>\n";
            foreach (Rental rental in rentals)
            {
                result += "<p>" + rental.GetLineItem() +
                    "</p>\n";
                result +=
                    "<p>Amount owed is <em>" +
                    GetTotalCharge() + "</em></p>\n" +
                    "<p>You earned <em>" +
                    GetTotalPoints() +
                    " frequent renter points</em></p>";
            }
            return result;
        }
        private double GetTotalCharge()
        {
            double total = 0;
            foreach (Rental rental in rentals)
            {
                total += rental.GetCharge();
            }
            return total;
        }
        private int GetTotalPoints()
        {
            int total = 0;
            foreach (Rental rental in rentals)
            {
                total += rental.GetPoints();
            }
            return total;
        }

    }
}
