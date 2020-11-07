using System;
using System.Linq.Expressions;

namespace OOP_Basic_PL
{
    public class Car
    {
        private string _make;
        private int _yearOfProduction;
        private string _color;
        private double _dailyKilometerCounter;
        private int _petrolTankCapacity;
        private int _petrolUsagePer100Km;
        private double _kilometerCounter;
        private double _petrolLevel;

        //public int DailyKilometerCounter => Convert.ToInt32(_dailyKilometerCounter);

        public int DailyKilometerCounter
        {
            set
            {
                if(value > 999)
                    throw new ArgumentOutOfRangeException("Dkmc cannot be greater than 999");
            }

            get
            {
                return Convert.ToInt32(_dailyKilometerCounter);
            }
        }

        public int KilometerCounter
        {
            set
            {
                if (value > 999999)
                    throw new ArgumentOutOfRangeException("Kmc cannot be greater than 999999");
            }

            get
            {
                return Convert.ToInt32(_kilometerCounter);
            }
        }
        public string Make => _make;
        public int YearOfProduction => _yearOfProduction;
        public string Color => _color;
        public int PetrolTankCapacity => _petrolTankCapacity;
        public int PetrolUsagePer100Km => _petrolUsagePer100Km;

        //public int KilometerCounter => Convert.ToInt32(_kilometerCounter);
        public double PetrolLevel => _petrolLevel;

        public Car(string make, string color, int yearOfProduction, int petrolTankCapacity, int petrolUsagePer100km)
        {
            if (string.IsNullOrEmpty(make))
                throw new ArgumentNullException(_make);

            if (string.IsNullOrEmpty(color))
                throw new ArgumentNullException(_color);

            if (yearOfProduction < 2000 || yearOfProduction > DateTime.Now.Year)
                throw new ArgumentException("Year of production can be a number from 2000 to current year");

            if (petrolTankCapacity < 1)
                throw new ArgumentException("Petrol tank capacity needs to be positive");

            if (petrolUsagePer100km < 0)
                throw new ArgumentException("Petrol usage needs to be not negative");

            _make = make;
            _color = color;
            _yearOfProduction = yearOfProduction;
            _petrolTankCapacity = petrolTankCapacity;
            _petrolUsagePer100Km = petrolUsagePer100km;
        }

        public void Tank(int litres)
        {
            if (litres < 0)
                throw new ArgumentException("Provide a positive value");

            if (_petrolLevel + litres > _petrolTankCapacity)
                _petrolLevel = _petrolTankCapacity;
            else
                _petrolLevel += litres;
        }

        public void Drive(int kilometers)
        {
            if (kilometers < 0.0)
                throw new ArgumentException("Kilometers cannot be negative");

            var range = _petrolLevel * 100.0 / _petrolUsagePer100Km;
            if (kilometers > range)
            {
                _kilometerCounter += range;
                _dailyKilometerCounter += range;
                _petrolLevel = 0.0;
            }
            else
            {
                _kilometerCounter += kilometers;
                _dailyKilometerCounter += kilometers;
                _petrolLevel -= kilometers * PetrolUsagePer100Km / 100.0;
            }
        }

        public void Status()
        {
            Console.WriteLine($"Your {_make} Color {_color} has {_petrolLevel} liters, kmC is {KilometerCounter}, dkmC is {DailyKilometerCounter}");
        }

        public void ResetDailyKilometers()
        {
            _dailyKilometerCounter = 0.0;
        }

        public void ChangeTheColor(string color)
        {
            if (string.IsNullOrEmpty(color))
                throw new ArgumentNullException(_color);

            _color = color;
        }
    }
}