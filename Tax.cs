using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w06
{
    class Tax
    {
        public static double getTax(double yearIncome)
        {
            double tax = 0;
            if (yearIncome <= 150000)
            {
                tax = 0;
            }
            else if (yearIncome <= 300000)
            {
                tax = (yearIncome - 150000) * 0.05;
            }
            else if (yearIncome <= 500000)
            {
                tax = (yearIncome - 300000) * 0.1 + 7500;
            }
            else if (yearIncome <= 750000)
            {
                tax = (yearIncome - 500000) * 0.15 + 20000 + 7500;
            }
            else if (yearIncome <= 1000000)
            {
                tax = (yearIncome - 750000) * 0.2 + 37500 + 20000 + 7500;
            }
            else if (yearIncome <= 2000000)
            {
                tax = (yearIncome - 1000000) * 0.25 + 50000 + 37500 + 20000 + 7500;
            }
            else if (yearIncome <= 5000000)
            {
                tax = (yearIncome - 2000000) * 0.3 + 250000 + 50000 + 37500 + 20000 + 7500;
            }
            else if (yearIncome > 5000000)
            {
                tax = (yearIncome) * 0.35 + 600000 + 250000 + 50000 + 37500 + 20000 + 7500;
            }
            return tax;
        }
    }
}
