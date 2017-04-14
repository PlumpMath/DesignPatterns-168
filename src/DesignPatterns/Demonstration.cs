using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.State;

namespace DesignPatterns
{
    public class Demonstration
    {
        public static void Main(string[] args)
        {
            AbstractFactoryExample.Introduce();
            BuilderExample.Introduce();
            ChainOfResponsibilityExample.Introduce();
            StateExample.Introduce();
        }
    }
}
