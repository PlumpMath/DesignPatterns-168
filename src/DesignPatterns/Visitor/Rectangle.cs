namespace DesignPatterns.Visitor
{
    public class Rectangle : Shape
    {
        public Point First { get; set; }
        public Point Second { get; set; }

        public override void Accept(IShapeDrawVisitor visitor, int x, int y)
        {
            visitor.Draw(this, x, y);
        }

        public override double Accept(IShapeAreaVisitor visitor)
        {
            return visitor.GetArea(this);
        }
    }
}