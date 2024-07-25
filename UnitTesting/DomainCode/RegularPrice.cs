using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.DomainCode
{
    public class RegularPrice : Price
    {
        public override double GetCharge(int daysRented)
        {
            double amount = 2;
            if (daysRented > 2) 
            {
                amount += (daysRented - 2) * 1.5;
            }
            return amount;
        }
    }
}
