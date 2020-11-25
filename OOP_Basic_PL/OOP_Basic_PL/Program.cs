using System;

namespace OOP_Basic_PL
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //PointTest();
            CarTest();
        }

        private static void PointTest()
        {
            Point p = new Point(5, 5);
            Console.WriteLine(p.Distance());
            Console.WriteLine(p.Distance(10, 10));
            Console.WriteLine(p.Distance(0, 0, 5, 5));
            Console.WriteLine(p.ToString());
        }

        private static void CarTest()
        {
            Car car1 = new Car("Lada-Sedan", "Orange", 2019, 60, 10);

            //Console.WriteLine($"{car1.Make} was produced in {car1.YearOfProduction}");
            car1.Status();
            car1.Tank(60);
            car1.Drive(2);
            car1.Status();
            car1.ChangeTheColor("Purple");
            car1.Status();
            car1.ResetDailyKilometers();
            car1.Status();
            car1.Drive(10);
            car1.Status();
            car1.Tank(60);
            car1.Drive(25);
            car1.Status();



        }

        public class Person
        {
            public string name;


            public string Age { get; }
        }
    }
}
