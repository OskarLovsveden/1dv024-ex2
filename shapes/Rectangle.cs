namespace examination_2
{
    /// <summary>
    /// Rectangle public class that inherits from Shape2D
    /// </summary>
    public class Rectangle : Shape2D
    {
        /// <summary>
        /// Constructor that takes parameters length and width
        /// </summary>
        /// <param name="length">Represents the length</param>
        /// <param name="width">Represents the width</param>
        public Rectangle(double length, double width)
        : base(ShapeType.Rectangle, length, width)
        { }

        /// <summary>
        /// The Area property represents the area of the Rectangle
        /// </summary>
        /// <value>The Area property gets the value of the Rectangle area</value>
        public override double Area { get => Length * Width; }

        /// <summary>
        /// The Perimeter property represents the perimeter of the Rectangle
        /// </summary>
        /// <value>The Perimeter property gets the value of the Rectangle perimeter</value>
        public override double Perimeter { get => 2d * (Length + Width); }
    }
}
