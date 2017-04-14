namespace DesignPatterns.Visitor
{
    public interface IShapeAreaVisitor
    {
        double GetArea(Shape shape);
        double GetArea(Rectangle rectangle);
        double GetArea(Circle circle);
    }
}