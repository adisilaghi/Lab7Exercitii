using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Lab7Exercitii
{
    internal class Car
    {
        private string brand;
        private string model;
        private int year;
        private Engine engine;
        private Doors doors;


        public Car(string brand, string model, int year, string fuelType, int hp, int cc, int doorsCount)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            engine = new Engine(hp, cc, fuelType);
            doors = new Doors(doorsCount);
        }
        public string GetDescription()
        {
            return $"{brand}, {model}, {year}, {engine.GetDescription()}, {doors.GetDescription()}\n";
        }
        public void startCar()
        {
            Console.WriteLine("Car Starts");
            doors.Close();
            engine.engineStart();
        }
        public void stopCar()
        {
            Console.WriteLine("\nCar Stops");
            engine.engineStop();
            doors.Open();
        }
    }
}





