using System;

namespace DesignPatterns.Visitor
{
    public class AreaVisitor : IShapeAreaVisitor
    {
        public double GetArea(Shape shape)
        {
            throw new NotSupportedException(shape.GetType().Name);
        }

        public double GetArea(Rectangle rectangle)
        {
            return Math.Abs((rectangle.First.X - rectangle.Second.X)*(rectangle.First.Y - rectangle.Second.Y));
        }

        public double GetArea(Circle circle)
        {
            return Math.PI*Math.Pow(circle.R, 2);
        }
    }
}