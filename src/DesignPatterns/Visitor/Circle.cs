namespace DesignPatterns.Visitor
{
    public class Circle : Shape
    {
        public double R { get; set; }
        public Point Center { get; set; }

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