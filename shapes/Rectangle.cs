namespace examination_2
{
    public class Rectangle : Shape2D
    {
        public Rectangle(double length, double width)
        : base(ShapeType.Rectangle, length, width)
        { }
        public override double Area
        {
            get;
        }
        public override double Perimeter
        {
            get;
        }
    }
}
