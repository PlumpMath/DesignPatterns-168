using System;

namespace DesignPatterns.Visitor
{
    public static class VisitorExample
    {
        public static void Introduce()
        {
            Console.WriteLine();
            var rectangle = new Rectangle
            {
                First = new Point { X = 10, Y = 20 },
                Second = new Point { X = 0, Y = 3 }
            };
            var circle = new Circle
            {
                R = 10
            };

            var drawer = new DrawVisitor();
            var areaCalculator = new AreaVisitor();

            rectangle.Accept(drawer, 10, 15);
            circle.Accept(drawer, 1, 3);

            var circleArea = circle.Accept(areaCalculator);
            var rectangleArea = rectangle.Accept(areaCalculator);

            Console.WriteLine($"Circle area: {circleArea}");
            Console.WriteLine($"Rectangle area: {rectangleArea}");
        }
    }
}
