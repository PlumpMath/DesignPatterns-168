using System;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryExample
    {
        private static void PrintCarParts(ICarPartFactory carPartFactory)
        {
            var engine = carPartFactory.CreateEngine();
            engine.MakeNoise();

            var body = carPartFactory.CreatBody();
            body.Shine();

            var wheel = carPartFactory.CreateSteeringWheel();
            wheel.BehaveYourselfLikeSteeringWheel();
        }

        public static void Introduce()
        {
            var bmwFactory = new BmwCarPartFactory();
            Console.WriteLine("BMW");
            PrintCarParts(bmwFactory);
            Console.WriteLine();

            var audiFactory = new AudiCarPartFactory();
            Console.WriteLine("Audi");
            PrintCarParts(audiFactory);
            Console.WriteLine();
        }
    }
}
