using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrganization
{
    internal class Car : Store
    {
        public string Brand { get; set; }

        public int PricePerDay { get; set; }

        public int CostPerKm { get; set; }

        public int KilometersDriven { get; set; }

        public bool IsAvailable { get; set; }

        public Car(string brand, int pricePerDay, int costPerKm, int kilometersDriven, bool isAvailable)
        {
            Brand = brand;
            PricePerDay = pricePerDay;
            CostPerKm = costPerKm;
            KilometersDriven = kilometersDriven;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return $"Bil: {Brand}, Pris: {PricePerDay}, Kilometer körda: {KilometersDriven}, Tillgänglig: {(IsAvailable ? "Ja" : "Nej")}";
        }
    }
}