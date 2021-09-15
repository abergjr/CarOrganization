using System;
using System.Threading;

namespace CarOrganization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool keepGoing = true;
            Store storeOne = new Store();
            storeOne.carsInStore(10);
            Store storeTwo = new Store();
            storeTwo.carsInStore(15);

            do
            {
                storeOne.menu();
                storeOne.AvailableCars();
                storeOne.checkNumbers();

                storeTwo.menu();
                storeTwo.AvailableCars();
                storeTwo.checkNumbers();
                storeOne.crunchNumbersOrganization();

                Console.WriteLine("Vill du hyra ytterligare en bil? Y/N");
                string userInput = Console.ReadLine().ToLower();
                if (userInput.Equals("y"))
                {
                    keepGoing = true;
                }
                else if (userInput.Equals("n"))
                {
                    Console.WriteLine("Tack för idag!");
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Felaktig inamtning, testa på nytt.");
                    userInput = Console.ReadLine().ToLower();
                }
            } while (keepGoing == true);

            //storeOne.rentCar();
        }
    }
}