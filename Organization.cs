using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrganization
{
    internal interface Organization
    {
        public int Profit { get; set; }

        public int Revenue { get; set; }

        public int Expenditure { get; set; }

        public void organizationNumbers(int profit, int expenditure, int revenue)
        {
            Expenditure = expenditure;
            Revenue = revenue;
            Profit = profit;
        }

        public void printNumbers()
        {
            Console.WriteLine($"Totalt för organisationen\nOmsättning: {Revenue}\nUtgifter: {Expenditure}\nVinst: {Profit}");
        }
    }
}