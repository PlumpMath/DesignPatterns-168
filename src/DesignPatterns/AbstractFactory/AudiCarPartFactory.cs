using System;

namespace DesignPatterns.AbstractFactory
{
    public class AudiEngine : IEngine
    {
        public void MakeNoise()
        {
            Console.WriteLine("Regular audi wroom");
        }
    }

    public class AudiBody : IBody
    {
        public void Shine()
        {
            Console.WriteLine("I'm shining like audi");
        }
    }

    public class AudiSteeringWheel : ISteeringWheel
    {
        public void BehaveYourselfLikeSteeringWheel()
        {
            Console.WriteLine("I'm steering wheel with 4 intersecting circles emblem in center");
        }
    }

    public class AudiCarPartFactory : ICarPartFactory
    {
        public IEngine CreateEngine()
        {
            return new AudiEngine();
        }

        public IBody CreatBody()
        {
            return new AudiBody();
        }

        public ISteeringWheel CreateSteeringWheel()
        {
            return new AudiSteeringWheel();
        }
    }
}