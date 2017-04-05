namespace DesignPatterns.AbstractFactory
{
    public interface IBody
    {
        void Shine();
    }

    public interface IEngine
    {
        void MakeNoise();
    }

    public interface ISteeringWheel
    {
        void BehaveYourselfLikeSteeringWheel();
    }

    public interface ICarPartFactory
    {
        IEngine CreateEngine();
        IBody CreatBody();
        ISteeringWheel CreateSteeringWheel();
    }
}