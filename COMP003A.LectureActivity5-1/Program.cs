// Author: [Zaid Nemesis Rojas]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Demonstrate the creation and usage of classes in C#

namespace COMP003A.LectureActivity5_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", 2021);
            myCar.DisplayInfo();

            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2020;
            myCar.DisplayInfo();

            Car myCar2 = new Car("Ford", "Mustang", 2020);
            Car myCar3 = new Car("Chevorlet", "Camaro", 2021);
            Car.DisplayCarCount();
        }
    }

    internal class Car
    {
        // Fields
        private static int carCount = 0;
        private string make;
        private string model;
        private int year;

        // Properties
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { if (value >= 1886) year = value; }
        }

        /// <summary>
        /// Display the car information
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            carCount++;
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"Total cars created: {carCount}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car : {Year} {Make}  {Model}");
        }
    }
 
}