namespace DesignPatterns.Visitor
{
    public abstract class Shape
    {
        public void Accept(IShapeDrawVisitor visitor, int x, int y)
        {
            visitor.Draw((dynamic) this, x, y);
        }

        public double Accept(IShapeAreaVisitor visitor)
        {
            return visitor.GetArea((dynamic) this);
        }
    }
}