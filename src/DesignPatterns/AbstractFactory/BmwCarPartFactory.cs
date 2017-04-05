using System;

namespace DesignPatterns.AbstractFactory
{
    public class BmwBody : IBody
    {
        public void Shine()
        {
            Console.WriteLine("I'm shining like bmw");
        }
    }

    public class BmwEngine : IEngine
    {
        public void MakeNoise()
        {
            Console.WriteLine("BMWroom");
        }
    }

    public class BmwSteeringWheel : ISteeringWheel
    {
        public void BehaveYourselfLikeSteeringWheel()
        {
            Console.WriteLine("I'm steering wheel with round bmw emblem in center");
        }
    }

    public class BmwCarPartFactory : ICarPartFactory
    {
        public IEngine CreateEngine()
        {
            return new BmwEngine();
        }

        public IBody CreatBody()
        {
            return new BmwBody();
        }

        public ISteeringWheel CreateSteeringWheel()
        {
            return new BmwSteeringWheel();
        }
    }
}