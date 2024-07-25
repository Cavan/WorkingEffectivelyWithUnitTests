using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.DomainCode
{
    public abstract class Price
    {
        public abstract double GetCharge(int daysRented);
        public virtual int GetPoints(int daysRented)
        {
            return 1;
        }
    }
}
