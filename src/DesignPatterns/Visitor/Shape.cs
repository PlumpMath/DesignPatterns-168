namespace DesignPatterns.Visitor
{
    public abstract class Shape
    {
        public abstract void Accept(IShapeDrawVisitor visitor, int x, int y);

        public abstract double Accept(IShapeAreaVisitor visitor);
    }
}