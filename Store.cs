using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CarOrganization
{
    internal class Store : Organization
    {
        private int availableCars;
        private List<Car> listOfCars = new List<Car>();

        public int Profit { get; set; }

        public int Revenue { get; set; }

        public int Expenditure { get; set; }

        public Store()
        {
        }

        public void carsInStore(int numberOfCars)
        {
            var random = new Random();

            string[] brandArray = new string[10] { "Volvo", "BMW", "Audi", "Skoda", "Hyundai", "Ferrari", "Volkswagen", "Seat", "Subaru", "Jeep" };
            int[] priceList = new int[10] { 400, 500, 500, 300, 200, 1000, 300, 200, 200, 700 };
            int costPerKm = 10;
            int kilometersDriven = 0;
            bool isAvailable = true;
            for (int i = 0; i < numberOfCars; i++)
            {
                var randomIndex = random.Next(brandArray.Length);
                Car car = new Car(brandArray[randomIndex], priceList[randomIndex], costPerKm, kilometersDriven, isAvailable);
                listOfCars.Add(car);
            }
        }

        public void printCars()
        {
            foreach (var item in listOfCars)
            {
                if (item.IsAvailable == true)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void AvailableCars()
        {
            availableCars = 0;
            foreach (var item in listOfCars)
            {
                if (item.IsAvailable == true)
                {
                    availableCars++;
                }
                else
                {
                    availableCars--;
                }
            }
            Console.WriteLine($"För tillfället har vi {availableCars + 1} bilar lediga att hyra ut.");
        }

        public void menu()
        {
            bool stayInMenu = true;
            do
            {
                Console.WriteLine("Välkommen. Vänligen välj ett alternativ:");
                Console.WriteLine("1. Se lediga bilar\n2. Kontakta vår service");
                var input = Console.ReadLine();
                var resultInput = int.TryParse(input, out int result);
                if (result == 1)
                {
                    Console.Clear();
                    printCars();
                    Console.WriteLine("Vilken bil vill du hyra? 1-10");
                    input = Console.ReadLine();
                    resultInput = int.TryParse(input, out int userInput);
                    Console.WriteLine("Hur många dagar vill du hyra bilen?");
                    input = Console.ReadLine();
                    var resultInputTwo = int.TryParse(input, out int userInputTwo);
                    Console.WriteLine("Hur många kilometer tänkte du köra per dag?");
                    input = Console.ReadLine();
                    var resultInputThree = int.TryParse(input, out int userInputThree);
                    rentCar(userInput, userInputTwo, userInputThree);
                    stayInMenu = false;
                }
                else if (result == 2)
                {
                    Console.WriteLine("Du når oss på telefon: 012-345 67 89");
                    Console.WriteLine("1. Se lediga bilar\n2. Kontakta vår service");
                    input = Console.ReadLine();
                    var userInput = int.TryParse(input, out int userResult);
                }
                else
                {
                    Console.WriteLine("Du har angett ett felaktigt alternativ, testa igen.");
                    input = Console.ReadLine();
                }
                Console.Clear();
            } while (stayInMenu);
        }

        public void rentCar(int rentCar, int numberOfDays, int predictedKilometers)
        {
            listOfCars[rentCar].IsAvailable = false;
            Revenue = Revenue + (listOfCars[rentCar].PricePerDay * numberOfDays);
            Expenditure = Expenditure + (listOfCars[rentCar].CostPerKm * predictedKilometers);
            listOfCars[rentCar].KilometersDriven = listOfCars[rentCar].KilometersDriven + predictedKilometers;
            Profit = Profit + (listOfCars[rentCar].PricePerDay * numberOfDays - (listOfCars[rentCar].CostPerKm * predictedKilometers));
        }

        public void checkNumbers()
        {
            Console.WriteLine($"Totalt\nOmsättning: {Revenue}\nUtgifter: {Expenditure}\nVinst: {Profit}");
        }

        public void crunchNumbersOrganization()
        {
            Revenue = Revenue;
            Profit = Profit;
            Expenditure = Expenditure;

            Organization carOrganization = new Store();
            carOrganization.organizationNumbers(Profit, Expenditure, Revenue);
            carOrganization.printNumbers();
        }
    }
}