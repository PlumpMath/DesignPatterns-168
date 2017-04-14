using System;

namespace DesignPatterns.Visitor
{
    public class DrawVisitor : IShapeDrawVisitor
    {
        public void Draw(Shape shape, int x, int y)
        {
            throw new NotSupportedException(shape.GetType().Name);
        }

        public void Draw(Circle circle, int x, int y)
        {
            Console.WriteLine($"Drawing some circle from ({x},{y})");
        }

        public void Draw(Rectangle rectangle, int x, int y)
        {
            Console.WriteLine($"Drawing some rectangle from ({x},{y})");
        }
    }
}
