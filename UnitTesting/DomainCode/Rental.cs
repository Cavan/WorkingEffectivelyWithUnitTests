using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.DomainCode
{

    public class Rental
    {
        private Movie _movie;
        private int daysRented;

        public Rental(Movie movie, int daysRented) 
        {
            this._movie = movie;
            this.daysRented = daysRented;
        }

        public Movie GetMovie()
        {
            return _movie;
        }

        public int GetDaysRented()
        {
            return daysRented;
        }
        public double GetCharge()
        {
            return _movie.GetCharge(daysRented);
        }

        public int GetPoints()
        {
            return _movie.GetPoints(daysRented);
        }
        public string GetLineItem()
        {
            return _movie.GetTitle() + " " + GetCharge();
        }
    }
}
