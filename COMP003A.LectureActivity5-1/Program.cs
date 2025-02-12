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
 
}