using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.DomainCode
{
    public class NewReleasePrice : Price
    {
        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetPoints (int daysRented)
        {
            if (daysRented > 1)
            {
                return 2;
            }
            return 1;
        }
    }
}
