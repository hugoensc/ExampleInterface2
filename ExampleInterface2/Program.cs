using System;

namespace ExampleInterface2
{
    class Program
    {
        interface IEquatable<T>
        {
            bool Equals(T obj);
        }

        public class Car : IEquatable<Car>
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }

            public Car(string make, string model, string year)
            {
                Make = make;
                Model = model;
                Year = year;
            }
            public bool Equals(Car car)
            {
                return this.Make == car.Make &&
                        this.Model == car.Model &&
                        this.Year == car.Year;
            }
        }
        static void Main(string[] args)
        {
            Car newCar = new Car("Mexico", "2020", "2019");
            Car actualCar = new Car("Mexico", "2020", "2019");
            Car oldCar = new Car("Japon", "2001", "2000");
            Console.WriteLine(actualCar.Equals(newCar));
            Console.WriteLine(actualCar.Equals(oldCar));
        }
    }
}
