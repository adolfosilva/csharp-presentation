using System;

namespace CSharpEvolution.CSharp4
{
    enum CarColor
    {
        White,
        Black,
        Grey
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime PlateDate { get; set; }
        public CarColor Color { get; set; }
    }

    class CarFactory
    {
        public Car NewCar(string brand, string model, DateTime plateDate, CarColor color = CarColor.Black)
        {
            return new Car
            {
                Brand = brand,
                Model = model,
                PlateDate = plateDate,
                Color = color
            };
        }
    }

    public static class NamedOptionalArgsExamples
    {
        public static void Example1()
        {
            var factory = new CarFactory();
            var ford = factory.NewCar("Ford","Focus", plateDate:DateTime.Today);
            var renault = factory.NewCar(brand: "Renault", plateDate: DateTime.Today, model: "Clio");
        }
    }
}
