using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.DomainCode
{
    public class Movie
    {
        public enum Type
        {
            REGULAR, NEW_RELEASE, CHILDREN, UNKNOWN
        }

        private string _title;
        private Price _price;
        
        public Movie(string title, Type priceCode) 
        { 
            this._title = title;
            SetPriceCode(priceCode);
        }

        internal string GetTitle()
        {
            throw new NotImplementedException();
        }
        private void SetPriceCode(Type priceCode)
        {
            switch (priceCode)
            {
                case Type.CHILDREN:
                    _price = new ChildrensPrice(); 
                    break;
                case Type.NEW_RELEASE:
                    _price = new NewReleasePrice();
                    break;
                case Type.REGULAR:
                    _price = new RegularPrice();
                    break;
                default:
                    throw new ArgumentException("Invalid Price Code");
            }
        }

        internal double GetCharge(int daysRented)
        {
            return _price.GetCharge(daysRented);
        }

        internal int GetPoints(int daysRented)
        {
            return _price.GetPoints(daysRented);
        }

    }
}
