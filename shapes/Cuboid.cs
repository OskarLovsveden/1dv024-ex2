namespace examination_2
{
    /// <summary>
    /// Cuboid public class that inherits from Shape3D
    /// </summary>
    public class Cuboid : Shape3D
    {
        /// <summary>
        /// Constructor that takes parameters length, width and height
        /// </summary>
        /// <param name="length">Represents the length</param>
        /// <param name="width">Represents the width</param>
        /// <param name="height">Represents the height</param>
        public Cuboid(double length, double width, double height)
        : base(ShapeType.Cuboid, new Rectangle(length, width), height)
        { }
    }
}
