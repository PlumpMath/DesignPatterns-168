namespace DesignPatterns.Visitor
{
    public interface IShapeDrawVisitor
    {
        void Draw(Shape shape, int x, int y);
        void Draw(Circle circle, int x, int y);
        void Draw(Rectangle rectangle, int x, int y);
    }
}