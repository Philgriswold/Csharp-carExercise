using System;

namespace ClassIntro
{

    class Car
    {
        //this is a field
        //These are similar properties but they are typically private
        //and dont specify getters and setters
        private string _vinNumber;

        private int _standardTestDrive = 5;

        public Car(string make, string model, int mileage)
        {
            Make = make;
            Model = model;
            Mileage = mileage;

            Random rand = new Random();
            _vinNumber = rand.Next(10_000, 1_000_000).ToString();
        }
        public string Make { get; set; }

        public int Year { get; set; }

        public string Model { get; set; }

        public int Mileage { get; private set; }

        public string Color { get; set; }

        public string CountryOfOrigin { get; set; }

        public bool IsInspected { get; set; }

        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }
        }

        public void Drive(int milesDriven)
        {
            this.Mileage += milesDriven;
        }

        public void Drive()
        {
            Mileage += 5;
        }
    }
}