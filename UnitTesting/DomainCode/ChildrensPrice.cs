﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.DomainCode
{
    public class ChildrensPrice : Price
    {
        public override double GetCharge(int daysRented)
        {
            double amount = 1.5;
            if (daysRented > 3)
            {
                amount += (daysRented - 3) * 1.5;
            }
            return amount;
        }
    }
}
